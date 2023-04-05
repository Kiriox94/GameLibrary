
namespace GameLibrary
{
    partial class GameProperty
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameProperty));
            this.gameIconPictureBox = new System.Windows.Forms.PictureBox();
            this.gameTitleLabel = new System.Windows.Forms.Label();
            this.changeIconButton = new System.Windows.Forms.Button();
            this.executableLabel = new System.Windows.Forms.Label();
            this.executableTextBox = new System.Windows.Forms.TextBox();
            this.executableButton = new System.Windows.Forms.Button();
            this.executablePanel = new System.Windows.Forms.Panel();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.steamGridDBPanel = new System.Windows.Forms.Panel();
            this.applyButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.resetIconButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gameIconPictureBox)).BeginInit();
            this.executablePanel.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameIconPictureBox
            // 
            this.gameIconPictureBox.Image = global::GameLibrary.Properties.Resources.question_mark;
            this.gameIconPictureBox.Location = new System.Drawing.Point(14, 14);
            this.gameIconPictureBox.Margin = new System.Windows.Forms.Padding(30, 30, 3, 3);
            this.gameIconPictureBox.Name = "gameIconPictureBox";
            this.gameIconPictureBox.Size = new System.Drawing.Size(90, 135);
            this.gameIconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gameIconPictureBox.TabIndex = 0;
            this.gameIconPictureBox.TabStop = false;
            // 
            // gameTitleLabel
            // 
            this.gameTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameTitleLabel.Location = new System.Drawing.Point(122, 14);
            this.gameTitleLabel.Margin = new System.Windows.Forms.Padding(15, 130, 3, 0);
            this.gameTitleLabel.Name = "gameTitleLabel";
            this.gameTitleLabel.Size = new System.Drawing.Size(215, 64);
            this.gameTitleLabel.TabIndex = 1;
            this.gameTitleLabel.Text = "Game title";
            this.gameTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // changeIconButton
            // 
            this.changeIconButton.Location = new System.Drawing.Point(110, 105);
            this.changeIconButton.Name = "changeIconButton";
            this.changeIconButton.Size = new System.Drawing.Size(114, 34);
            this.changeIconButton.TabIndex = 2;
            this.changeIconButton.Text = "Change game icon";
            this.changeIconButton.UseVisualStyleBackColor = true;
            this.changeIconButton.Click += new System.EventHandler(this.changeIconButton_Click);
            // 
            // executableLabel
            // 
            this.executableLabel.AutoSize = true;
            this.executableLabel.Location = new System.Drawing.Point(3, 8);
            this.executableLabel.Name = "executableLabel";
            this.executableLabel.Size = new System.Drawing.Size(92, 13);
            this.executableLabel.TabIndex = 3;
            this.executableLabel.Text = "Executable name:";
            // 
            // executableTextBox
            // 
            this.executableTextBox.Location = new System.Drawing.Point(95, 5);
            this.executableTextBox.Name = "executableTextBox";
            this.executableTextBox.ReadOnly = true;
            this.executableTextBox.Size = new System.Drawing.Size(173, 20);
            this.executableTextBox.TabIndex = 4;
            this.executableTextBox.Text = "game.exe";
            // 
            // executableButton
            // 
            this.executableButton.Location = new System.Drawing.Point(270, 5);
            this.executableButton.Name = "executableButton";
            this.executableButton.Size = new System.Drawing.Size(67, 23);
            this.executableButton.TabIndex = 5;
            this.executableButton.Text = "open";
            this.executableButton.UseVisualStyleBackColor = true;
            this.executableButton.Click += new System.EventHandler(this.executableButton_Click);
            // 
            // executablePanel
            // 
            this.executablePanel.Controls.Add(this.executableLabel);
            this.executablePanel.Controls.Add(this.executableTextBox);
            this.executablePanel.Controls.Add(this.executableButton);
            this.executablePanel.Location = new System.Drawing.Point(3, 155);
            this.executablePanel.Name = "executablePanel";
            this.executablePanel.Size = new System.Drawing.Size(348, 33);
            this.executablePanel.TabIndex = 6;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.Location = new System.Drawing.Point(3, 0);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(171, 15);
            this.searchLabel.TabIndex = 7;
            this.searchLabel.Text = "Select icon with SteamGridDB";
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.searchButton);
            this.searchPanel.Controls.Add(this.searchTextBox);
            this.searchPanel.Controls.Add(this.searchLabel);
            this.searchPanel.Location = new System.Drawing.Point(9, 205);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(342, 49);
            this.searchPanel.TabIndex = 9;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(253, 24);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 9;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(5, 26);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(242, 20);
            this.searchTextBox.TabIndex = 8;
            this.searchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchTextBox_KeyDown);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Image files|*.jpg;*.jpeg;*.png";
            // 
            // steamGridDBPanel
            // 
            this.steamGridDBPanel.Location = new System.Drawing.Point(9, 260);
            this.steamGridDBPanel.Name = "steamGridDBPanel";
            this.steamGridDBPanel.Size = new System.Drawing.Size(345, 253);
            this.steamGridDBPanel.TabIndex = 10;
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(204, 518);
            this.applyButton.Margin = new System.Windows.Forms.Padding(2);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(67, 22);
            this.applyButton.TabIndex = 11;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(287, 518);
            this.okButton.Margin = new System.Windows.Forms.Padding(2);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(67, 22);
            this.okButton.TabIndex = 14;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(11, 518);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(67, 22);
            this.cancelButton.TabIndex = 15;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // resetIconButton
            // 
            this.resetIconButton.Location = new System.Drawing.Point(236, 105);
            this.resetIconButton.Name = "resetIconButton";
            this.resetIconButton.Size = new System.Drawing.Size(114, 34);
            this.resetIconButton.TabIndex = 16;
            this.resetIconButton.Text = "Reset game icon";
            this.resetIconButton.UseVisualStyleBackColor = true;
            this.resetIconButton.Click += new System.EventHandler(this.resetIconButton_Click);
            // 
            // GameProperty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 551);
            this.Controls.Add(this.resetIconButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.steamGridDBPanel);
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.executablePanel);
            this.Controls.Add(this.gameIconPictureBox);
            this.Controls.Add(this.gameTitleLabel);
            this.Controls.Add(this.changeIconButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GameProperty";
            this.Text = "gameProperty";
            ((System.ComponentModel.ISupportInitialize)(this.gameIconPictureBox)).EndInit();
            this.executablePanel.ResumeLayout(false);
            this.executablePanel.PerformLayout();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox gameIconPictureBox;
        private System.Windows.Forms.Label gameTitleLabel;
        private System.Windows.Forms.Button changeIconButton;
        private System.Windows.Forms.Label executableLabel;
        private System.Windows.Forms.TextBox executableTextBox;
        private System.Windows.Forms.Button executableButton;
        private System.Windows.Forms.Panel executablePanel;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel steamGridDBPanel;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button resetIconButton;
    }
}