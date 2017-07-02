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
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.lblRecordCount = new System.Windows.Forms.ToolStripLabel();
            this.lblDesc = new System.Windows.Forms.Label();
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
            this.GGC.TableControlCurrentCellActivated += new Syncfusion.Windows.Forms.Grid.Grouping.GridTableControlEventHandler(this.GGC_TableControlCurrentCellActivated);
            this.GGC.TableControlCellDoubleClick += new Syncfusion.Windows.Forms.Grid.Grouping.GridTableControlCellClickEventHandler(this.GGC_TableControlCellDoubleClick);
            // 
            // ToolStripEx1
            // 
            this.ToolStripEx1.AutoSize = false;
            this.ToolStripEx1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ToolStripEx1.ForeColor = System.Drawing.Color.Black;
            this.ToolStripEx1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStripEx1.Image = null;
            this.ToolStripEx1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNew,
            this.btnEdit,
            this.btnDelete,
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
            // btnNew
            // 
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(52, 64);
            this.btnNew.Text = "เพิ่มข้อมูล";
            this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(58, 64);
            this.btnEdit.Text = "แก้ไขข้อมูล";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(52, 64);
            this.btnDelete.Text = "ลบข้อมูล";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ToolStripButton2
            // 
            this.ToolStripButton2.Enabled = false;
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
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(17, 64);
            this.lblRecordCount.Text = "[]";
            // 
            // lblDesc
            // 
            this.lblDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblDesc.ForeColor = System.Drawing.Color.Red;
            this.lblDesc.Location = new System.Drawing.Point(563, 56);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(191, 13);
            this.lblDesc.TabIndex = 74;
            this.lblDesc.Text = "Double click the mouse to select items.";
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
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.GGC);
            this.Controls.Add(this.ToolStripEx1);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.MetroColor = System.Drawing.Color.Transparent;
            this.MinimizeBox = false;
            this.Name = "frmBehaviorList";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "พฤติกรรมนักเรียน";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBehaviorList_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmBehaviorList_FormClosed);
            this.Load += new System.EventHandler(this.frmBehaviorList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GGC)).EndInit();
            this.ToolStripEx1.ResumeLayout(false);
            this.ToolStripEx1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl GGC;
        internal Syncfusion.Windows.Forms.Tools.ToolStripEx ToolStripEx1;
        internal System.Windows.Forms.ToolStripButton btnNew;
        internal System.Windows.Forms.ToolStripButton btnEdit;
        internal System.Windows.Forms.ToolStripButton btnDelete;
        internal System.Windows.Forms.ToolStripButton ToolStripButton2;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripLabel ToolStripLabel1;
        internal System.Windows.Forms.ToolStripTextBox txtSearch;
        internal System.Windows.Forms.ToolStripButton btnRefresh;
        internal System.Windows.Forms.ToolStripLabel lblRecordCount;
        internal System.Windows.Forms.Label lblDesc;
    }
}