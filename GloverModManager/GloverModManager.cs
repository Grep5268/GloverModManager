using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GloverModManager
{
    public partial class GloverModManager : Form
    {
        private const string GloverExe = "Glover.exe";
        private const string BackupFolderName = "backup";
        private const string ModFolderName = "mods";
        private const string DataFolderName = "data";

        public GloverModManager()
        {
            InitializeComponent();

            // Load saved directory from saved settings

            if (!string.IsNullOrWhiteSpace(Properties.Settings.Default.GloverDir))
            {
                gloverFolderTextBox.Text = Properties.Settings.Default.GloverDir;

                LoadModList();
            }
        }

        private void GloverModManagerLoad(object sender, EventArgs e)
        {

        }

        public void ChooseFolder()
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                gloverFolderTextBox.Text = folderBrowserDialog.SelectedPath;
                Properties.Settings.Default.GloverDir = folderBrowserDialog.SelectedPath;
                Properties.Settings.Default.Save();
                LoadModList();
            }
        }

        private void SaveBackup()
        {
            var baseFolders = Directory.GetDirectories(gloverFolderTextBox.Text).Select(x => new DirectoryInfo(x).Name);
            var backupDir = Path.Combine(gloverFolderTextBox.Text, BackupFolderName);
            var dataDir = Path.Combine(gloverFolderTextBox.Text, DataFolderName);

            // save files to backup folder
            if (!baseFolders.Contains(BackupFolderName))
            {
                Directory.CreateDirectory(Path.Combine(gloverFolderTextBox.Text, BackupFolderName));
                Copy(dataDir, backupDir);
            }

            if (!baseFolders.Contains(ModFolderName))
            {
                Directory.CreateDirectory(Path.Combine(gloverFolderTextBox.Text, ModFolderName));
            }
        }

        void Copy(string sourceDir, string targetDir)
        {
            Directory.CreateDirectory(targetDir);

            foreach (var file in Directory.GetFiles(sourceDir))
                File.Copy(file, Path.Combine(targetDir, Path.GetFileName(file)), true);

            foreach (var directory in Directory.GetDirectories(sourceDir))
                Copy(directory, Path.Combine(targetDir, Path.GetFileName(directory)));
        }

        private void LoadModList()
        {
            ModMultiSelect.Items.Clear();
            // Ensure directory is valid exists
            var exe = Directory.GetFiles(gloverFolderTextBox.Text, GloverExe);

            if (!exe.Any())
            {
                ShowError();
                return;
            }

            SaveBackup();

            ShowModList();

            var modFolders = Directory.GetDirectories(Path.Combine(gloverFolderTextBox.Text, ModFolderName));

            for (int i = 0; i < modFolders.Length; i++)
            {
                var modFolder = modFolders[i];
                ModMultiSelect.Items.Insert(i, new DirectoryInfo(modFolder).Name);
            }

            LoadSavedModSettings();
        }

        private void LoadSavedModSettings()
        {
            var enabledModsJson = Properties.Settings.Default.EnabledMods;
            if (string.IsNullOrWhiteSpace(enabledModsJson))
            {
                Properties.Settings.Default.EnabledMods = JsonConvert.SerializeObject(new List<string>());
                Properties.Settings.Default.Save();
            }

            ReloadEnabledModList();
        }

        private void ReloadEnabledModList(bool updateCheckboxes = true)
        {
            EnabledModsList.Items.Clear();
            var enabledModsJson = Properties.Settings.Default.EnabledMods;
            var enabledMods = JsonConvert.DeserializeObject<List<string>>(enabledModsJson);

            if (updateCheckboxes)
            {
                for (int i = 0; i < ModMultiSelect.Items.Count; i++)
                {
                    ModMultiSelect.SetItemChecked(i, false);
                }
            }
            
            foreach (var enabledMod in enabledMods)
            {
                EnabledModsList.Items.Add(enabledMod);

                for (int i = 0; i < ModMultiSelect.Items.Count; i++)
                {
                    if (updateCheckboxes && ModMultiSelect.Items[i].Equals(enabledMod))
                    {
                        ModMultiSelect.SetItemChecked(i, true);
                    }
                }
            }
        }

        private void ShowError()
        {
            GloverDirectoryErrorMessage.Visible = true;
            ModMultiSelect.Visible = ModListLabel.Visible = EnabledModsLabel.Visible = EnabledModsList.Visible = LoadModsButton.Visible = ResetModsButton.Visible = false;
        }

        private void ShowModList()
        {
            GloverDirectoryErrorMessage.Visible = false;
            ModMultiSelect.Visible = ModListLabel.Visible = EnabledModsLabel.Visible = EnabledModsList.Visible = LoadModsButton.Visible = ResetModsButton.Visible = true;
        }

        private void SearchFolderButton_Click(object sender, EventArgs e)
        {
            ChooseFolder();
        }

        private void ModMultiSelect_ItemCheck(Object sender, ItemCheckEventArgs e)
        {
            var enabledModsJson = Properties.Settings.Default.EnabledMods;
            var enabledMods = JsonConvert.DeserializeObject<List<string>>(enabledModsJson);
            var selectedItem = (string)((CheckedListBox)sender).SelectedItem;

            if (e.NewValue == CheckState.Checked && !string.IsNullOrWhiteSpace(selectedItem))
            {
                if (!enabledMods.Contains(selectedItem))
                {
                    enabledMods.Add(selectedItem);
                }
            }
            else if (e.NewValue == CheckState.Unchecked && !string.IsNullOrWhiteSpace(selectedItem))
            {
                if (enabledMods.Contains(selectedItem))
                {
                    enabledMods.Remove(selectedItem);
                }
            }

            // persist
            Properties.Settings.Default.EnabledMods = JsonConvert.SerializeObject(enabledMods);
            Properties.Settings.Default.Save();
            ReloadEnabledModList(false);
        }

        private void LoadModsButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            var modDir = Path.Combine(gloverFolderTextBox.Text, ModFolderName);
            var dataDir = Path.Combine(gloverFolderTextBox.Text, DataFolderName);
            var baseFolders = Directory.GetDirectories(modDir).Select(x => new DirectoryInfo(x).Name);

            var enabledModsJson = Properties.Settings.Default.EnabledMods;
            var enabledMods = JsonConvert.DeserializeObject<List<string>>(enabledModsJson).Reverse<string>(); // Reverse for mod load priority

            foreach (var enabledMod in enabledMods)
            {
                if (baseFolders.Contains(enabledMod))
                {
                    Copy(Path.Combine(modDir, enabledMod), dataDir);
                }
            }

            Cursor.Current = Cursors.Default;
            ShowChangesLabel();
        }

        private void ResetModsButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            var baseFolders = Directory.GetDirectories(gloverFolderTextBox.Text).Select(x => new DirectoryInfo(x).Name);
            var backupDir = Path.Combine(gloverFolderTextBox.Text, BackupFolderName);
            var dataDir = Path.Combine(gloverFolderTextBox.Text, DataFolderName);

            if (baseFolders.Contains(BackupFolderName))
            {
                Copy(backupDir, dataDir);
            }

            Properties.Settings.Default.EnabledMods = JsonConvert.SerializeObject(new List<string>());
            Properties.Settings.Default.Save();

            ReloadEnabledModList();

            Cursor.Current = Cursors.Default;
            ShowChangesLabel();
        }

        private void ShowChangesLabel()
        {
            ApplyChangesLabel.Visible = true;
            Task.Delay(3000).ContinueWith((task) => 
            {
                this.BeginInvoke((MethodInvoker)delegate
                {
                    ApplyChangesLabel.Visible = false;
                });
            });
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutWindow aboutWindow = new AboutWindow();
            aboutWindow.Show();
        }
    }
}
