namespace FileBackupRestoreApp
{
    partial class Form1
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSourceFolder = new System.Windows.Forms.Label();
            this.txtSourceFolder = new System.Windows.Forms.TextBox();
            this.btnBrowseSource = new System.Windows.Forms.Button();
            this.lblBackupLocation = new System.Windows.Forms.Label();
            this.txtBackupLocation = new System.Windows.Forms.TextBox();
            this.btnBrowseBackupLocation = new System.Windows.Forms.Button();
            this.chkIncludeSubfolders = new System.Windows.Forms.CheckBox();
            this.btnLoadFiles = new System.Windows.Forms.Button();
            this.btnBackup = new System.Windows.Forms.Button();
            this.dgvFiles = new System.Windows.Forms.DataGridView();
            this.lblRestoreBackupFolder = new System.Windows.Forms.Label();
            this.txtRestoreBackupFolder = new System.Windows.Forms.TextBox();
            this.btnBrowseRestoreBackup = new System.Windows.Forms.Button();
            this.lblRestoreDestination = new System.Windows.Forms.Label();
            this.txtRestoreDestination = new System.Windows.Forms.TextBox();
            this.btnBrowseRestoreDestination = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(286, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(392, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "File Backup and Restore App";
            // 
            // lblSourceFolder
            // 
            this.lblSourceFolder.AutoSize = true;
            this.lblSourceFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSourceFolder.Location = new System.Drawing.Point(70, 70);
            this.lblSourceFolder.Name = "lblSourceFolder";
            this.lblSourceFolder.Size = new System.Drawing.Size(128, 22);
            this.lblSourceFolder.TabIndex = 1;
            this.lblSourceFolder.Text = "Source Folder:";
            // 
            // txtSourceFolder
            // 
            this.txtSourceFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSourceFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSourceFolder.Location = new System.Drawing.Point(209, 64);
            this.txtSourceFolder.Name = "txtSourceFolder";
            this.txtSourceFolder.Size = new System.Drawing.Size(595, 28);
            this.txtSourceFolder.TabIndex = 2;
            // 
            // btnBrowseSource
            // 
            this.btnBrowseSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseSource.Location = new System.Drawing.Point(825, 64);
            this.btnBrowseSource.Name = "btnBrowseSource";
            this.btnBrowseSource.Size = new System.Drawing.Size(102, 28);
            this.btnBrowseSource.TabIndex = 3;
            this.btnBrowseSource.Text = "Browse";
            this.btnBrowseSource.UseVisualStyleBackColor = true;
            this.btnBrowseSource.Click += new System.EventHandler(this.btnBrowseSource_Click);
            // 
            // lblBackupLocation
            // 
            this.lblBackupLocation.AutoSize = true;
            this.lblBackupLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBackupLocation.Location = new System.Drawing.Point(50, 153);
            this.lblBackupLocation.Name = "lblBackupLocation";
            this.lblBackupLocation.Size = new System.Drawing.Size(148, 22);
            this.lblBackupLocation.TabIndex = 1;
            this.lblBackupLocation.Text = "Backup Location:";
            // 
            // txtBackupLocation
            // 
            this.txtBackupLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBackupLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBackupLocation.Location = new System.Drawing.Point(209, 147);
            this.txtBackupLocation.Name = "txtBackupLocation";
            this.txtBackupLocation.Size = new System.Drawing.Size(595, 28);
            this.txtBackupLocation.TabIndex = 2;
            // 
            // btnBrowseBackupLocation
            // 
            this.btnBrowseBackupLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseBackupLocation.Location = new System.Drawing.Point(825, 147);
            this.btnBrowseBackupLocation.Name = "btnBrowseBackupLocation";
            this.btnBrowseBackupLocation.Size = new System.Drawing.Size(102, 31);
            this.btnBrowseBackupLocation.TabIndex = 4;
            this.btnBrowseBackupLocation.Text = "Browse";
            this.btnBrowseBackupLocation.UseVisualStyleBackColor = true;
            this.btnBrowseBackupLocation.Click += new System.EventHandler(this.btnBrowseBackupLocation_Click);
            // 
            // chkIncludeSubfolders
            // 
            this.chkIncludeSubfolders.AutoSize = true;
            this.chkIncludeSubfolders.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIncludeSubfolders.Location = new System.Drawing.Point(209, 103);
            this.chkIncludeSubfolders.Name = "chkIncludeSubfolders";
            this.chkIncludeSubfolders.Size = new System.Drawing.Size(177, 26);
            this.chkIncludeSubfolders.TabIndex = 5;
            this.chkIncludeSubfolders.Text = "Include subfolders";
            this.chkIncludeSubfolders.UseVisualStyleBackColor = true;
            // 
            // btnLoadFiles
            // 
            this.btnLoadFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadFiles.Location = new System.Drawing.Point(65, 199);
            this.btnLoadFiles.Name = "btnLoadFiles";
            this.btnLoadFiles.Size = new System.Drawing.Size(133, 39);
            this.btnLoadFiles.TabIndex = 6;
            this.btnLoadFiles.Text = "Load Files";
            this.btnLoadFiles.UseVisualStyleBackColor = true;
            this.btnLoadFiles.Click += new System.EventHandler(this.btnLoadFiles_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackup.Location = new System.Drawing.Point(228, 199);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(123, 39);
            this.btnBackup.TabIndex = 7;
            this.btnBackup.Text = "Backup Files";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // dgvFiles
            // 
            this.dgvFiles.AllowUserToAddRows = false;
            this.dgvFiles.AllowUserToDeleteRows = false;
            this.dgvFiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiles.Location = new System.Drawing.Point(27, 401);
            this.dgvFiles.MultiSelect = false;
            this.dgvFiles.Name = "dgvFiles";
            this.dgvFiles.ReadOnly = true;
            this.dgvFiles.RowHeadersWidth = 51;
            this.dgvFiles.RowTemplate.Height = 24;
            this.dgvFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFiles.Size = new System.Drawing.Size(920, 260);
            this.dgvFiles.TabIndex = 8;
            // 
            // lblRestoreBackupFolder
            // 
            this.lblRestoreBackupFolder.AutoSize = true;
            this.lblRestoreBackupFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestoreBackupFolder.Location = new System.Drawing.Point(17, 271);
            this.lblRestoreBackupFolder.Name = "lblRestoreBackupFolder";
            this.lblRestoreBackupFolder.Size = new System.Drawing.Size(219, 22);
            this.lblRestoreBackupFolder.TabIndex = 1;
            this.lblRestoreBackupFolder.Text = "Backup Folder to Restore:";
            // 
            // txtRestoreBackupFolder
            // 
            this.txtRestoreBackupFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRestoreBackupFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRestoreBackupFolder.Location = new System.Drawing.Point(252, 269);
            this.txtRestoreBackupFolder.Name = "txtRestoreBackupFolder";
            this.txtRestoreBackupFolder.Size = new System.Drawing.Size(590, 28);
            this.txtRestoreBackupFolder.TabIndex = 2;
            // 
            // btnBrowseRestoreBackup
            // 
            this.btnBrowseRestoreBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseRestoreBackup.Location = new System.Drawing.Point(857, 269);
            this.btnBrowseRestoreBackup.Name = "btnBrowseRestoreBackup";
            this.btnBrowseRestoreBackup.Size = new System.Drawing.Size(92, 28);
            this.btnBrowseRestoreBackup.TabIndex = 9;
            this.btnBrowseRestoreBackup.Text = "Browse";
            this.btnBrowseRestoreBackup.UseVisualStyleBackColor = true;
            this.btnBrowseRestoreBackup.Click += new System.EventHandler(this.btnBrowseRestoreBackup_Click);
            // 
            // lblRestoreDestination
            // 
            this.lblRestoreDestination.AutoSize = true;
            this.lblRestoreDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestoreDestination.Location = new System.Drawing.Point(61, 319);
            this.lblRestoreDestination.Name = "lblRestoreDestination";
            this.lblRestoreDestination.Size = new System.Drawing.Size(173, 22);
            this.lblRestoreDestination.TabIndex = 1;
            this.lblRestoreDestination.Text = "Restore Destination:";
            // 
            // txtRestoreDestination
            // 
            this.txtRestoreDestination.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRestoreDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRestoreDestination.Location = new System.Drawing.Point(252, 313);
            this.txtRestoreDestination.Name = "txtRestoreDestination";
            this.txtRestoreDestination.Size = new System.Drawing.Size(590, 28);
            this.txtRestoreDestination.TabIndex = 2;
            // 
            // btnBrowseRestoreDestination
            // 
            this.btnBrowseRestoreDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseRestoreDestination.Location = new System.Drawing.Point(857, 313);
            this.btnBrowseRestoreDestination.Name = "btnBrowseRestoreDestination";
            this.btnBrowseRestoreDestination.Size = new System.Drawing.Size(92, 27);
            this.btnBrowseRestoreDestination.TabIndex = 10;
            this.btnBrowseRestoreDestination.Text = "Browse";
            this.btnBrowseRestoreDestination.UseVisualStyleBackColor = true;
            this.btnBrowseRestoreDestination.Click += new System.EventHandler(this.btnBrowseRestoreDestination_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestore.Location = new System.Drawing.Point(242, 352);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(147, 30);
            this.btnRestore.TabIndex = 11;
            this.btnRestore.Text = "Restore Files";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(415, 352);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(101, 32);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(543, 352);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(113, 32);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(695, 356);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(62, 22);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Ready";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 673);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnBrowseRestoreDestination);
            this.Controls.Add(this.btnBrowseRestoreBackup);
            this.Controls.Add(this.dgvFiles);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.btnLoadFiles);
            this.Controls.Add(this.chkIncludeSubfolders);
            this.Controls.Add(this.btnBrowseBackupLocation);
            this.Controls.Add(this.btnBrowseSource);
            this.Controls.Add(this.txtRestoreDestination);
            this.Controls.Add(this.txtRestoreBackupFolder);
            this.Controls.Add(this.txtBackupLocation);
            this.Controls.Add(this.txtSourceFolder);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblRestoreDestination);
            this.Controls.Add(this.lblRestoreBackupFolder);
            this.Controls.Add(this.lblBackupLocation);
            this.Controls.Add(this.lblSourceFolder);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "File Backup and Restore App";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSourceFolder;
        private System.Windows.Forms.TextBox txtSourceFolder;
        private System.Windows.Forms.Button btnBrowseSource;
        private System.Windows.Forms.Label lblBackupLocation;
        private System.Windows.Forms.TextBox txtBackupLocation;
        private System.Windows.Forms.Button btnBrowseBackupLocation;
        private System.Windows.Forms.CheckBox chkIncludeSubfolders;
        private System.Windows.Forms.Button btnLoadFiles;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.DataGridView dgvFiles;
        private System.Windows.Forms.Label lblRestoreBackupFolder;
        private System.Windows.Forms.TextBox txtRestoreBackupFolder;
        private System.Windows.Forms.Button btnBrowseRestoreBackup;
        private System.Windows.Forms.Label lblRestoreDestination;
        private System.Windows.Forms.TextBox txtRestoreDestination;
        private System.Windows.Forms.Button btnBrowseRestoreDestination;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblStatus;
    }
}

