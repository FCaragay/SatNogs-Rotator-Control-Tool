﻿
namespace Rotator_Serial_Interface
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblIP = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.btnSSHConnect = new System.Windows.Forms.Button();
            this.lblConnectStatus = new System.Windows.Forms.Label();
            this.lblConnectState = new System.Windows.Forms.Label();
            this.gbSSH = new System.Windows.Forms.GroupBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.gbControls = new System.Windows.Forms.GroupBox();
            this.btnSTOP = new System.Windows.Forms.Button();
            this.gbCommand = new System.Windows.Forms.GroupBox();
            this.btnControlMode = new System.Windows.Forms.Button();
            this.btnRotatorStatus = new System.Windows.Forms.Button();
            this.btnFMVer = new System.Windows.Forms.Button();
            this.btnIP1 = new System.Windows.Forms.Button();
            this.btnGetPos = new System.Windows.Forms.Button();
            this.lstLog = new System.Windows.Forms.ListBox();
            this.lblELtrkval = new System.Windows.Forms.Label();
            this.lblAZtrkval = new System.Windows.Forms.Label();
            this.lblELCurrentPos = new System.Windows.Forms.Label();
            this.lblAZCurrentPos = new System.Windows.Forms.Label();
            this.txtELposition = new System.Windows.Forms.TextBox();
            this.txtAZposition = new System.Windows.Forms.TextBox();
            this.btnAZELConf = new System.Windows.Forms.Button();
            this.lblELtrk = new System.Windows.Forms.Label();
            this.lblAZtrk = new System.Windows.Forms.Label();
            this.trkEL = new System.Windows.Forms.TrackBar();
            this.trkAZ = new System.Windows.Forms.TrackBar();
            this.pbUser = new System.Windows.Forms.ProgressBar();
            this.txtUserNotif = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tooltipESTOP = new System.Windows.Forms.ToolTip(this.components);
            this.gbSSH.SuspendLayout();
            this.gbControls.SuspendLayout();
            this.gbCommand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkEL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkAZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(80, 26);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(100, 20);
            this.txtIP.TabIndex = 0;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(80, 78);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(100, 20);
            this.txtPass.TabIndex = 2;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(80, 52);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 20);
            this.txtUser.TabIndex = 1;
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(16, 29);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(58, 13);
            this.lblIP.TabIndex = 3;
            this.lblIP.Text = "IP Address";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(16, 55);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Username";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(16, 81);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(53, 13);
            this.lblPass.TabIndex = 5;
            this.lblPass.Text = "Password";
            // 
            // btnSSHConnect
            // 
            this.btnSSHConnect.Location = new System.Drawing.Point(19, 104);
            this.btnSSHConnect.Name = "btnSSHConnect";
            this.btnSSHConnect.Size = new System.Drawing.Size(161, 23);
            this.btnSSHConnect.TabIndex = 3;
            this.btnSSHConnect.Text = "Connect";
            this.btnSSHConnect.UseVisualStyleBackColor = true;
            this.btnSSHConnect.Click += new System.EventHandler(this.btnSSHConnect_Click);
            // 
            // lblConnectStatus
            // 
            this.lblConnectStatus.AutoSize = true;
            this.lblConnectStatus.Location = new System.Drawing.Point(34, 166);
            this.lblConnectStatus.Name = "lblConnectStatus";
            this.lblConnectStatus.Size = new System.Drawing.Size(40, 13);
            this.lblConnectStatus.TabIndex = 7;
            this.lblConnectStatus.Text = "Status:";
            // 
            // lblConnectState
            // 
            this.lblConnectState.AutoSize = true;
            this.lblConnectState.Location = new System.Drawing.Point(81, 166);
            this.lblConnectState.Name = "lblConnectState";
            this.lblConnectState.Size = new System.Drawing.Size(79, 13);
            this.lblConnectState.TabIndex = 8;
            this.lblConnectState.Text = "Not Connected";
            // 
            // gbSSH
            // 
            this.gbSSH.Controls.Add(this.btnDisconnect);
            this.gbSSH.Controls.Add(this.lblIP);
            this.gbSSH.Controls.Add(this.lblConnectState);
            this.gbSSH.Controls.Add(this.txtIP);
            this.gbSSH.Controls.Add(this.lblConnectStatus);
            this.gbSSH.Controls.Add(this.txtPass);
            this.gbSSH.Controls.Add(this.btnSSHConnect);
            this.gbSSH.Controls.Add(this.txtUser);
            this.gbSSH.Controls.Add(this.lblPass);
            this.gbSSH.Controls.Add(this.lblUsername);
            this.gbSSH.Location = new System.Drawing.Point(12, 12);
            this.gbSSH.Name = "gbSSH";
            this.gbSSH.Size = new System.Drawing.Size(200, 191);
            this.gbSSH.TabIndex = 9;
            this.gbSSH.TabStop = false;
            this.gbSSH.Text = "SSH Configuration";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(19, 133);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(161, 23);
            this.btnDisconnect.TabIndex = 4;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // gbControls
            // 
            this.gbControls.Controls.Add(this.btnSTOP);
            this.gbControls.Controls.Add(this.gbCommand);
            this.gbControls.Controls.Add(this.btnGetPos);
            this.gbControls.Controls.Add(this.lstLog);
            this.gbControls.Controls.Add(this.lblELtrkval);
            this.gbControls.Controls.Add(this.lblAZtrkval);
            this.gbControls.Controls.Add(this.lblELCurrentPos);
            this.gbControls.Controls.Add(this.lblAZCurrentPos);
            this.gbControls.Controls.Add(this.txtELposition);
            this.gbControls.Controls.Add(this.txtAZposition);
            this.gbControls.Controls.Add(this.btnAZELConf);
            this.gbControls.Controls.Add(this.lblELtrk);
            this.gbControls.Controls.Add(this.lblAZtrk);
            this.gbControls.Controls.Add(this.trkEL);
            this.gbControls.Controls.Add(this.trkAZ);
            this.gbControls.Enabled = false;
            this.gbControls.Location = new System.Drawing.Point(237, 12);
            this.gbControls.Name = "gbControls";
            this.gbControls.Size = new System.Drawing.Size(508, 257);
            this.gbControls.TabIndex = 10;
            this.gbControls.TabStop = false;
            this.gbControls.Text = "Controls";
            // 
            // btnSTOP
            // 
            this.btnSTOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSTOP.ForeColor = System.Drawing.Color.Red;
            this.btnSTOP.Location = new System.Drawing.Point(168, 110);
            this.btnSTOP.Name = "btnSTOP";
            this.btnSTOP.Size = new System.Drawing.Size(67, 22);
            this.btnSTOP.TabIndex = 12;
            this.btnSTOP.Text = "E-STOP";
            this.btnSTOP.UseVisualStyleBackColor = true;
            this.btnSTOP.Click += new System.EventHandler(this.btnSTOP_Click);
            this.btnSTOP.MouseHover += new System.EventHandler(this.btnSTOP_MouseHover);
            // 
            // gbCommand
            // 
            this.gbCommand.Controls.Add(this.btnControlMode);
            this.gbCommand.Controls.Add(this.btnRotatorStatus);
            this.gbCommand.Controls.Add(this.btnFMVer);
            this.gbCommand.Controls.Add(this.btnIP1);
            this.gbCommand.Location = new System.Drawing.Point(6, 138);
            this.gbCommand.Name = "gbCommand";
            this.gbCommand.Size = new System.Drawing.Size(236, 113);
            this.gbCommand.TabIndex = 15;
            this.gbCommand.TabStop = false;
            this.gbCommand.Text = "Query";
            // 
            // btnControlMode
            // 
            this.btnControlMode.Location = new System.Drawing.Point(110, 19);
            this.btnControlMode.Name = "btnControlMode";
            this.btnControlMode.Size = new System.Drawing.Size(97, 23);
            this.btnControlMode.TabIndex = 8;
            this.btnControlMode.Text = "Control Mode";
            this.btnControlMode.UseVisualStyleBackColor = true;
            // 
            // btnRotatorStatus
            // 
            this.btnRotatorStatus.Location = new System.Drawing.Point(7, 77);
            this.btnRotatorStatus.Name = "btnRotatorStatus";
            this.btnRotatorStatus.Size = new System.Drawing.Size(97, 23);
            this.btnRotatorStatus.TabIndex = 10;
            this.btnRotatorStatus.Text = "Rotator Status";
            this.btnRotatorStatus.UseVisualStyleBackColor = true;
            this.btnRotatorStatus.Click += new System.EventHandler(this.btnRotatorStatus_Click);
            // 
            // btnFMVer
            // 
            this.btnFMVer.Location = new System.Drawing.Point(7, 48);
            this.btnFMVer.Name = "btnFMVer";
            this.btnFMVer.Size = new System.Drawing.Size(97, 23);
            this.btnFMVer.TabIndex = 9;
            this.btnFMVer.Text = "Firmware Version";
            this.btnFMVer.UseVisualStyleBackColor = true;
            this.btnFMVer.Click += new System.EventHandler(this.btnFMVer_Click);
            // 
            // btnIP1
            // 
            this.btnIP1.Location = new System.Drawing.Point(7, 19);
            this.btnIP1.Name = "btnIP1";
            this.btnIP1.Size = new System.Drawing.Size(97, 23);
            this.btnIP1.TabIndex = 7;
            this.btnIP1.Text = "Internal Temp";
            this.btnIP1.UseVisualStyleBackColor = true;
            // 
            // btnGetPos
            // 
            this.btnGetPos.Location = new System.Drawing.Point(87, 109);
            this.btnGetPos.Name = "btnGetPos";
            this.btnGetPos.Size = new System.Drawing.Size(75, 23);
            this.btnGetPos.TabIndex = 6;
            this.btnGetPos.Text = "Get Position";
            this.btnGetPos.UseVisualStyleBackColor = true;
            this.btnGetPos.Click += new System.EventHandler(this.btnGetPos_Click);
            // 
            // lstLog
            // 
            this.lstLog.FormattingEnabled = true;
            this.lstLog.HorizontalExtent = 10;
            this.lstLog.Location = new System.Drawing.Point(248, 117);
            this.lstLog.Name = "lstLog";
            this.lstLog.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstLog.Size = new System.Drawing.Size(249, 134);
            this.lstLog.TabIndex = 11;
            // 
            // lblELtrkval
            // 
            this.lblELtrkval.AutoSize = true;
            this.lblELtrkval.Location = new System.Drawing.Point(370, 80);
            this.lblELtrkval.Name = "lblELtrkval";
            this.lblELtrkval.Size = new System.Drawing.Size(13, 13);
            this.lblELtrkval.TabIndex = 10;
            this.lblELtrkval.Text = "0";
            // 
            // lblAZtrkval
            // 
            this.lblAZtrkval.AutoSize = true;
            this.lblAZtrkval.Location = new System.Drawing.Point(370, 29);
            this.lblAZtrkval.Name = "lblAZtrkval";
            this.lblAZtrkval.Size = new System.Drawing.Size(13, 13);
            this.lblAZtrkval.TabIndex = 9;
            this.lblAZtrkval.Text = "0";
            // 
            // lblELCurrentPos
            // 
            this.lblELCurrentPos.AutoSize = true;
            this.lblELCurrentPos.Location = new System.Drawing.Point(403, 71);
            this.lblELCurrentPos.Name = "lblELCurrentPos";
            this.lblELCurrentPos.Size = new System.Drawing.Size(93, 13);
            this.lblELCurrentPos.TabIndex = 8;
            this.lblELCurrentPos.Text = "EL Active Position";
            this.lblELCurrentPos.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblAZCurrentPos
            // 
            this.lblAZCurrentPos.AutoSize = true;
            this.lblAZCurrentPos.Location = new System.Drawing.Point(403, 20);
            this.lblAZCurrentPos.Name = "lblAZCurrentPos";
            this.lblAZCurrentPos.Size = new System.Drawing.Size(94, 13);
            this.lblAZCurrentPos.TabIndex = 7;
            this.lblAZCurrentPos.Text = "AZ Active Position";
            // 
            // txtELposition
            // 
            this.txtELposition.Location = new System.Drawing.Point(413, 87);
            this.txtELposition.Name = "txtELposition";
            this.txtELposition.ReadOnly = true;
            this.txtELposition.Size = new System.Drawing.Size(78, 20);
            this.txtELposition.TabIndex = 100;
            this.txtELposition.TabStop = false;
            // 
            // txtAZposition
            // 
            this.txtAZposition.Location = new System.Drawing.Point(413, 39);
            this.txtAZposition.Name = "txtAZposition";
            this.txtAZposition.ReadOnly = true;
            this.txtAZposition.Size = new System.Drawing.Size(78, 20);
            this.txtAZposition.TabIndex = 5;
            this.txtAZposition.TabStop = false;
            // 
            // btnAZELConf
            // 
            this.btnAZELConf.Location = new System.Drawing.Point(6, 109);
            this.btnAZELConf.Name = "btnAZELConf";
            this.btnAZELConf.Size = new System.Drawing.Size(75, 23);
            this.btnAZELConf.TabIndex = 5;
            this.btnAZELConf.Text = "Set Position";
            this.btnAZELConf.UseVisualStyleBackColor = true;
            this.btnAZELConf.Click += new System.EventHandler(this.btnAZELConf_Click);
            // 
            // lblELtrk
            // 
            this.lblELtrk.AutoSize = true;
            this.lblELtrk.Location = new System.Drawing.Point(10, 80);
            this.lblELtrk.Name = "lblELtrk";
            this.lblELtrk.Size = new System.Drawing.Size(60, 13);
            this.lblELtrk.TabIndex = 3;
            this.lblELtrk.Text = "EL Position";
            // 
            // lblAZtrk
            // 
            this.lblAZtrk.AutoSize = true;
            this.lblAZtrk.Location = new System.Drawing.Point(10, 29);
            this.lblAZtrk.Name = "lblAZtrk";
            this.lblAZtrk.Size = new System.Drawing.Size(61, 13);
            this.lblAZtrk.TabIndex = 2;
            this.lblAZtrk.Text = "AZ Position";
            // 
            // trkEL
            // 
            this.trkEL.Location = new System.Drawing.Point(69, 71);
            this.trkEL.Maximum = 180;
            this.trkEL.Name = "trkEL";
            this.trkEL.Size = new System.Drawing.Size(294, 45);
            this.trkEL.TabIndex = 1;
            this.trkEL.Scroll += new System.EventHandler(this.trkEL_Scroll);
            // 
            // trkAZ
            // 
            this.trkAZ.Location = new System.Drawing.Point(69, 20);
            this.trkAZ.Maximum = 360;
            this.trkAZ.Name = "trkAZ";
            this.trkAZ.Size = new System.Drawing.Size(294, 45);
            this.trkAZ.TabIndex = 0;
            this.trkAZ.Scroll += new System.EventHandler(this.trkAZ_Scroll);
            // 
            // pbUser
            // 
            this.pbUser.Location = new System.Drawing.Point(237, 275);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(508, 10);
            this.pbUser.TabIndex = 12;
            // 
            // txtUserNotif
            // 
            this.txtUserNotif.Location = new System.Drawing.Point(237, 292);
            this.txtUserNotif.Name = "txtUserNotif";
            this.txtUserNotif.Size = new System.Drawing.Size(508, 20);
            this.txtUserNotif.TabIndex = 13;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Rotator_Serial_Interface.Properties.Resources.satnogs_net;
            this.pictureBox1.Location = new System.Drawing.Point(12, 243);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(756, 326);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtUserNotif);
            this.Controls.Add(this.pbUser);
            this.Controls.Add(this.gbControls);
            this.Controls.Add(this.gbSSH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(772, 365);
            this.MinimumSize = new System.Drawing.Size(772, 365);
            this.Name = "frmMain";
            this.Text = "SatNogs Rotator Control Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbSSH.ResumeLayout(false);
            this.gbSSH.PerformLayout();
            this.gbControls.ResumeLayout(false);
            this.gbControls.PerformLayout();
            this.gbCommand.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trkEL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkAZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Button btnSSHConnect;
        private System.Windows.Forms.Label lblConnectStatus;
        private System.Windows.Forms.Label lblConnectState;
        private System.Windows.Forms.GroupBox gbSSH;
        private System.Windows.Forms.GroupBox gbControls;
        private System.Windows.Forms.Label lblELCurrentPos;
        private System.Windows.Forms.Label lblAZCurrentPos;
        private System.Windows.Forms.TextBox txtELposition;
        private System.Windows.Forms.TextBox txtAZposition;
        private System.Windows.Forms.Button btnAZELConf;
        private System.Windows.Forms.Label lblELtrk;
        private System.Windows.Forms.Label lblAZtrk;
        private System.Windows.Forms.TrackBar trkEL;
        private System.Windows.Forms.TrackBar trkAZ;
        private System.Windows.Forms.Label lblELtrkval;
        private System.Windows.Forms.Label lblAZtrkval;
        private System.Windows.Forms.Button btnSTOP;
        private System.Windows.Forms.GroupBox gbCommand;
        private System.Windows.Forms.Button btnControlMode;
        private System.Windows.Forms.Button btnRotatorStatus;
        private System.Windows.Forms.Button btnFMVer;
        private System.Windows.Forms.Button btnIP1;
        private System.Windows.Forms.Button btnGetPos;
        private System.Windows.Forms.ListBox lstLog;
        private System.Windows.Forms.ProgressBar pbUser;
        private System.Windows.Forms.TextBox txtUserNotif;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip tooltipESTOP;
    }
}
