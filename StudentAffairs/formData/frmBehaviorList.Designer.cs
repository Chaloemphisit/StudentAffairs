#region Copyright Syncfusion Inc. 2001 - 2017
// Copyright Syncfusion Inc. 2001 - 2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace StudentAffairs.formData {
    partial class frmBehaviorList {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBehaviorList));
            this.GGC = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.ToolStripEx1 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.ToolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.lblRecordCount = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.GGC)).BeginInit();
            this.ToolStripEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GGC
            // 
            this.GGC.ActivateCurrentCellBehavior = Syncfusion.Windows.Forms.Grid.GridCellActivateAction.None;
            this.GGC.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.GGC.BackColor = System.Drawing.SystemColors.Window;
            this.GGC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GGC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GGC.Location = new System.Drawing.Point(0, 72);
            this.GGC.Name = "GGC";
            this.GGC.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this.GGC.Size = new System.Drawing.Size(754, 368);
            this.GGC.TabIndex = 71;
            this.GGC.UseRightToLeftCompatibleTextBox = true;
            this.GGC.VersionInfo = "15.2451.0.40";
            // 
            // ToolStripEx1
            // 
            this.ToolStripEx1.AutoSize = false;
            this.ToolStripEx1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ToolStripEx1.ForeColor = System.Drawing.Color.Black;
            this.ToolStripEx1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStripEx1.Image = null;
            this.ToolStripEx1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripButton3,
            this.ToolStripButton1,
            this.ToolStripButton4,
            this.ToolStripButton2,
            this.ToolStripSeparator1,
            this.ToolStripLabel1,
            this.txtSearch,
            this.btnRefresh,
            this.lblRecordCount});
            this.ToolStripEx1.LauncherStyle = Syncfusion.Windows.Forms.Tools.LauncherStyle.Metro;
            this.ToolStripEx1.Location = new System.Drawing.Point(0, 0);
            this.ToolStripEx1.Name = "ToolStripEx1";
            this.ToolStripEx1.Office12Mode = false;
            this.ToolStripEx1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.ToolStripEx1.ShowCaption = false;
            this.ToolStripEx1.ShowLauncher = false;
            this.ToolStripEx1.Size = new System.Drawing.Size(754, 72);
            this.ToolStripEx1.TabIndex = 70;
            this.ToolStripEx1.VisualStyle = Syncfusion.Windows.Forms.Tools.ToolStripExStyle.Metro;
            // 
            // ToolStripButton3
            // 
            this.ToolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton3.Image")));
            this.ToolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton3.Name = "ToolStripButton3";
            this.ToolStripButton3.Size = new System.Drawing.Size(52, 64);
            this.ToolStripButton3.Text = "เพิ่มข้อมูล";
            this.ToolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ToolStripButton1
            // 
            this.ToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton1.Image")));
            this.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton1.Name = "ToolStripButton1";
            this.ToolStripButton1.Size = new System.Drawing.Size(58, 64);
            this.ToolStripButton1.Text = "แก้ไขข้อมูล";
            this.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ToolStripButton4
            // 
            this.ToolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton4.Image")));
            this.ToolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton4.Name = "ToolStripButton4";
            this.ToolStripButton4.Size = new System.Drawing.Size(52, 64);
            this.ToolStripButton4.Text = "ลบข้อมูล";
            this.ToolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ToolStripButton2
            // 
            this.ToolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton2.Image")));
            this.ToolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton2.Name = "ToolStripButton2";
            this.ToolStripButton2.Size = new System.Drawing.Size(52, 64);
            this.ToolStripButton2.Text = "พิมพ์";
            this.ToolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 67);
            // 
            // ToolStripLabel1
            // 
            this.ToolStripLabel1.Name = "ToolStripLabel1";
            this.ToolStripLabel1.Size = new System.Drawing.Size(31, 64);
            this.ToolStripLabel1.Text = "ค้นหา";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 67);
            // 
            // btnRefresh
            // 
            this.btnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(23, 64);
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(17, 64);
            this.lblRecordCount.Text = "[]";
            // 
            // frmBehaviorList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.BorderThickness = 2;
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.CaptionButtonColor = System.Drawing.Color.White;
            this.CaptionFont = new System.Drawing.Font("Roboto Condensed Light", 23F);
            this.CaptionForeColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(754, 440);
            this.Controls.Add(this.GGC);
            this.Controls.Add(this.ToolStripEx1);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.MetroColor = System.Drawing.Color.Transparent;
            this.MinimizeBox = false;
            this.Name = "frmBehaviorList";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "พฤติกรรมนักเรียน";
            this.Load += new System.EventHandler(this.frmBehaviorList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GGC)).EndInit();
            this.ToolStripEx1.ResumeLayout(false);
            this.ToolStripEx1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl GGC;
        internal Syncfusion.Windows.Forms.Tools.ToolStripEx ToolStripEx1;
        internal System.Windows.Forms.ToolStripButton ToolStripButton3;
        internal System.Windows.Forms.ToolStripButton ToolStripButton1;
        internal System.Windows.Forms.ToolStripButton ToolStripButton4;
        internal System.Windows.Forms.ToolStripButton ToolStripButton2;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripLabel ToolStripLabel1;
        internal System.Windows.Forms.ToolStripTextBox txtSearch;
        internal System.Windows.Forms.ToolStripButton btnRefresh;
        internal System.Windows.Forms.ToolStripLabel lblRecordCount;
    }
}