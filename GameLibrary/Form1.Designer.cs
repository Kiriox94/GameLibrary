
namespace GameLibrary
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openGameFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pathContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyGameFolderPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pastGameFolderPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.gameDirectory = new System.Windows.Forms.TextBox();
            this.openButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.pathContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // openGameFileDialog
            // 
            this.openGameFileDialog.Filter = "Game file| *.exe";
            this.openGameFileDialog.Title = "Select your game file";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.22222F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.777778F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.ContextMenuStrip = this.contextMenuStrip1;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(794, 409);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Image = global::GameLibrary.Properties.Resources.settings;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.settingsToolStripMenuItem.Text = "Settings...";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.ContextMenuStrip = this.pathContextMenuStrip;
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.gameDirectory);
            this.flowLayoutPanel2.Controls.Add(this.openButton);
            this.flowLayoutPanel2.Controls.Add(this.updateButton);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 418);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(794, 29);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // pathContextMenuStrip
            // 
            this.pathContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyGameFolderPathToolStripMenuItem,
            this.pastGameFolderPathToolStripMenuItem});
            this.pathContextMenuStrip.Name = "pathContextMenuStrip";
            this.pathContextMenuStrip.Size = new System.Drawing.Size(197, 48);
            // 
            // copyGameFolderPathToolStripMenuItem
            // 
            this.copyGameFolderPathToolStripMenuItem.Name = "copyGameFolderPathToolStripMenuItem";
            this.copyGameFolderPathToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.copyGameFolderPathToolStripMenuItem.Text = "Copy game folder path";
            this.copyGameFolderPathToolStripMenuItem.Click += new System.EventHandler(this.copyGameFolderPathToolStripMenuItem_Click);
            // 
            // pastGameFolderPathToolStripMenuItem
            // 
            this.pastGameFolderPathToolStripMenuItem.Name = "pastGameFolderPathToolStripMenuItem";
            this.pastGameFolderPathToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.pastGameFolderPathToolStripMenuItem.Text = "Past game folder path";
            this.pastGameFolderPathToolStripMenuItem.Click += new System.EventHandler(this.pastGameFolderPathToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label1.Size = new System.Drawing.Size(91, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Game folder path:";
            // 
            // gameDirectory
            // 
            this.gameDirectory.ContextMenuStrip = this.pathContextMenuStrip;
            this.gameDirectory.Location = new System.Drawing.Point(100, 6);
            this.gameDirectory.Name = "gameDirectory";
            this.gameDirectory.ReadOnly = true;
            this.gameDirectory.Size = new System.Drawing.Size(480, 20);
            this.gameDirectory.TabIndex = 3;
            this.gameDirectory.Text = "No folder containing the games was specified";
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(586, 3);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(75, 23);
            this.openButton.TabIndex = 4;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(667, 3);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 5;
            this.updateButton.Text = "Reload";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Library";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.pathContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openGameFileDialog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TextBox gameDirectory;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip pathContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem copyGameFolderPathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pastGameFolderPathToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
    }
}

