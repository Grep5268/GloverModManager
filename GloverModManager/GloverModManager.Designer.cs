using System.Windows.Forms;

namespace GloverModManager
{
    partial class GloverModManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GloverModManager));
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.gloverFolderTextBox = new System.Windows.Forms.TextBox();
            this.gloverDirectoryLabel = new System.Windows.Forms.Label();
            this.searchFolderButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EnabledModsLabel = new System.Windows.Forms.Label();
            this.EnabledModsList = new System.Windows.Forms.ListBox();
            this.ModMultiSelect = new System.Windows.Forms.CheckedListBox();
            this.GloverDirectoryErrorMessage = new System.Windows.Forms.Label();
            this.ModListLabel = new System.Windows.Forms.Label();
            this.LoadModsButton = new System.Windows.Forms.Button();
            this.ResetModsButton = new System.Windows.Forms.Button();
            this.ApplyChangesLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gloverFolderTextBox
            // 
            this.gloverFolderTextBox.Location = new System.Drawing.Point(123, 13);
            this.gloverFolderTextBox.Name = "gloverFolderTextBox";
            this.gloverFolderTextBox.Size = new System.Drawing.Size(193, 20);
            this.gloverFolderTextBox.TabIndex = 1;
            // 
            // gloverDirectoryLabel
            // 
            this.gloverDirectoryLabel.AutoSize = true;
            this.gloverDirectoryLabel.Location = new System.Drawing.Point(3, 16);
            this.gloverDirectoryLabel.Name = "gloverDirectoryLabel";
            this.gloverDirectoryLabel.Size = new System.Drawing.Size(114, 13);
            this.gloverDirectoryLabel.TabIndex = 2;
            this.gloverDirectoryLabel.Text = "Glover Game Directory";
            // 
            // searchFolderButton
            // 
            this.searchFolderButton.Location = new System.Drawing.Point(322, 13);
            this.searchFolderButton.Name = "searchFolderButton";
            this.searchFolderButton.Size = new System.Drawing.Size(35, 20);
            this.searchFolderButton.TabIndex = 3;
            this.searchFolderButton.Text = "...";
            this.searchFolderButton.UseVisualStyleBackColor = true;
            this.searchFolderButton.Click += new System.EventHandler(this.SearchFolderButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ApplyChangesLabel);
            this.panel1.Controls.Add(this.ResetModsButton);
            this.panel1.Controls.Add(this.LoadModsButton);
            this.panel1.Controls.Add(this.EnabledModsLabel);
            this.panel1.Controls.Add(this.EnabledModsList);
            this.panel1.Controls.Add(this.ModMultiSelect);
            this.panel1.Controls.Add(this.GloverDirectoryErrorMessage);
            this.panel1.Controls.Add(this.ModListLabel);
            this.panel1.Controls.Add(this.searchFolderButton);
            this.panel1.Controls.Add(this.gloverDirectoryLabel);
            this.panel1.Controls.Add(this.gloverFolderTextBox);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 641);
            this.panel1.TabIndex = 5;
            // 
            // EnabledModsLabel
            // 
            this.EnabledModsLabel.AutoSize = true;
            this.EnabledModsLabel.Location = new System.Drawing.Point(6, 323);
            this.EnabledModsLabel.Name = "EnabledModsLabel";
            this.EnabledModsLabel.Size = new System.Drawing.Size(152, 13);
            this.EnabledModsLabel.TabIndex = 10;
            this.EnabledModsLabel.Text = "Enabled Mods (in priority order)";
            this.EnabledModsLabel.Visible = false;
            // 
            // EnabledModsList
            // 
            this.EnabledModsList.FormattingEnabled = true;
            this.EnabledModsList.Location = new System.Drawing.Point(6, 342);
            this.EnabledModsList.Name = "EnabledModsList";
            this.EnabledModsList.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.EnabledModsList.Size = new System.Drawing.Size(310, 160);
            this.EnabledModsList.TabIndex = 9;
            this.EnabledModsList.Visible = false;
            // 
            // ModMultiSelect
            // 
            this.ModMultiSelect.CheckOnClick = true;
            this.ModMultiSelect.FormattingEnabled = true;
            this.ModMultiSelect.Location = new System.Drawing.Point(6, 89);
            this.ModMultiSelect.Name = "ModMultiSelect";
            this.ModMultiSelect.ScrollAlwaysVisible = true;
            this.ModMultiSelect.Size = new System.Drawing.Size(310, 214);
            this.ModMultiSelect.TabIndex = 8;
            this.ModMultiSelect.Visible = false;
            this.ModMultiSelect.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ModMultiSelect_ItemCheck);
            // 
            // GloverDirectoryErrorMessage
            // 
            this.GloverDirectoryErrorMessage.AutoSize = true;
            this.GloverDirectoryErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.GloverDirectoryErrorMessage.Location = new System.Drawing.Point(3, 42);
            this.GloverDirectoryErrorMessage.Name = "GloverDirectoryErrorMessage";
            this.GloverDirectoryErrorMessage.Size = new System.Drawing.Size(445, 13);
            this.GloverDirectoryErrorMessage.TabIndex = 7;
            this.GloverDirectoryErrorMessage.Text = "Error: Glover.exe was not found in the selected directory, please select a valid " +
    "game directory";
            this.GloverDirectoryErrorMessage.Visible = false;
            // 
            // ModListLabel
            // 
            this.ModListLabel.AutoSize = true;
            this.ModListLabel.Location = new System.Drawing.Point(3, 73);
            this.ModListLabel.Name = "ModListLabel";
            this.ModListLabel.Size = new System.Drawing.Size(47, 13);
            this.ModListLabel.TabIndex = 5;
            this.ModListLabel.Text = "Mod List";
            this.ModListLabel.Visible = false;
            // 
            // LoadModsButton
            // 
            this.LoadModsButton.Location = new System.Drawing.Point(6, 509);
            this.LoadModsButton.Name = "LoadModsButton";
            this.LoadModsButton.Size = new System.Drawing.Size(75, 23);
            this.LoadModsButton.TabIndex = 11;
            this.LoadModsButton.Text = "Load Mods";
            this.LoadModsButton.UseVisualStyleBackColor = true;
            this.LoadModsButton.Visible = false;
            this.LoadModsButton.Click += new System.EventHandler(this.LoadModsButton_Click);
            // 
            // ResetModsButton
            // 
            this.ResetModsButton.Location = new System.Drawing.Point(88, 509);
            this.ResetModsButton.Name = "ResetModsButton";
            this.ResetModsButton.Size = new System.Drawing.Size(110, 23);
            this.ResetModsButton.TabIndex = 12;
            this.ResetModsButton.Text = "Reset All Mods";
            this.ResetModsButton.UseVisualStyleBackColor = true;
            this.ResetModsButton.Visible = false;
            this.ResetModsButton.Click += new System.EventHandler(this.ResetModsButton_Click);
            // 
            // ApplyChangesLabel
            // 
            this.ApplyChangesLabel.AutoSize = true;
            this.ApplyChangesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ApplyChangesLabel.Location = new System.Drawing.Point(9, 539);
            this.ApplyChangesLabel.Name = "ApplyChangesLabel";
            this.ApplyChangesLabel.Size = new System.Drawing.Size(87, 13);
            this.ApplyChangesLabel.TabIndex = 13;
            this.ApplyChangesLabel.Text = "Changes Applied";
            this.ApplyChangesLabel.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(494, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // GloverModManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(494, 680);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GloverModManager";
            this.Text = "Glover Mod Manager";
            this.Load += new System.EventHandler(this.GloverModManagerLoad);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.TextBox gloverFolderTextBox;
        private System.Windows.Forms.Label gloverDirectoryLabel;
        private System.Windows.Forms.Button searchFolderButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ModListLabel;
        private System.Windows.Forms.Label GloverDirectoryErrorMessage;
        private System.Windows.Forms.CheckedListBox ModMultiSelect;
        private System.Windows.Forms.ListBox EnabledModsList;
        private System.Windows.Forms.Label EnabledModsLabel;
        private Button ResetModsButton;
        private Button LoadModsButton;
        private Label ApplyChangesLabel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem aboutToolStripMenuItem;
    }
}

