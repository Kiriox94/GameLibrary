using craftersmine.SteamGridDBNet;
using craftersmine.SteamGridDBNet.Exceptions;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLibrary
{
    public partial class SettingsWindow : Form
    {
        Form1 mainInstance;
        public SettingsWindow(Form1 instance)
        {
            InitializeComponent();
            mainInstance = instance;

            iconDisplayCheckBox.Checked = Form1.useVerticalIcon;
            apiKeyTextBox.Text = Form1.sgdbApiKey;
        }
        
        void Apply()
        {
            RegistryKey tmpKey = Registry.CurrentUser.OpenSubKey(Form1._registryKeyPath, true);

            tmpKey.SetValue("UseVerticalIcon", iconDisplayCheckBox.Checked);
            Form1.useVerticalIcon = iconDisplayCheckBox.Checked;

            tmpKey.SetValue("SgdbApiKey", apiKeyTextBox.Text);
            Form1.sgdbApiKey = apiKeyTextBox.Text;

            mainInstance.LoadGame();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Apply();
            this.Dispose();
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            Apply();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void apiKeyLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.steamgriddb.com/profile/preferences/api");
        }
    }
}
