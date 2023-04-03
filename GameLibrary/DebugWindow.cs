using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLibrary
{
    public partial class DebugWindow : Form
    {
        string compilerPath;
        string destinationFolder;
        string fileName;
        string fileIcon;
        string executableText;


        public DebugWindow()
        {
            InitializeComponent();
            updateVarValue();
            
            destinationTextBox.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }

        private void updateVarValue()
        {
            compilerPath = compilerPathTextBox.Text;
            destinationFolder = destinationTextBox.Text;

            fileName = fileNameTextBox.Text;

            if (!string.IsNullOrEmpty(fileName))
            {
                if (Path.GetExtension(fileName) != ".exe")
                {
                    fileNameTextBox.Text = Path.ChangeExtension(fileName, ".exe");
                    fileName = fileNameTextBox.Text;
                }

                fileIcon = iconTextBox.Text;
                executableText = executableTextTextBox.Text;
            }
            else
            {
                fileNameTextBox.Text = "programe.exe";
                fileName = fileNameTextBox.Text;
            }

        }

        private void compilerPathButton_Click(object sender, EventArgs e)
        {
            updateVarValue();
            openFileDialog1.InitialDirectory = Directory.GetParent(compilerPath).ToString();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                compilerPathTextBox.Text = openFileDialog1.FileName;
                updateVarValue();
            }
        }

        private void destinationButton_Click(object sender, EventArgs e)
        {
            updateVarValue();

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                destinationTextBox.Text = folderBrowserDialog1.SelectedPath;
                updateVarValue();
            }
        }

        private void iconButton_Click(object sender, EventArgs e)
        {
            updateVarValue();
            //iconOpenFileDialog.InitialDirectory = Directory.GetParent(compilerPath).ToString();

            if (iconOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                iconTextBox.Text = iconOpenFileDialog.FileName;
                updateVarValue();

                iconPictureBox.Load(fileIcon);
            }
        }

        private async void compileButton_Click(object sender, EventArgs e)
        {
            updateVarValue();
            string programeFile = Path.Combine(Path.GetTempPath(), "gameLibraryPrograme.cs");
            string programeFileContent = string.Format(@"using System;namespace HelloWorldApp {{class A{{static void Main(string[] args){{Console.WriteLine(""{0}"");Console.ReadKey();}}}}}}", executableText);
            string compileCommand = "/target:exe /out:test.exe ";
            string finaleFile = Path.Combine(destinationFolder, fileName);

            if(File.Exists(finaleFile))
            {
                MessageBox.Show(fileName + " already exists");
                return; ;
            }

            File.WriteAllText(programeFile, programeFileContent);

            if (!string.IsNullOrEmpty(fileIcon))
            {
                compileCommand += "/win32icon:"+fileIcon+" ";
            }
            compileCommand += programeFile;

            Console.WriteLine(compileCommand);

            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();

            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.FileName = compilerPath;
            startInfo.WorkingDirectory = destinationFolder;
            startInfo.Arguments = compileCommand;

            process.StartInfo = startInfo;
            process.Start();

            process.EnableRaisingEvents = true;
            TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();

            EventHandler exitedHandler = (send, ev) =>
            {
                tcs.TrySetResult(true);

                File.Delete(programeFile);
                File.Move(Path.Combine(destinationFolder, "test.exe"), finaleFile);
                MessageBox.Show("Successfully compiled");
            };

            process.Exited += exitedHandler;
            await tcs.Task;
        }
    }
}
