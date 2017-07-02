#region Copyright Syncfusion Inc. 2001 - 2017
// Copyright Syncfusion Inc. 2001 - 2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace StudentAffairs {
    partial class frmSplash {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
            this.bigApp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.progressbar1 = new MetroProgressBar.Progressbar();
            this.SuspendLayout();
            // 
            // bigApp
            // 
            this.bigApp.AutoSize = true;
            this.bigApp.BackColor = System.Drawing.Color.Transparent;
            this.bigApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.bigApp.ForeColor = System.Drawing.Color.White;
            this.bigApp.Location = new System.Drawing.Point(35, 99);
            this.bigApp.Name = "bigApp";
            this.bigApp.Size = new System.Drawing.Size(367, 36);
            this.bigApp.TabIndex = 2;
            this.bigApp.Text = "ระบบบันทึกพฤติกรรมนักเรียน";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "กำลังเตรียมความพร้อม...";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(73, 41);
            this.panel1.TabIndex = 5;
            // 
            // progressbar1
            // 
            this.progressbar1.BackColor = System.Drawing.Color.Transparent;
            this.progressbar1.Location = new System.Drawing.Point(63, 152);
            this.progressbar1.Name = "progressbar1";
            this.progressbar1.Size = new System.Drawing.Size(308, 14);
            this.progressbar1.TabIndex = 6;
            this.progressbar1.Load += new System.EventHandler(this.progressbar1_Load);
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(86)))), ((int)(((byte)(154)))));
            this.ClientSize = new System.Drawing.Size(439, 248);
            this.ControlBox = false;
            this.Controls.Add(this.progressbar1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bigApp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(439, 248);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(439, 248);
            this.Name = "frmSplash";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmSplash_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label bigApp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private MetroProgressBar.Progressbar progressbar1;
    }
}