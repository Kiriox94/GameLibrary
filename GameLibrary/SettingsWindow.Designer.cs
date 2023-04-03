namespace GameLibrary
{
    partial class SettingsWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsWindow));
            this.applyButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.iconDisplayLabel = new System.Windows.Forms.Label();
            this.iconDisplayCheckBox = new System.Windows.Forms.CheckBox();
            this.apiKeyLabel = new System.Windows.Forms.Label();
            this.apiKeyTextBox = new System.Windows.Forms.TextBox();
            this.iconDisplayPanel = new System.Windows.Forms.Panel();
            this.apiKeyPanel = new System.Windows.Forms.Panel();
            this.apiKeyLinkLabel = new System.Windows.Forms.LinkLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.iconDisplayPanel.SuspendLayout();
            this.apiKeyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.buttonFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(185, 3);
            this.applyButton.Margin = new System.Windows.Forms.Padding(100, 3, 3, 5);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 0;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(273, 3);
            this.okButton.Margin = new System.Windows.Forms.Padding(10, 3, 3, 5);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(7, 3);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(7, 3, 3, 5);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // iconDisplayLabel
            // 
            this.iconDisplayLabel.AutoSize = true;
            this.iconDisplayLabel.Location = new System.Drawing.Point(3, 1);
            this.iconDisplayLabel.Name = "iconDisplayLabel";
            this.iconDisplayLabel.Size = new System.Drawing.Size(115, 13);
            this.iconDisplayLabel.TabIndex = 3;
            this.iconDisplayLabel.Text = "Use vertical game icon";
            // 
            // iconDisplayCheckBox
            // 
            this.iconDisplayCheckBox.AutoSize = true;
            this.iconDisplayCheckBox.Location = new System.Drawing.Point(124, 2);
            this.iconDisplayCheckBox.Name = "iconDisplayCheckBox";
            this.iconDisplayCheckBox.Size = new System.Drawing.Size(15, 14);
            this.iconDisplayCheckBox.TabIndex = 4;
            this.iconDisplayCheckBox.UseVisualStyleBackColor = true;
            // 
            // apiKeyLabel
            // 
            this.apiKeyLabel.AutoSize = true;
            this.apiKeyLabel.Location = new System.Drawing.Point(3, 6);
            this.apiKeyLabel.Name = "apiKeyLabel";
            this.apiKeyLabel.Size = new System.Drawing.Size(108, 13);
            this.apiKeyLabel.TabIndex = 5;
            this.apiKeyLabel.Text = "SteamGridDB api key";
            // 
            // apiKeyTextBox
            // 
            this.apiKeyTextBox.Location = new System.Drawing.Point(114, 3);
            this.apiKeyTextBox.Name = "apiKeyTextBox";
            this.apiKeyTextBox.Size = new System.Drawing.Size(203, 20);
            this.apiKeyTextBox.TabIndex = 6;
            // 
            // iconDisplayPanel
            // 
            this.iconDisplayPanel.Controls.Add(this.iconDisplayLabel);
            this.iconDisplayPanel.Controls.Add(this.iconDisplayCheckBox);
            this.iconDisplayPanel.Location = new System.Drawing.Point(3, 10);
            this.iconDisplayPanel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.iconDisplayPanel.Name = "iconDisplayPanel";
            this.iconDisplayPanel.Size = new System.Drawing.Size(144, 20);
            this.iconDisplayPanel.TabIndex = 7;
            // 
            // apiKeyPanel
            // 
            this.apiKeyPanel.Controls.Add(this.apiKeyLabel);
            this.apiKeyPanel.Controls.Add(this.apiKeyTextBox);
            this.apiKeyPanel.Controls.Add(this.apiKeyLinkLabel);
            this.apiKeyPanel.Location = new System.Drawing.Point(3, 43);
            this.apiKeyPanel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.apiKeyPanel.Name = "apiKeyPanel";
            this.apiKeyPanel.Size = new System.Drawing.Size(350, 95);
            this.apiKeyPanel.TabIndex = 8;
            // 
            // apiKeyLinkLabel
            // 
            this.apiKeyLinkLabel.LinkArea = new System.Windows.Forms.LinkArea(36, 10);
            this.apiKeyLinkLabel.Location = new System.Drawing.Point(14, 26);
            this.apiKeyLinkLabel.Name = "apiKeyLinkLabel";
            this.apiKeyLinkLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.apiKeyLinkLabel.Size = new System.Drawing.Size(303, 61);
            this.apiKeyLinkLabel.TabIndex = 7;
            this.apiKeyLinkLabel.TabStop = true;
            this.apiKeyLinkLabel.Text = resources.GetString("apiKeyLinkLabel.Text");
            this.apiKeyLinkLabel.UseCompatibleTextRendering = true;
            this.apiKeyLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.apiKeyLinkLabel_LinkClicked);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.buttonFlowLayoutPanel);
            this.splitContainer1.Size = new System.Drawing.Size(356, 489);
            this.splitContainer1.SplitterDistance = 454;
            this.splitContainer1.TabIndex = 10;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.iconDisplayPanel);
            this.flowLayoutPanel1.Controls.Add(this.apiKeyPanel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(356, 454);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // buttonFlowLayoutPanel
            // 
            this.buttonFlowLayoutPanel.Controls.Add(this.cancelButton);
            this.buttonFlowLayoutPanel.Controls.Add(this.applyButton);
            this.buttonFlowLayoutPanel.Controls.Add(this.okButton);
            this.buttonFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.buttonFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.buttonFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.buttonFlowLayoutPanel.Name = "buttonFlowLayoutPanel";
            this.buttonFlowLayoutPanel.Size = new System.Drawing.Size(356, 31);
            this.buttonFlowLayoutPanel.TabIndex = 10;
            // 
            // SettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 489);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsWindow";
            this.Text = "Settings";
            this.iconDisplayPanel.ResumeLayout(false);
            this.iconDisplayPanel.PerformLayout();
            this.apiKeyPanel.ResumeLayout(false);
            this.apiKeyPanel.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.buttonFlowLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Label iconDisplayLabel;
        private System.Windows.Forms.CheckBox iconDisplayCheckBox;
        private System.Windows.Forms.Label apiKeyLabel;
        private System.Windows.Forms.TextBox apiKeyTextBox;
        private System.Windows.Forms.Panel iconDisplayPanel;
        private System.Windows.Forms.Panel apiKeyPanel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel buttonFlowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.LinkLabel apiKeyLinkLabel;
    }
}