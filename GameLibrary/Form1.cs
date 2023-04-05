using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Collections.Specialized;
using System.Diagnostics;
using Microsoft.Win32;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace GameLibrary
{
    public partial class Form1 : Form
    {
        public static string _registryKeyPath = @"SOFTWARE\GameLibrary";
        public static bool useVerticalIcon = false;
        public static string sgdbApiKey;

        RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(_registryKeyPath);

        ToolTip toolTip1 = new ToolTip();
        DebugWindow debugWindow = new DebugWindow();
        SettingsWindow settingsWindow;

        public Form1()
        {
            InitializeComponent();
            InitDataFile();

            debugWindow.Dispose();
        }

        private void InitDataFile()
        {
            DBManager.Init();

            if (registryKey != null)
            {
                if (registryKey.GetValue("UseVerticalIcon", null) != null)
                {
                    useVerticalIcon = bool.Parse(registryKey.GetValue("UseVerticalIcon", "False").ToString());
                }
                else
                {
                    RegistryKey key = Registry.CurrentUser.CreateSubKey(_registryKeyPath);

                    key.SetValue("UseVerticalIcon", false);
                    key.Close();
                }

                if (registryKey.GetValue("SgdbApiKey", "").ToString() != "")
                {
                    sgdbApiKey = registryKey.GetValue("SgdbApiKey", " ").ToString();
                }
                else
                {
                    RegistryKey key = Registry.CurrentUser.CreateSubKey(_registryKeyPath);

                    key.SetValue("SgdbApiKey", "");
                    key.Close();
                }

                if (registryKey.GetValue("GameFolderPath", "").ToString() != "")
                {
                    gameDirectory.Text = registryKey.GetValue("GameFolderPath", "").ToString();
                    LoadGame();
                }
                else
                {
                    RegistryKey key = Registry.CurrentUser.CreateSubKey(_registryKeyPath);

                    key.SetValue("GameFolderPath", "");
                    key.Close();
                }
            }
            else
            {
                RegistryKey key = Registry.CurrentUser.CreateSubKey(_registryKeyPath);

                key.SetValue("GameFolderPath", "");
                key.SetValue("UseVerticalIcon", false);
                key.SetValue("SgdbApiKey", "");
                key.Close();
            }
        }

        public void LoadGame()
        {
            flowLayoutPanel1.Controls.Clear(); 

            string folder = gameDirectory.Text;

            if (!Directory.Exists(folder))
            {
                MessageBox.Show("Unable to find folder " + folder);
                return;
            }

            string[] folders = Directory.GetDirectories(folder);

            foreach (string folderPath in folders)
            {
                if (!Directory.Exists(folderPath))
                {
                    MessageBox.Show("Unable to find folder " + folderPath);
                    return;
                }

                FlowLayoutPanel panel = new FlowLayoutPanel();
                Button button = new Button();
                Label label = new Label();

                panel.AutoSize = true;
                panel.FlowDirection = FlowDirection.TopDown;

                string folderName = Path.GetFileName(folderPath);

                if (DBManager.GetExeByFolder(folderName) != null)
                {
                    if(DBManager.GetImageByFolder(folderName) != null)
                    {
                        button.BackgroundImage = DBManager.GetImageByFolder(folderName);
                    }
                    else
                    {
                        string filePath = Path.Combine(folderPath, DBManager.GetExeByFolder(folderName));
                    
                        Icon appIcon = Icon.ExtractAssociatedIcon(filePath);
                        button.BackgroundImage = appIcon.ToBitmap();
                    }

                    button.ContextMenuStrip = createContextMenuStrip(folderPath, button);
                }
                else
                {
                    button.BackgroundImage = Properties.Resources.question_mark;
                }


                button.BackgroundImageLayout = ImageLayout.Zoom;

                if(useVerticalIcon == true)
                {
                    button.Size = new Size(80, 120);
                }
                else
                {
                    button.Size = new Size(95, 95);
                }

                button.Click += (sender, e) =>
                {
                    if (DBManager.GetExeByFolder(folderName) != null)
                    {
                        launchGame(folderPath);
                    }
                    else
                    {
                        ChangeGameDirectory(folderPath, button);
                    }
                };

                label.Text = folderName;
                label.AutoSize = false;
                label.Size = new Size(85, 100);

                panel.Controls.Add(button);
                panel.Controls.Add(label);
                flowLayoutPanel1.Controls.Add(panel);

                toolTip1.SetToolTip(button, folderName);
            }
        }

        private async void launchGame(string folderPath)
        {
            string folderName = Path.GetFileName(folderPath);
            string filePath = Path.Combine(folderPath, DBManager.GetExeByFolder(folderName));
            Label selectedLabel = FindLabelByText(folderName, flowLayoutPanel1);

            if (!File.Exists(filePath))
            {
                MessageBox.Show("Unable to find file " + filePath);
                return;
            }


            Process game = Process.Start(filePath);

            if (selectedLabel != null)
            {
                selectedLabel.ForeColor = Color.Green;
                game.EnableRaisingEvents = true;
                TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();

                EventHandler exitedHandler = (sender, e) =>
                {
                    tcs.TrySetResult(true);
                    selectedLabel.Invoke(new Action(() => selectedLabel.ForeColor = Color.Black));
                };

                game.Exited += exitedHandler;
                await tcs.Task;
            }
        }

        private void ChangeGameDirectory(string folderPath, Button button)
        {
            openGameFileDialog.InitialDirectory = folderPath;

            if (openGameFileDialog.ShowDialog() == DialogResult.OK)
            {
                DBManager.SetByFolder(Path.GetFileName(folderPath), Path.GetFileName(openGameFileDialog.FileName));

                Icon appIcon = Icon.ExtractAssociatedIcon(openGameFileDialog.FileName);
                button.BackgroundImage = appIcon.ToBitmap();

                button.ContextMenuStrip = createContextMenuStrip(folderPath, button);
            }
        }

        private ContextMenuStrip createContextMenuStrip(string folderPath, Button button)
        {
            // Create a contextMenuStrip

            ContextMenuStrip menuStrip = new ContextMenuStrip();

            ToolStripMenuItem playToolStripMenuItem = new ToolStripMenuItem();
            ToolStripMenuItem editToolStripMenuItem = new ToolStripMenuItem();

            playToolStripMenuItem.Text = "Play";
            editToolStripMenuItem.Text = "Edit";

            playToolStripMenuItem.Image = Properties.Resources.play;
            editToolStripMenuItem.Image = Properties.Resources.pencil;

            playToolStripMenuItem.Click += (sender, e) =>
            {
                launchGame(folderPath);
            };

            editToolStripMenuItem.Click += (sender, e) =>
            {
                GameProperty gameProperty = new GameProperty(folderPath, this);
                gameProperty.Show();
            };

            menuStrip.Items.Add(playToolStripMenuItem);
            menuStrip.Items.Add(editToolStripMenuItem);

            return menuStrip;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            LoadGame();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                gameDirectory.Text = folderBrowserDialog1.SelectedPath;

                RegistryKey tmpKey = Registry.CurrentUser.OpenSubKey(_registryKeyPath, true);

                if (gameDirectory.Text == "No folder containing the games was specified")
                {
                    tmpKey.SetValue("GameFolderPath", "");
                }
                else
                {
                    tmpKey.SetValue("GameFolderPath", gameDirectory.Text);
                }

                LoadGame();
            }
        }

        private void copyGameFolderPathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(gameDirectory.Text);
        }

        private void pastGameFolderPathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gameDirectory.Text = Clipboard.GetText();
        }

        public Label FindLabelByText(string text, Control parentControl)
        {
            foreach (Control control in parentControl.Controls)
            {
                if (control is Label && ((Label)control).Text == text)
                {
                    return (Label)control;
                }
                else if (control.HasChildren)
                {
                    Label label = FindLabelByText(text, control);
                    if (label != null)
                    {
                        return label;
                    }
                }
            }
            return null;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.D)
            {
                if (debugWindow.IsDisposed)
                {
                    debugWindow = new DebugWindow();
                    debugWindow.Show();
                }
                else
                {
                    debugWindow.Dispose();
                }
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (settingsWindow == null || settingsWindow.IsDisposed)
            {
                settingsWindow = new SettingsWindow(this);
                settingsWindow.Show();
            }
            else
            {
                settingsWindow.Dispose();
            }
        }
    }
}
