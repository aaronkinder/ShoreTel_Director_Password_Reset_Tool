namespace ShoreTel_Director_Password_Reset_Tool
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.grpServerInformation = new System.Windows.Forms.GroupBox();
            this.txtExternalIP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInternalIP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBuild = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHostname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpBackupStatus = new System.Windows.Forms.GroupBox();
            this.txtBackupLocation = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.prgProgress = new System.Windows.Forms.ProgressBar();
            this.bgWorkerInfoGather = new System.ComponentModel.BackgroundWorker();
            this.bgLicenseCheck = new System.ComponentModel.BackgroundWorker();
            this.grpServerInformation.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.grpBackupStatus.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpServerInformation
            // 
            this.grpServerInformation.Controls.Add(this.txtExternalIP);
            this.grpServerInformation.Controls.Add(this.label5);
            this.grpServerInformation.Controls.Add(this.txtInternalIP);
            this.grpServerInformation.Controls.Add(this.label4);
            this.grpServerInformation.Controls.Add(this.txtBuild);
            this.grpServerInformation.Controls.Add(this.label3);
            this.grpServerInformation.Controls.Add(this.txtVersion);
            this.grpServerInformation.Controls.Add(this.label2);
            this.grpServerInformation.Controls.Add(this.txtHostname);
            this.grpServerInformation.Controls.Add(this.label1);
            this.grpServerInformation.Location = new System.Drawing.Point(12, 12);
            this.grpServerInformation.Name = "grpServerInformation";
            this.grpServerInformation.Size = new System.Drawing.Size(368, 189);
            this.grpServerInformation.TabIndex = 0;
            this.grpServerInformation.TabStop = false;
            this.grpServerInformation.Text = "Server Information";
            // 
            // txtExternalIP
            // 
            this.txtExternalIP.Location = new System.Drawing.Point(122, 94);
            this.txtExternalIP.Name = "txtExternalIP";
            this.txtExternalIP.ReadOnly = true;
            this.txtExternalIP.Size = new System.Drawing.Size(232, 20);
            this.txtExternalIP.TabIndex = 9;
            this.txtExternalIP.Text = "IP Not Detected!";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "External IP Address:";
            // 
            // txtInternalIP
            // 
            this.txtInternalIP.Location = new System.Drawing.Point(122, 61);
            this.txtInternalIP.Name = "txtInternalIP";
            this.txtInternalIP.ReadOnly = true;
            this.txtInternalIP.Size = new System.Drawing.Size(232, 20);
            this.txtInternalIP.TabIndex = 7;
            this.txtInternalIP.Text = "IP Not Detected!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Internal IP Address:";
            // 
            // txtBuild
            // 
            this.txtBuild.Location = new System.Drawing.Point(122, 160);
            this.txtBuild.Name = "txtBuild";
            this.txtBuild.ReadOnly = true;
            this.txtBuild.Size = new System.Drawing.Size(232, 20);
            this.txtBuild.TabIndex = 5;
            this.txtBuild.Text = "Version Not Detected!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ShoreTel Build:";
            // 
            // txtVersion
            // 
            this.txtVersion.Location = new System.Drawing.Point(122, 126);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.ReadOnly = true;
            this.txtVersion.Size = new System.Drawing.Size(232, 20);
            this.txtVersion.TabIndex = 3;
            this.txtVersion.Text = "Version Not Detected!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ShoreTel Version:";
            // 
            // txtHostname
            // 
            this.txtHostname.Location = new System.Drawing.Point(122, 31);
            this.txtHostname.Name = "txtHostname";
            this.txtHostname.ReadOnly = true;
            this.txtHostname.Size = new System.Drawing.Size(232, 20);
            this.txtHostname.TabIndex = 1;
            this.txtHostname.Text = "Hostname Not Detected!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server Name:";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 424);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(392, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "msMainMenu";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetPasswordToolStripMenuItem,
            this.restoreDatabaseToolStripMenuItem,
            this.backupDatabaseToolStripMenuItem});
            this.optionsToolStripMenuItem.Enabled = false;
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // resetPasswordToolStripMenuItem
            // 
            this.resetPasswordToolStripMenuItem.Name = "resetPasswordToolStripMenuItem";
            this.resetPasswordToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.resetPasswordToolStripMenuItem.Text = "Reset Password";
            this.resetPasswordToolStripMenuItem.Click += new System.EventHandler(this.resetPasswordToolStripMenuItem_Click);
            // 
            // restoreDatabaseToolStripMenuItem
            // 
            this.restoreDatabaseToolStripMenuItem.Name = "restoreDatabaseToolStripMenuItem";
            this.restoreDatabaseToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.restoreDatabaseToolStripMenuItem.Text = "Restore Database";
            this.restoreDatabaseToolStripMenuItem.Click += new System.EventHandler(this.restoreDatabaseToolStripMenuItem_Click);
            // 
            // backupDatabaseToolStripMenuItem
            // 
            this.backupDatabaseToolStripMenuItem.Name = "backupDatabaseToolStripMenuItem";
            this.backupDatabaseToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.backupDatabaseToolStripMenuItem.Text = "Backup Database";
            this.backupDatabaseToolStripMenuItem.Click += new System.EventHandler(this.backupDatabaseToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // grpBackupStatus
            // 
            this.grpBackupStatus.Controls.Add(this.txtBackupLocation);
            this.grpBackupStatus.Controls.Add(this.label10);
            this.grpBackupStatus.Location = new System.Drawing.Point(12, 207);
            this.grpBackupStatus.Name = "grpBackupStatus";
            this.grpBackupStatus.Size = new System.Drawing.Size(368, 69);
            this.grpBackupStatus.TabIndex = 3;
            this.grpBackupStatus.TabStop = false;
            this.grpBackupStatus.Text = "Backup Status";
            // 
            // txtBackupLocation
            // 
            this.txtBackupLocation.Location = new System.Drawing.Point(122, 31);
            this.txtBackupLocation.Name = "txtBackupLocation";
            this.txtBackupLocation.ReadOnly = true;
            this.txtBackupLocation.Size = new System.Drawing.Size(232, 20);
            this.txtBackupLocation.TabIndex = 1;
            this.txtBackupLocation.Text = "No Backup Detected!";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Backup Location:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtUsername);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtPassword);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(12, 282);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(368, 93);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ShoreTel Admin Password Reset";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(122, 19);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(232, 20);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.Text = "admin";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Current Username:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(122, 59);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(232, 20);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "shoretel";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Desired Password:";
            // 
            // prgProgress
            // 
            this.prgProgress.Location = new System.Drawing.Point(12, 381);
            this.prgProgress.Name = "prgProgress";
            this.prgProgress.Size = new System.Drawing.Size(368, 23);
            this.prgProgress.TabIndex = 5;
            // 
            // bgWorkerInfoGather
            // 
            this.bgWorkerInfoGather.WorkerReportsProgress = true;
            this.bgWorkerInfoGather.WorkerSupportsCancellation = true;
            this.bgWorkerInfoGather.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorkerInfoGather_DoWork);
            this.bgWorkerInfoGather.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWorkerInfoGather_ProgressChanged);
            this.bgWorkerInfoGather.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorkerInfoGather_RunWorkerCompleted);
            // 
            // bgLicenseCheck
            // 
            this.bgLicenseCheck.WorkerReportsProgress = true;
            this.bgLicenseCheck.WorkerSupportsCancellation = true;
            this.bgLicenseCheck.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgLicenseCheck_DoWork);
            this.bgLicenseCheck.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgLicenseCheck_RunWorkerCompleted);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 448);
            this.Controls.Add(this.prgProgress);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grpBackupStatus);
            this.Controls.Add(this.grpServerInformation);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShoreTel Director Password Reset Tool";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpServerInformation.ResumeLayout(false);
            this.grpServerInformation.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.grpBackupStatus.ResumeLayout(false);
            this.grpBackupStatus.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpServerInformation;
        private System.Windows.Forms.TextBox txtHostname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoreDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox txtExternalIP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtInternalIP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBuild;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVersion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpBackupStatus;
        private System.Windows.Forms.TextBox txtBackupLocation;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem resetPasswordToolStripMenuItem;
        private System.Windows.Forms.ProgressBar prgProgress;
        private System.ComponentModel.BackgroundWorker bgWorkerInfoGather;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label7;
        private System.ComponentModel.BackgroundWorker bgLicenseCheck;
    }
}

