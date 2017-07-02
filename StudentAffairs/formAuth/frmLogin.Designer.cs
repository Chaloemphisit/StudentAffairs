#region Copyright Syncfusion Inc. 2001 - 2017
// Copyright Syncfusion Inc. 2001 - 2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace StudentAffairs.formAuth {
    partial class frmLogin {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.txtUsername = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblCaptionUserName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.btnSignin = new Syncfusion.Windows.Forms.ButtonAdv();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.buttonAdv1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.BeforeTouchSize = new System.Drawing.Size(314, 30);
            this.txtUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.Font = new System.Drawing.Font("Roboto Light", 13F);
            this.txtUsername.Location = new System.Drawing.Point(24, 86);
            this.txtUsername.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtUsername.MinimumSize = new System.Drawing.Size(8, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(314, 30);
            this.txtUsername.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtUsername.TabIndex = 0;
            this.txtUsername.Text = "txtUsername";
            this.txtUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsername_KeyPress);
            this.txtUsername.Validating += new System.ComponentModel.CancelEventHandler(this.txtUsername_Validating);
            // 
            // lblCaptionUserName
            // 
            this.lblCaptionUserName.AutoSize = true;
            this.lblCaptionUserName.Font = new System.Drawing.Font("Roboto Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaptionUserName.ForeColor = System.Drawing.Color.DimGray;
            this.lblCaptionUserName.Location = new System.Drawing.Point(25, 55);
            this.lblCaptionUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCaptionUserName.Name = "lblCaptionUserName";
            this.lblCaptionUserName.Size = new System.Drawing.Size(83, 28);
            this.lblCaptionUserName.TabIndex = 17;
            this.lblCaptionUserName.Text = "ชื่อผู้ใช้งาน";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(25, 131);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 28);
            this.label1.TabIndex = 19;
            this.label1.Text = "รหัสผ่าน";
            // 
            // txtPassword
            // 
            this.txtPassword.BeforeTouchSize = new System.Drawing.Size(314, 30);
            this.txtPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Roboto Light", 13F);
            this.txtPassword.Location = new System.Drawing.Point(24, 162);
            this.txtPassword.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtPassword.MinimumSize = new System.Drawing.Size(8, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(314, 30);
            this.txtPassword.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtPassword.TabIndex = 18;
            this.txtPassword.Text = "txtPassword";
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // btnSignin
            // 
            this.btnSignin.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnSignin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.btnSignin.BeforeTouchSize = new System.Drawing.Size(101, 33);
            this.btnSignin.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.btnSignin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignin.Font = new System.Drawing.Font("Roboto Condensed Light", 12F);
            this.btnSignin.ForeColor = System.Drawing.Color.White;
            this.btnSignin.IsBackStageButton = false;
            this.btnSignin.Location = new System.Drawing.Point(130, 277);
            this.btnSignin.Name = "btnSignin";
            this.btnSignin.Size = new System.Drawing.Size(101, 33);
            this.btnSignin.TabIndex = 23;
            this.btnSignin.Text = "เข้าสู่ระบบ";
            this.btnSignin.Click += new System.EventHandler(this.btnSignin_Click);
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.Panel2.Location = new System.Drawing.Point(-81, 248);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(500, 1);
            this.Panel2.TabIndex = 24;
            // 
            // buttonAdv1
            // 
            this.buttonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.buttonAdv1.BeforeTouchSize = new System.Drawing.Size(101, 33);
            this.buttonAdv1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.buttonAdv1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdv1.Font = new System.Drawing.Font("Roboto Condensed Light", 12F);
            this.buttonAdv1.ForeColor = System.Drawing.Color.White;
            this.buttonAdv1.IsBackStageButton = false;
            this.buttonAdv1.Location = new System.Drawing.Point(237, 277);
            this.buttonAdv1.Name = "buttonAdv1";
            this.buttonAdv1.Size = new System.Drawing.Size(101, 33);
            this.buttonAdv1.TabIndex = 25;
            this.buttonAdv1.Text = "ยกเลิก";
            this.buttonAdv1.Click += new System.EventHandler(this.buttonAdv1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.BorderThickness = 2;
            this.CaptionButtonColor = System.Drawing.Color.Black;
            this.CaptionFont = new System.Drawing.Font("Roboto Condensed Light", 23F);
            this.CaptionForeColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(364, 331);
            this.Controls.Add(this.buttonAdv1);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.btnSignin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblCaptionUserName);
            this.Controls.Add(this.txtUsername);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.MaximizeBox = false;
            this.MetroColor = System.Drawing.Color.Transparent;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "เข้าสู่ระบบ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLogin_FormClosed);
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtUsername;
        internal System.Windows.Forms.Label lblCaptionUserName;
        internal System.Windows.Forms.Label label1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtPassword;
        private Syncfusion.Windows.Forms.ButtonAdv btnSignin;
        internal System.Windows.Forms.Panel Panel2;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}