using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FileBackupRestoreApp
{
    public partial class Form1 : Form
    {
        private DataTable fileTable = new DataTable();

        private bool ValidateBackupInput()
        {
            if (txtSourceFolder.Text.Trim() == "")
            {
                MessageBox.Show("Please select the source folder.",
                                "Missing Source Folder",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                return false;
            }

            if (!Directory.Exists(txtSourceFolder.Text.Trim()))
            {
                MessageBox.Show("The selected source folder does not exist.",
                                "Source Folder Not Found",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                return false;
            }

            if (txtBackupLocation.Text.Trim() == "")
            {
                MessageBox.Show("Please select the backup location.",
                                "Missing Backup Location",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                return false;
            }

            if (!Directory.Exists(txtBackupLocation.Text.Trim()))
            {
                MessageBox.Show("The selected backup location does not exist.",
                                "Backup Location Not Found",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                return false;
            }

            return true;
        }
        private void LoadFileList()
        {
            fileTable.Rows.Clear();

            string sourceFolder = txtSourceFolder.Text.Trim();

            SearchOption searchOption = chkIncludeSubfolders.Checked
                ? SearchOption.AllDirectories
                : SearchOption.TopDirectoryOnly;

            string[] files = Directory.GetFiles(sourceFolder, "*.*", searchOption);

            foreach (string filePath in files)
            {
                FileInfo fileInfo = new FileInfo(filePath);

                decimal sizeKb = Math.Round(fileInfo.Length / 1024m, 2);

                fileTable.Rows.Add(fileInfo.Name,
                                   fileInfo.DirectoryName,
                                   sizeKb,
                                   fileInfo.LastWriteTime.ToString());
            }
        }
        private string CreateBackupFolder()
        {
            string backupLocation = txtBackupLocation.Text.Trim();

            string folderName = "Backup_" + DateTime.Now.ToString("yyyyMMdd_HHmmss");

            string backupFolder = Path.Combine(backupLocation, folderName);

            Directory.CreateDirectory(backupFolder);

            return backupFolder;
        }
        private void CopyDirectory(string sourceDir, string destinationDir, bool includeSubfolders)
        {
            Directory.CreateDirectory(destinationDir);

            foreach (string filePath in Directory.GetFiles(sourceDir))
            {
                string fileName = Path.GetFileName(filePath);
                string destinationFile = Path.Combine(destinationDir, fileName);

                File.Copy(filePath, destinationFile, true);
            }

            if (includeSubfolders)
            {
                foreach (string subfolderPath in Directory.GetDirectories(sourceDir))
                {
                    string folderName = Path.GetFileName(subfolderPath);
                    string destinationSubfolder = Path.Combine(destinationDir, folderName);

                    CopyDirectory(subfolderPath, destinationSubfolder, true);
                }
            }
        }
        private bool ValidateRestoreInput()
        {
            if (txtRestoreBackupFolder.Text.Trim() == "")
            {
                MessageBox.Show("Please select the backup folder to restore.",
                                "Missing Backup Folder",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                return false;
            }

            if (!Directory.Exists(txtRestoreBackupFolder.Text.Trim()))
            {
                MessageBox.Show("The selected backup folder does not exist.",
                                "Backup Folder Not Found",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                return false;
            }

            if (txtRestoreDestination.Text.Trim() == "")
            {
                MessageBox.Show("Please select the restore destination folder.",
                                "Missing Restore Destination",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                return false;
            }

            if (!Directory.Exists(txtRestoreDestination.Text.Trim()))
            {
                MessageBox.Show("The selected restore destination folder does not exist.",
                                "Restore Destination Not Found",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                return false;
            }

            return true;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fileTable.Columns.Add("File Name", typeof(string));
            fileTable.Columns.Add("Folder Path", typeof(string));
            fileTable.Columns.Add("Size KB", typeof(decimal));
            fileTable.Columns.Add("Date Modified", typeof(string));

            dgvFiles.DataSource = fileTable;

            chkIncludeSubfolders.Checked = true;
            lblStatus.Text = "Ready";

        }

        private void btnBrowseSource_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "Select the source folder to back up";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtSourceFolder.Text = dialog.SelectedPath;
                lblStatus.Text = "Source folder selected.";
            }

        }

        private void btnBrowseBackupLocation_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "Select the backup location";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtBackupLocation.Text = dialog.SelectedPath;
                lblStatus.Text = "Backup location selected.";
            }

        }

        private void btnBrowseRestoreBackup_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "Select the backup folder to restore";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtRestoreBackupFolder.Text = dialog.SelectedPath;
                lblStatus.Text = "Backup folder selected for restore.";
            }

        }

        private void btnBrowseRestoreDestination_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "Select the restore destination folder";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtRestoreDestination.Text = dialog.SelectedPath;
                lblStatus.Text = "Restore destination selected.";
            }

        }

        private void btnLoadFiles_Click(object sender, EventArgs e)
        {

            if (txtSourceFolder.Text.Trim() == "")
            {
                MessageBox.Show("Please select the source folder first.",
                                "Missing Source Folder",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                return;
            }

            if (!Directory.Exists(txtSourceFolder.Text.Trim()))
            {
                MessageBox.Show("The selected source folder does not exist.",
                                "Source Folder Not Found",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                return;
            }

            LoadFileList();

            lblStatus.Text = $"Files loaded: {fileTable.Rows.Count}";

        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            if (!ValidateBackupInput())
            {
                return;
            }

            try
            {
                string sourceFolder = txtSourceFolder.Text.Trim();
                string backupFolder = CreateBackupFolder();

                CopyDirectory(sourceFolder,
                              backupFolder,
                              chkIncludeSubfolders.Checked);

                LoadFileList();

                lblStatus.Text = "Backup completed successfully.";

                MessageBox.Show("Backup completed successfully.\n\nBackup folder:\n" + backupFolder,
                                "Backup Complete",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Backup failed.";

                MessageBox.Show("Backup failed.\n\n" + ex.Message,
                                "Backup Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (!ValidateRestoreInput())
            {
                return;
            }

            DialogResult result = MessageBox.Show("Restoring files may overwrite files with the same names in the destination folder.\n\nDo you want to continue?",
                                                  "Confirm Restore",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                return;
            }

            try
            {
                string backupFolder = txtRestoreBackupFolder.Text.Trim();
                string restoreDestination = txtRestoreDestination.Text.Trim();

                CopyDirectory(backupFolder, restoreDestination, true);

                lblStatus.Text = "Restore completed successfully.";

                MessageBox.Show("Restore completed successfully.",
                                "Restore Complete",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Restore failed.";

                MessageBox.Show("Restore failed.\n\n" + ex.Message,
                                "Restore Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSourceFolder.Clear();
            txtBackupLocation.Clear();
            txtRestoreBackupFolder.Clear();
            txtRestoreDestination.Clear();

            fileTable.Rows.Clear();

            chkIncludeSubfolders.Checked = true;

            lblStatus.Text = "Ready";

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?",
                                      "Confirm Exit",
                                      MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
    }
}
