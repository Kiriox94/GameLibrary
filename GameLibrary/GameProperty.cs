using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using craftersmine.SteamGridDBNet;
using System.Drawing.Imaging;

namespace GameLibrary
{
    public partial class GameProperty : Form
    {
        string gameName;
        string _folderPath;
        Form1 mainInstance;
        bool iconIsChanged = false;

        int gridsCount = 0;
        int gridsDownloadedCount = 0;
        ProgressBar gridProgressBar = new ProgressBar();
        Label gridProgressLabel = new Label();

        int iconsCount = 0;
        int iconsDownloadedCount = 0;
        ProgressBar iconProgressBar = new ProgressBar();
        Label iconProgressLabel = new Label();

        SteamGridDb sgdb;

        public GameProperty(string folderPath, Form1 instance)
        {
            InitializeComponent();
            
            gameName = Path.GetFileName(folderPath);
            _folderPath = folderPath;
            mainInstance = instance;

            gameTitleLabel.Text = gameName;
            executableTextBox.Text = DBManager.GetExeByFolder(gameName);
            searchTextBox.Text = gameName;

            this.Text = gameName + " property";

            if(DBManager.GetImageByFolder(gameName) != null)
            {
                gameIconPictureBox.Image = DBManager.GetImageByFolder(gameName);
            }
            else
            {
                if(DBManager.GetExeByFolder(gameName) != null)
                {
                    string filePath = Path.Combine(folderPath, DBManager.GetExeByFolder(gameName));

                    Icon appIcon = Icon.ExtractAssociatedIcon(filePath);
                    gameIconPictureBox.Image = appIcon.ToBitmap();
                }
            }

            LoadGames();
        }

        async void LoadGames()
        {
            if (string.IsNullOrEmpty(Form1.sgdbApiKey) || string.IsNullOrWhiteSpace(Form1.sgdbApiKey))
            {
                sgdb = new SteamGridDb("a");
            }
            else
            {
                sgdb = new SteamGridDb(Form1.sgdbApiKey);
            }

            steamGridDBPanel.Controls.Clear();

            FlowLayoutPanel flowLayout = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                BorderStyle = BorderStyle.FixedSingle,
                AutoScroll = true,
            };

            steamGridDBPanel.Controls.Add(flowLayout);

            if (string.IsNullOrEmpty(Form1.sgdbApiKey))
            {
                Label warningLabel = new Label
                {
                    Text = "No api key specified, to add one, go to the application settings (Right click on the main menu), enter your api key then press reload",
                    AutoSize = true,
                };

                Button reloadButton = new Button();

                reloadButton.Text = "Reload";

                reloadButton.Click += (sender, e) =>
                {
                    LoadGames();
                };

                flowLayout.Controls.Add(warningLabel);
                flowLayout.Controls.Add(reloadButton);
                return;
            }

            try
            {
                SteamGridDbGame[] games = await sgdb.SearchForGamesAsync(searchTextBox.Text);

                if (games.Length == 0)
                {
                    Label warningLabel = new Label
                    {
                        Text = "No games found for this search",
                        AutoSize = true,
                    };

                    flowLayout.Controls.Add(warningLabel);
                }

                foreach (SteamGridDbGame game in games)
                {
                    Button button = new Button
                    {
                        Text = game.Name,
                        Width = steamGridDBPanel.Width - 30,

                    };

                    button.Click += (sender, e) =>
                    {
                        LoadImages(game.Id);
                    };

                    flowLayout.Controls.Add(button);
                }
            }
            catch
            {
                Label warningLabel = new Label
                {
                    Text = "Your api key is invalid",
                    AutoSize = true,
                };

                flowLayout.Controls.Add(warningLabel);
            }
        }

