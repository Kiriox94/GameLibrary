namespace GameLibrary
{
    partial class DebugWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DebugWindow));
            this.dataTabPage = new System.Windows.Forms.TabPage();
            this.exeTabPage = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.compilerPathFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.compilerPathLabel = new System.Windows.Forms.Label();
            this.compilerPathTextBox = new System.Windows.Forms.TextBox();
            this.compilerPathButton = new System.Windows.Forms.Button();
            this.compilerPathWarnLabel = new System.Windows.Forms.Label();
            this.destinationFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.destinationLabel = new System.Windows.Forms.Label();
            this.destinationTextBox = new System.Windows.Forms.TextBox();
            this.destinationButton = new System.Windows.Forms.Button();
            this.fileNameFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.iconFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.iconLabel = new System.Windows.Forms.Label();
            this.iconTextBox = new System.Windows.Forms.TextBox();
            this.iconButton = new System.Windows.Forms.Button();
            this.iconPictureBox = new System.Windows.Forms.PictureBox();
            this.executableTextFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.executableTextLabel = new System.Windows.Forms.Label();
            this.executableTextTextBox = new System.Windows.Forms.TextBox();
            this.compileButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.iconOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.exeTabPage.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.compilerPathFlowLayoutPanel.SuspendLayout();
            this.destinationFlowLayoutPanel.SuspendLayout();
            this.fileNameFlowLayoutPanel.SuspendLayout();
            this.iconFlowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).BeginInit();
            this.executableTextFlowLayoutPanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataTabPage
            // 
            this.dataTabPage.Location = new System.Drawing.Point(4, 22);
            this.dataTabPage.Name = "dataTabPage";
            this.dataTabPage.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.dataTabPage.Size = new System.Drawing.Size(534, 407);
            this.dataTabPage.TabIndex = 1;
            this.dataTabPage.Text = "Data storage";
            this.dataTabPage.UseVisualStyleBackColor = true;
            // 
            // exeTabPage
            // 
            this.exeTabPage.Controls.Add(this.flowLayoutPanel1);
            this.exeTabPage.Location = new System.Drawing.Point(4, 22);
            this.exeTabPage.Name = "exeTabPage";
            this.exeTabPage.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.exeTabPage.Size = new System.Drawing.Size(534, 407);
            this.exeTabPage.TabIndex = 0;
            this.exeTabPage.Text = "Executable compiler";
            this.exeTabPage.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.compilerPathFlowLayoutPanel);
            this.flowLayoutPanel1.Controls.Add(this.destinationFlowLayoutPanel);
            this.flowLayoutPanel1.Controls.Add(this.fileNameFlowLayoutPanel);
            this.flowLayoutPanel1.Controls.Add(this.iconFlowLayoutPanel);
            this.flowLayoutPanel1.Controls.Add(this.executableTextFlowLayoutPanel);
            this.flowLayoutPanel1.Controls.Add(this.compileButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(528, 401);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // compilerPathFlowLayoutPanel
            // 
            this.compilerPathFlowLayoutPanel.Controls.Add(this.compilerPathLabel);
            this.compilerPathFlowLayoutPanel.Controls.Add(this.compilerPathTextBox);
            this.compilerPathFlowLayoutPanel.Controls.Add(this.compilerPathButton);
            this.compilerPathFlowLayoutPanel.Controls.Add(this.compilerPathWarnLabel);
            this.compilerPathFlowLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.compilerPathFlowLayoutPanel.Name = "compilerPathFlowLayoutPanel";
            this.compilerPathFlowLayoutPanel.Size = new System.Drawing.Size(495, 51);
            this.compilerPathFlowLayoutPanel.TabIndex = 6;
            // 
            // compilerPathLabel
            // 
            this.compilerPathLabel.AutoSize = true;
            this.compilerPathLabel.Location = new System.Drawing.Point(3, 10);
            this.compilerPathLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.compilerPathLabel.Name = "compilerPathLabel";
            this.compilerPathLabel.Size = new System.Drawing.Size(71, 13);
            this.compilerPathLabel.TabIndex = 1;
            this.compilerPathLabel.Text = "Compiler path";
            this.compilerPathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // compilerPathTextBox
            // 
            this.compilerPathTextBox.Location = new System.Drawing.Point(80, 7);
            this.compilerPathTextBox.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.compilerPathTextBox.Name = "compilerPathTextBox";
            this.compilerPathTextBox.Size = new System.Drawing.Size(331, 20);
            this.compilerPathTextBox.TabIndex = 0;
            this.compilerPathTextBox.Text = "C:\\Windows\\Microsoft.NET\\Framework64\\v4.0.30319\\csc.exe";
            // 
            // compilerPathButton
            // 
            this.compilerPathButton.Location = new System.Drawing.Point(417, 6);
            this.compilerPathButton.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.compilerPathButton.Name = "compilerPathButton";
            this.compilerPathButton.Size = new System.Drawing.Size(75, 23);
            this.compilerPathButton.TabIndex = 5;
            this.compilerPathButton.Text = "Open";
            this.compilerPathButton.UseVisualStyleBackColor = true;
            this.compilerPathButton.Click += new System.EventHandler(this.compilerPathButton_Click);
            // 
            // compilerPathWarnLabel
            // 
            this.compilerPathWarnLabel.AutoSize = true;
            this.compilerPathWarnLabel.Location = new System.Drawing.Point(3, 32);
            this.compilerPathWarnLabel.Name = "compilerPathWarnLabel";
            this.compilerPathWarnLabel.Size = new System.Drawing.Size(287, 13);
            this.compilerPathWarnLabel.TabIndex = 6;
            this.compilerPathWarnLabel.Text = "Don\'t modify the \"Compiler path\" if you don\'t know what it is";
            // 
            // destinationFlowLayoutPanel
            // 
            this.destinationFlowLayoutPanel.Controls.Add(this.destinationLabel);
            this.destinationFlowLayoutPanel.Controls.Add(this.destinationTextBox);
            this.destinationFlowLayoutPanel.Controls.Add(this.destinationButton);
            this.destinationFlowLayoutPanel.Location = new System.Drawing.Point(3, 60);
            this.destinationFlowLayoutPanel.Name = "destinationFlowLayoutPanel";
            this.destinationFlowLayoutPanel.Size = new System.Drawing.Size(515, 36);
            this.destinationFlowLayoutPanel.TabIndex = 7;
            // 
            // destinationLabel
            // 
            this.destinationLabel.AutoSize = true;
            this.destinationLabel.Location = new System.Drawing.Point(3, 10);
            this.destinationLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.destinationLabel.Name = "destinationLabel";
            this.destinationLabel.Size = new System.Drawing.Size(89, 13);
            this.destinationLabel.TabIndex = 1;
            this.destinationLabel.Text = "Destination folder";
            this.destinationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // destinationTextBox
            // 
            this.destinationTextBox.Location = new System.Drawing.Point(98, 7);
            this.destinationTextBox.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.destinationTextBox.Name = "destinationTextBox";
            this.destinationTextBox.Size = new System.Drawing.Size(331, 20);
            this.destinationTextBox.TabIndex = 0;
            this.destinationTextBox.Text = "Desktop";
            // 
            // destinationButton
            // 
            this.destinationButton.Location = new System.Drawing.Point(435, 6);
            this.destinationButton.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.destinationButton.Name = "destinationButton";
            this.destinationButton.Size = new System.Drawing.Size(75, 23);
            this.destinationButton.TabIndex = 5;
            this.destinationButton.Text = "Open";
            this.destinationButton.UseVisualStyleBackColor = true;
            this.destinationButton.Click += new System.EventHandler(this.destinationButton_Click);
            // 
            // fileNameFlowLayoutPanel
            // 
            this.fileNameFlowLayoutPanel.Controls.Add(this.fileNameLabel);
            this.fileNameFlowLayoutPanel.Controls.Add(this.fileNameTextBox);
            this.fileNameFlowLayoutPanel.Location = new System.Drawing.Point(3, 102);
            this.fileNameFlowLayoutPanel.Name = "fileNameFlowLayoutPanel";
            this.fileNameFlowLayoutPanel.Size = new System.Drawing.Size(515, 36);
            this.fileNameFlowLayoutPanel.TabIndex = 8;
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Location = new System.Drawing.Point(3, 10);
            this.fileNameLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(53, 13);
            this.fileNameLabel.TabIndex = 1;
            this.fileNameLabel.Text = "FIle name";
            this.fileNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.Location = new System.Drawing.Point(62, 7);
            this.fileNameTextBox.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(298, 20);
            this.fileNameTextBox.TabIndex = 0;
            this.fileNameTextBox.Text = "amazingFile.exe";
            // 
            // iconFlowLayoutPanel
            // 
            this.iconFlowLayoutPanel.Controls.Add(this.iconLabel);
            this.iconFlowLayoutPanel.Controls.Add(this.iconTextBox);
            this.iconFlowLayoutPanel.Controls.Add(this.iconButton);
            this.iconFlowLayoutPanel.Controls.Add(this.iconPictureBox);
            this.iconFlowLayoutPanel.Location = new System.Drawing.Point(3, 144);
            this.iconFlowLayoutPanel.Name = "iconFlowLayoutPanel";
            this.iconFlowLayoutPanel.Size = new System.Drawing.Size(515, 153);
            this.iconFlowLayoutPanel.TabIndex = 9;
            // 
            // iconLabel
            // 
            this.iconLabel.AutoSize = true;
            this.iconLabel.Location = new System.Drawing.Point(3, 10);
            this.iconLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.iconLabel.Name = "iconLabel";
            this.iconLabel.Size = new System.Drawing.Size(46, 13);
            this.iconLabel.TabIndex = 1;
            this.iconLabel.Text = "File icon";
            this.iconLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconTextBox
            // 
            this.iconTextBox.Location = new System.Drawing.Point(55, 7);
            this.iconTextBox.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.iconTextBox.Name = "iconTextBox";
            this.iconTextBox.Size = new System.Drawing.Size(331, 20);
            this.iconTextBox.TabIndex = 0;
            // 
            // iconButton
            // 
            this.iconButton.Location = new System.Drawing.Point(392, 6);
            this.iconButton.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.iconButton.Name = "iconButton";
            this.iconButton.Size = new System.Drawing.Size(75, 23);
            this.iconButton.TabIndex = 5;
            this.iconButton.Text = "Open";
            this.iconButton.UseVisualStyleBackColor = true;
            this.iconButton.Click += new System.EventHandler(this.iconButton_Click);
            // 
            // iconPictureBox
            // 
            this.iconPictureBox.Image = global::GameLibrary.Properties.Resources.question_mark;
            this.iconPictureBox.Location = new System.Drawing.Point(10, 35);
            this.iconPictureBox.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.iconPictureBox.Name = "iconPictureBox";
            this.iconPictureBox.Size = new System.Drawing.Size(120, 111);
            this.iconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox.TabIndex = 6;
            this.iconPictureBox.TabStop = false;
            // 
            // executableTextFlowLayoutPanel
            // 
            this.executableTextFlowLayoutPanel.Controls.Add(this.executableTextLabel);
            this.executableTextFlowLayoutPanel.Controls.Add(this.executableTextTextBox);
            this.executableTextFlowLayoutPanel.Location = new System.Drawing.Point(3, 303);
            this.executableTextFlowLayoutPanel.Name = "executableTextFlowLayoutPanel";
            this.executableTextFlowLayoutPanel.Size = new System.Drawing.Size(515, 36);
            this.executableTextFlowLayoutPanel.TabIndex = 11;
            // 
            // executableTextLabel
            // 
            this.executableTextLabel.AutoSize = true;
            this.executableTextLabel.Location = new System.Drawing.Point(3, 10);
            this.executableTextLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.executableTextLabel.Name = "executableTextLabel";
            this.executableTextLabel.Size = new System.Drawing.Size(96, 13);
            this.executableTextLabel.TabIndex = 1;
            this.executableTextLabel.Text = "Executable file text";
            this.executableTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // executableTextTextBox
            // 
            this.executableTextTextBox.Location = new System.Drawing.Point(105, 7);
            this.executableTextTextBox.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.executableTextTextBox.Name = "executableTextTextBox";
            this.executableTextTextBox.Size = new System.Drawing.Size(298, 20);
            this.executableTextTextBox.TabIndex = 0;
            this.executableTextTextBox.Text = "Hello World!";
            // 
            // compileButton
            // 
            this.compileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.compileButton.Location = new System.Drawing.Point(6, 372);
            this.compileButton.Margin = new System.Windows.Forms.Padding(6, 30, 3, 3);
            this.compileButton.Name = "compileButton";
            this.compileButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.compileButton.Size = new System.Drawing.Size(75, 23);
            this.compileButton.TabIndex = 10;
            this.compileButton.Text = "Compile";
            this.compileButton.UseVisualStyleBackColor = true;
            this.compileButton.Click += new System.EventHandler(this.compileButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.exeTabPage);
            this.tabControl1.Controls.Add(this.dataTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(542, 433);
            this.tabControl1.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Compiler file|*.exe";
            // 
            // iconOpenFileDialog
            // 
            this.iconOpenFileDialog.Filter = "Icon file|*.ico";
            // 
            // DebugWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 433);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DebugWindow";
            this.Text = "Debug";
            this.exeTabPage.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.compilerPathFlowLayoutPanel.ResumeLayout(false);
            this.compilerPathFlowLayoutPanel.PerformLayout();
            this.destinationFlowLayoutPanel.ResumeLayout(false);
            this.destinationFlowLayoutPanel.PerformLayout();
            this.fileNameFlowLayoutPanel.ResumeLayout(false);
            this.fileNameFlowLayoutPanel.PerformLayout();
            this.iconFlowLayoutPanel.ResumeLayout(false);
            this.iconFlowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).EndInit();
            this.executableTextFlowLayoutPanel.ResumeLayout(false);
            this.executableTextFlowLayoutPanel.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage dataTabPage;
        private System.Windows.Forms.TabPage exeTabPage;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TextBox compilerPathTextBox;
        private System.Windows.Forms.Label compilerPathLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel compilerPathFlowLayoutPanel;
        private System.Windows.Forms.Button compilerPathButton;
        private System.Windows.Forms.FlowLayoutPanel destinationFlowLayoutPanel;
        private System.Windows.Forms.Label destinationLabel;
        private System.Windows.Forms.TextBox destinationTextBox;
        private System.Windows.Forms.Button destinationButton;
        private System.Windows.Forms.FlowLayoutPanel fileNameFlowLayoutPanel;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.TextBox fileNameTextBox;
        private System.Windows.Forms.FlowLayoutPanel iconFlowLayoutPanel;
        private System.Windows.Forms.Label iconLabel;
        private System.Windows.Forms.TextBox iconTextBox;
        private System.Windows.Forms.Button iconButton;
        private System.Windows.Forms.PictureBox iconPictureBox;
        private System.Windows.Forms.Label compilerPathWarnLabel;
        private System.Windows.Forms.FlowLayoutPanel executableTextFlowLayoutPanel;
        private System.Windows.Forms.Label executableTextLabel;
        private System.Windows.Forms.TextBox executableTextTextBox;
        private System.Windows.Forms.Button compileButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog iconOpenFileDialog;
    }
}