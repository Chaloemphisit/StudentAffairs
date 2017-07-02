#region Copyright Syncfusion Inc. 2001 - 2017
// Copyright Syncfusion Inc. 2001 - 2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace StudentAffairs {
    partial class frmWait {
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
            this.progressBarAdv1 = new Syncfusion.Windows.Forms.Tools.ProgressBarAdv();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarAdv1)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBarAdv1
            // 
            this.progressBarAdv1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressBarAdv1.BackGradientEndColor = System.Drawing.Color.White;
            this.progressBarAdv1.BackGradientStartColor = System.Drawing.Color.White;
            this.progressBarAdv1.BackgroundStyle = Syncfusion.Windows.Forms.Tools.ProgressBarBackgroundStyles.Gradient;
            this.progressBarAdv1.BackMultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Empty};
            this.progressBarAdv1.BackSegments = false;
            this.progressBarAdv1.BackTubeEndColor = System.Drawing.Color.White;
            this.progressBarAdv1.BackTubeStartColor = System.Drawing.Color.White;
            this.progressBarAdv1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.progressBarAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.progressBarAdv1.CustomText = null;
            this.progressBarAdv1.CustomWaitingRender = false;
            this.progressBarAdv1.FontColor = System.Drawing.Color.White;
            this.progressBarAdv1.ForegroundImage = null;
            this.progressBarAdv1.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.progressBarAdv1.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.progressBarAdv1.Location = new System.Drawing.Point(12, 48);
            this.progressBarAdv1.MultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Empty};
            this.progressBarAdv1.Name = "progressBarAdv1";
            this.progressBarAdv1.ProgressFallbackStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Metro;
            this.progressBarAdv1.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Metro;
            this.progressBarAdv1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.progressBarAdv1.SegmentWidth = 12;
            this.progressBarAdv1.Size = new System.Drawing.Size(318, 18);
            this.progressBarAdv1.TabIndex = 1;
            this.progressBarAdv1.TextStyle = Syncfusion.Windows.Forms.Tools.ProgressBarTextStyles.Custom;
            this.progressBarAdv1.ThemesEnabled = true;
            this.progressBarAdv1.TubeEndColor = System.Drawing.Color.Black;
            this.progressBarAdv1.TubeStartColor = System.Drawing.Color.Red;
            this.progressBarAdv1.Value = 0;
            this.progressBarAdv1.WaitingGradientWidth = 200;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Loading...";
            // 
            // frmWait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.CaptionButtonColor = System.Drawing.Color.White;
            this.CaptionButtonHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CaptionForeColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(342, 83);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBarAdv1);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmWait";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmWait_Load);
            ((System.ComponentModel.ISupportInitialize)(this.progressBarAdv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Syncfusion.Windows.Forms.Tools.ProgressBarAdv progressBarAdv1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}