        async void LoadImages(int gameId)
        {
            steamGridDBPanel.Controls.Clear();

            TabControl tabControl = new TabControl();
            TabPage gridTabPage = new TabPage();
            TabPage iconTabPage = new TabPage();

            FlowLayoutPanel gridFlowLayout = new FlowLayoutPanel();
            FlowLayoutPanel iconFlowLayout = new FlowLayoutPanel();

            FlowLayoutPanel gridImageFlowLayout = new FlowLayoutPanel();
            FlowLayoutPanel iconImageFlowLayout = new FlowLayoutPanel();

            tabControl.Dock = DockStyle.Fill;
            gridFlowLayout.Dock = DockStyle.Fill;
            iconFlowLayout.Dock = DockStyle.Fill;

            gridImageFlowLayout.BorderStyle = BorderStyle.FixedSingle;
            iconImageFlowLayout.BorderStyle = BorderStyle.FixedSingle;

            gridImageFlowLayout.AutoScroll = true;
            iconImageFlowLayout.AutoScroll = true;

            gridImageFlowLayout.Size = new Size(325, 190);
            iconImageFlowLayout.Size = new Size(340, 190);

            gridTabPage.Text = "Grids";
            iconTabPage.Text = "Icons";

            gridFlowLayout.Controls.Add(gridImageFlowLayout);
            iconFlowLayout.Controls.Add(iconImageFlowLayout);

            gridTabPage.Controls.Add(gridFlowLayout);

            iconTabPage.Controls.Add(iconFlowLayout);

            tabControl.Controls.Add(gridTabPage);
            tabControl.Controls.Add(iconTabPage);

            steamGridDBPanel.Controls.Add(tabControl);

            SteamGridDbGrid[] grids = await sgdb.GetGridsByGameIdAsync(gameId, dimensions: SteamGridDbDimensions.W600H900, formats: SteamGridDbFormats.Jpeg | SteamGridDbFormats.Png);
            SteamGridDbIcon[] icons = await sgdb.GetIconsByGameIdAsync(gameId);

            gridsCount = grids.Length;
            gridsDownloadedCount = 0;
            gridProgressBar.Value = 0;

            iconsCount = icons.Length;
            iconsDownloadedCount = 0;
            iconProgressBar.Value = 0;

            gridProgressBar.Maximum = gridsCount*10;
            gridProgressLabel.Text = "0/" + gridsCount;

            iconProgressBar.Maximum = iconsCount * 10;
            iconProgressLabel.Text = "0/" + iconsCount;

            gridProgressLabel.Margin = new Padding(8);
            iconProgressLabel.Margin = new Padding(8);

            gridFlowLayout.Controls.Add(gridProgressBar);
            gridFlowLayout.Controls.Add(gridProgressLabel);

            iconFlowLayout.Controls.Add(iconProgressBar);
            iconFlowLayout.Controls.Add(iconProgressLabel);

            if (grids.Length == 0)
            {
                Label warningGridLabel = new Label
                {
                    Text = "No grids found for this game",
                    AutoSize = true,
                };

                gridImageFlowLayout.Controls.Add(warningGridLabel);
            }

            if (icons.Length == 0)
            {
                Label warningIconLabel = new Label
                {
                    Text = "No icons found for this game",
                    AutoSize = true,
                };

                iconImageFlowLayout.Controls.Add(warningIconLabel);
            }

            foreach (SteamGridDbGrid grid in grids)
            {
                DisplayGrid(grid, gridImageFlowLayout);
            }

            foreach (SteamGridDbIcon icon in icons)
            {
                DisplayIcon(icon, iconImageFlowLayout);
            }
        }

        public async void DisplayGrid(SteamGridDbGrid grid, FlowLayoutPanel parent)
        {
            Button button = new Button
            {
                Width = 70,
                Height = 105,
                BackgroundImage = Image.FromStream(await grid.GetImageAsStreamAsync(false)),
                BackgroundImageLayout = ImageLayout.Zoom,
            };

            button.Click += (sender, e) =>
            {
                gameIconPictureBox.Image = button.BackgroundImage;
                iconIsChanged = true;
            };

            gridsDownloadedCount++;
            gridProgressBar.PerformStep();
            gridProgressLabel.Text = string.Format("{0}/{1}", gridsDownloadedCount, gridsCount);

            parent.Controls.Add(button);
        }

        public async void DisplayIcon(SteamGridDbIcon icon, FlowLayoutPanel parent)
        {
            Button button = new Button
            {
                Width = 100,
                Height = 100,
                BackgroundImage = Image.FromStream(await icon.GetImageAsStreamAsync(false)),
                BackgroundImageLayout = ImageLayout.Zoom,
            };

            button.Click += (sender, e) =>
            {
                gameIconPictureBox.Image = button.BackgroundImage;
                iconIsChanged = true;
            };

            iconsDownloadedCount++;
            iconProgressBar.PerformStep();
            iconProgressLabel.Text = string.Format("{0}/{1}", iconsDownloadedCount, iconsCount);

            parent.Controls.Add(button);
        }

        void applyChange()
        {
            MemoryStream ms = new MemoryStream();
            gameIconPictureBox.Image.Save(ms, ImageFormat.Png);

            byte[] buff = ms.GetBuffer();

            if (iconIsChanged)
            {
                DBManager.SetByFolder(gameName, executableTextBox.Text, buff);
            }
            else
            {
                DBManager.SetByFolder(gameName, executableTextBox.Text);
            }

            iconIsChanged = false;
            ms.Dispose();
            mainInstance.LoadGame();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            LoadGames();
        }

        private void changeIconButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image files|*.jpg;*.jpeg;*.png";
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                gameIconPictureBox.Load(openFileDialog1.FileName);
                iconIsChanged = true;
            }
        }

        private void resetIconButton_Click(object sender, EventArgs e)
        {
            DBManager.ResetImage(gameName);
            string filePath = Path.Combine(_folderPath, DBManager.GetExeByFolder(gameName));

            Icon appIcon = Icon.ExtractAssociatedIcon(filePath);
            gameIconPictureBox.Image = appIcon.ToBitmap();

            iconIsChanged = false;
        }

        private void searchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {    
                LoadGames();
            }
        }

        private void executableButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Game file|*.exe";
            openFileDialog1.InitialDirectory = _folderPath;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                executableTextBox.Text = Path.GetFileName(openFileDialog1.FileName);
            }
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            applyChange();
        }

        private void okButton_Click(object sender, EventArgs e)
        { 
            applyChange();
            this.Dispose();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}