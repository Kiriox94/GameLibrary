using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Collections.Specialized;
using System.Diagnostics;

namespace GameLibrary
{
    public partial class Form1 : Form
    {

        private static string _aplicationDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        private static string _aplicationPath = Path.Combine(_aplicationDataPath, "GameLibrary");

        public string FileName = Path.Combine(_aplicationPath, "data.csv");
        NameValueCollection savedData = new NameValueCollection();

        public Form1()
        {
            InitializeComponent();
            InitDataFile();
            LoadGame();
        }

        public void LoadGame()
        {
            //string folder = @"E:\games";
            string folder = gameDirectory.Text;

            string[] folders = Directory.GetDirectories(folder);

            foreach (string folderPath in folders)
            {
                Panel panel = new Panel();
                Button button = new Button();
                Label label = new Label();

                panel.Size = new Size(110, 115);

                string folderName = Path.GetFileName(folderPath);

                if (savedData[folderName] != null)
                {
                    Icon appIcon = Icon.ExtractAssociatedIcon(savedData[folderName]);
                    button.BackgroundImage = appIcon.ToBitmap();
                }
                else
                {
                    button.BackgroundImage = Properties.Resources.question_mark;
                }

                button.BackgroundImageLayout = ImageLayout.Zoom;

                button.Size = new Size(95, 95);

                button.Click += (sender, e) =>
                {
                    GameButton_Click(folderPath, button);
                };

                label.Text = folderName;
                label.Location = new Point(0, 100);

                panel.Controls.Add(button);
                panel.Controls.Add(label);
                flowLayoutPanel1.Controls.Add(panel);
            }
        }

        public void GameButton_Click(string gamePath, Button button)
        {
            if (savedData[Path.GetFileName(gamePath)] != null)
            {
                Process.Start((savedData[Path.GetFileName(gamePath)]));
            }
            else
            {
                openGameFileDialog.InitialDirectory = gamePath;
                if (openGameFileDialog.ShowDialog() == DialogResult.OK)
                {
                    savedData.Add(Path.GetFileName(gamePath), openGameFileDialog.FileName);

                    Icon appIcon = Icon.ExtractAssociatedIcon(openGameFileDialog.FileName);
                    button.BackgroundImage = appIcon.ToBitmap();
                }
            }
        }

        private void InitDataFile()
        {
            if (!Directory.Exists(_aplicationPath))
            {
                Directory.CreateDirectory(_aplicationPath);
            }

            if (File.Exists(FileName))
            {
                StreamReader fileStreamReader = new StreamReader(FileName);
                string line;

                while ((line = fileStreamReader.ReadLine()) != null)
                {
                    string[] splitedLine = line.Split(';');
                    savedData.Add(splitedLine[0], splitedLine[1]);
                }

                fileStreamReader.Close();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            string separator = ";";
            StringBuilder output = new StringBuilder();

            foreach (string key in savedData)
            {
                string[] newLine = { key, savedData[key] };
                output.AppendLine(string.Join(separator, newLine));
            }

            File.WriteAllText(FileName, output.ToString());
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            LoadGame();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                gameDirectory.Text = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}
