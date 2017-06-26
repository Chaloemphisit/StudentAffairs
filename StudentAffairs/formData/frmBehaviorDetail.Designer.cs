#region Copyright Syncfusion Inc. 2001 - 2017
// Copyright Syncfusion Inc. 2001 - 2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace StudentAffairs.formData {
    partial class frmBehaviorDetail {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBehaviorDetail));
            this.btnDelete = new Syncfusion.Windows.Forms.ButtonAdv();
            this.Label11 = new System.Windows.Forms.Label();
            this.DateTimePicker = new Syncfusion.Windows.Forms.Tools.DateTimePickerAdv();
            this.txtRecorderName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.Label10 = new System.Windows.Forms.Label();
            this.cbType = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.Label9 = new System.Windows.Forms.Label();
            this.btnSave = new Syncfusion.Windows.Forms.ButtonAdv();
            this.txtStudentFirstName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.txtStudentLastName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.btnRefresh = new Syncfusion.Windows.Forms.ButtonAdv();
            this.txtRoom = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.txtClass = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.Label4 = new System.Windows.Forms.Label();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCancle = new Syncfusion.Windows.Forms.ButtonAdv();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtStudentID = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtRealization = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.Label8 = new System.Windows.Forms.Label();
            this.txtImplementation = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtDetail = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.Label5 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRecorderName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStudentFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStudentLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClass)).BeginInit();
            this.GroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStudentID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRealization)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImplementation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDetail)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.btnDelete.BeforeTouchSize = new System.Drawing.Size(133, 31);
            this.btnDelete.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Roboto Condensed Light", 12F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.IsBackStageButton = false;
            this.btnDelete.Location = new System.Drawing.Point(584, 87);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(133, 31);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "ลบ";
            this.btnDelete.UseVisualStyle = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Roboto Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.ForeColor = System.Drawing.Color.DimGray;
            this.Label11.Location = new System.Drawing.Point(292, 16);
            this.Label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(80, 28);
            this.Label11.TabIndex = 78;
            this.Label11.Text = "วันที่บันทึก";
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.DateTimePicker.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.DateTimePicker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DateTimePicker.CalendarForeColor = System.Drawing.SystemColors.ControlText;
            this.DateTimePicker.CalendarSize = new System.Drawing.Size(189, 176);
            this.DateTimePicker.DropDownImage = null;
            this.DateTimePicker.DropDownNormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.DateTimePicker.DropDownPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.DateTimePicker.DropDownSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(191)))), ((int)(((byte)(237)))));
            this.DateTimePicker.EnableNullDate = false;
            this.DateTimePicker.FlatDropButton = true;
            this.DateTimePicker.Font = new System.Drawing.Font("Roboto Light", 12.75F);
            this.DateTimePicker.Location = new System.Drawing.Point(297, 49);
            this.DateTimePicker.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.DateTimePicker.MinValue = new System.DateTime(((long)(0)));
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.NoneButtonVisible = false;
            this.DateTimePicker.Size = new System.Drawing.Size(276, 31);
            this.DateTimePicker.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.DateTimePicker.TabIndex = 11;
            this.DateTimePicker.UseCurrentCulture = true;
            this.DateTimePicker.Value = new System.DateTime(2017, 6, 25, 2, 46, 3, 613);
            // 
            // txtRecorderName
            // 
            this.txtRecorderName.BackColor = System.Drawing.Color.SeaShell;
            this.txtRecorderName.BeforeTouchSize = new System.Drawing.Size(274, 155);
            this.txtRecorderName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.txtRecorderName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRecorderName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRecorderName.Font = new System.Drawing.Font("Roboto Light", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecorderName.ForeColor = System.Drawing.Color.DimGray;
            this.txtRecorderName.Location = new System.Drawing.Point(580, 49);
            this.txtRecorderName.Margin = new System.Windows.Forms.Padding(5);
            this.txtRecorderName.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtRecorderName.MinimumSize = new System.Drawing.Size(8, 4);
            this.txtRecorderName.Name = "txtRecorderName";
            this.txtRecorderName.ReadOnly = true;
            this.txtRecorderName.Size = new System.Drawing.Size(274, 30);
            this.txtRecorderName.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtRecorderName.TabIndex = 12;
            this.txtRecorderName.Text = "txtRecorderName";
            this.txtRecorderName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRecorderName.WordWrap = false;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Roboto Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.ForeColor = System.Drawing.Color.DimGray;
            this.Label10.Location = new System.Drawing.Point(576, 16);
            this.Label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(62, 28);
            this.Label10.TabIndex = 77;
            this.Label10.Text = "ผู้บันทึก";
            // 
            // cbType
            // 
            this.cbType.BackColor = System.Drawing.Color.White;
            this.cbType.BeforeTouchSize = new System.Drawing.Size(265, 31);
            this.cbType.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.cbType.Font = new System.Drawing.Font("Roboto Light", 12.5F);
            this.cbType.ForeColor = System.Drawing.Color.DimGray;
            this.cbType.Location = new System.Drawing.Point(22, 49);
            this.cbType.MetroBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(265, 31);
            this.cbType.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.cbType.TabIndex = 10;
            this.cbType.Text = "เลือก";
            this.cbType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cbType.UseMetroButtonColor = true;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Roboto Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.ForeColor = System.Drawing.Color.DimGray;
            this.Label9.Location = new System.Drawing.Point(17, 19);
            this.Label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(60, 28);
            this.Label9.TabIndex = 75;
            this.Label9.Text = "ประเภท";
            // 
            // btnSave
            // 
            this.btnSave.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.btnSave.BeforeTouchSize = new System.Drawing.Size(133, 31);
            this.btnSave.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.btnSave.Enabled = false;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Roboto Condensed Light", 12F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.IsBackStageButton = false;
            this.btnSave.Location = new System.Drawing.Point(445, 87);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(133, 31);
            this.btnSave.TabIndex = 13;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "บันทึก";
            this.btnSave.UseVisualStyle = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtStudentFirstName
            // 
            this.txtStudentFirstName.BackColor = System.Drawing.Color.SeaShell;
            this.txtStudentFirstName.BeforeTouchSize = new System.Drawing.Size(274, 155);
            this.txtStudentFirstName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.txtStudentFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStudentFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStudentFirstName.Font = new System.Drawing.Font("Roboto Light", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentFirstName.ForeColor = System.Drawing.Color.DimGray;
            this.txtStudentFirstName.Location = new System.Drawing.Point(177, 52);
            this.txtStudentFirstName.Margin = new System.Windows.Forms.Padding(5);
            this.txtStudentFirstName.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtStudentFirstName.MinimumSize = new System.Drawing.Size(8, 4);
            this.txtStudentFirstName.Name = "txtStudentFirstName";
            this.txtStudentFirstName.ReadOnly = true;
            this.txtStudentFirstName.Size = new System.Drawing.Size(247, 30);
            this.txtStudentFirstName.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtStudentFirstName.TabIndex = 3;
            this.txtStudentFirstName.TabStop = false;
            this.txtStudentFirstName.Text = "txtStudentFirstName";
            this.txtStudentFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStudentFirstName.WordWrap = false;
            // 
            // txtStudentLastName
            // 
            this.txtStudentLastName.BackColor = System.Drawing.Color.SeaShell;
            this.txtStudentLastName.BeforeTouchSize = new System.Drawing.Size(274, 155);
            this.txtStudentLastName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.txtStudentLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStudentLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStudentLastName.Font = new System.Drawing.Font("Roboto Light", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentLastName.ForeColor = System.Drawing.Color.DimGray;
            this.txtStudentLastName.Location = new System.Drawing.Point(434, 52);
            this.txtStudentLastName.Margin = new System.Windows.Forms.Padding(5);
            this.txtStudentLastName.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtStudentLastName.MinimumSize = new System.Drawing.Size(8, 4);
            this.txtStudentLastName.Name = "txtStudentLastName";
            this.txtStudentLastName.ReadOnly = true;
            this.txtStudentLastName.Size = new System.Drawing.Size(251, 30);
            this.txtStudentLastName.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtStudentLastName.TabIndex = 4;
            this.txtStudentLastName.TabStop = false;
            this.txtStudentLastName.Text = "txtStudentLastName";
            this.txtStudentLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStudentLastName.WordWrap = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.BeforeTouchSize = new System.Drawing.Size(25, 30);
            this.btnRefresh.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Roboto Condensed Light", 12F);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.IsBackStageButton = false;
            this.btnRefresh.Location = new System.Drawing.Point(142, 52);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(25, 30);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.TabStop = false;
            this.btnRefresh.UseVisualStyle = true;
            // 
            // txtRoom
            // 
            this.txtRoom.BackColor = System.Drawing.Color.SeaShell;
            this.txtRoom.BeforeTouchSize = new System.Drawing.Size(274, 155);
            this.txtRoom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.txtRoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRoom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRoom.Font = new System.Drawing.Font("Roboto Light", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoom.ForeColor = System.Drawing.Color.DimGray;
            this.txtRoom.Location = new System.Drawing.Point(779, 52);
            this.txtRoom.Margin = new System.Windows.Forms.Padding(5);
            this.txtRoom.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtRoom.MinimumSize = new System.Drawing.Size(8, 4);
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.ReadOnly = true;
            this.txtRoom.Size = new System.Drawing.Size(75, 30);
            this.txtRoom.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtRoom.TabIndex = 6;
            this.txtRoom.TabStop = false;
            this.txtRoom.Text = "txtRoom";
            this.txtRoom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRoom.WordWrap = false;
            // 
            // txtClass
            // 
            this.txtClass.BackColor = System.Drawing.Color.SeaShell;
            this.txtClass.BeforeTouchSize = new System.Drawing.Size(274, 155);
            this.txtClass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.txtClass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtClass.Font = new System.Drawing.Font("Roboto Light", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClass.ForeColor = System.Drawing.Color.DimGray;
            this.txtClass.Location = new System.Drawing.Point(695, 52);
            this.txtClass.Margin = new System.Windows.Forms.Padding(5);
            this.txtClass.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtClass.MinimumSize = new System.Drawing.Size(8, 4);
            this.txtClass.Name = "txtClass";
            this.txtClass.ReadOnly = true;
            this.txtClass.Size = new System.Drawing.Size(75, 30);
            this.txtClass.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtClass.TabIndex = 5;
            this.txtClass.TabStop = false;
            this.txtClass.Text = "txtClass";
            this.txtClass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtClass.WordWrap = false;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Roboto Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.DimGray;
            this.Label4.Location = new System.Drawing.Point(774, 20);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(38, 28);
            this.Label4.TabIndex = 75;
            this.Label4.Text = "ห้อง";
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.btnDelete);
            this.GroupBox3.Controls.Add(this.Label11);
            this.GroupBox3.Controls.Add(this.DateTimePicker);
            this.GroupBox3.Controls.Add(this.txtRecorderName);
            this.GroupBox3.Controls.Add(this.Label10);
            this.GroupBox3.Controls.Add(this.cbType);
            this.GroupBox3.Controls.Add(this.Label9);
            this.GroupBox3.Controls.Add(this.btnCancle);
            this.GroupBox3.Controls.Add(this.btnSave);
            this.GroupBox3.Location = new System.Drawing.Point(2, 346);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(865, 127);
            this.GroupBox3.TabIndex = 3;
            this.GroupBox3.TabStop = false;
            // 
            // btnCancle
            // 
            this.btnCancle.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnCancle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.btnCancle.BeforeTouchSize = new System.Drawing.Size(133, 31);
            this.btnCancle.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.btnCancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancle.Font = new System.Drawing.Font("Roboto Condensed Light", 12F);
            this.btnCancle.ForeColor = System.Drawing.Color.White;
            this.btnCancle.IsBackStageButton = false;
            this.btnCancle.Location = new System.Drawing.Point(723, 87);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(133, 31);
            this.btnCancle.TabIndex = 15;
            this.btnCancle.TabStop = false;
            this.btnCancle.Text = "ยกเลิก";
            this.btnCancle.UseVisualStyle = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Roboto Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.DimGray;
            this.Label3.Location = new System.Drawing.Point(688, 20);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(32, 28);
            this.Label3.TabIndex = 73;
            this.Label3.Text = "ชั้น";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Roboto Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.DimGray;
            this.Label1.Location = new System.Drawing.Point(172, 19);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(31, 28);
            this.Label1.TabIndex = 69;
            this.Label1.Text = "ชื่อ";
            // 
            // txtStudentID
            // 
            this.txtStudentID.BackColor = System.Drawing.Color.White;
            this.txtStudentID.BeforeTouchSize = new System.Drawing.Size(274, 155);
            this.txtStudentID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.txtStudentID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStudentID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStudentID.Font = new System.Drawing.Font("Roboto Light", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentID.ForeColor = System.Drawing.Color.DimGray;
            this.txtStudentID.Location = new System.Drawing.Point(11, 52);
            this.txtStudentID.Margin = new System.Windows.Forms.Padding(5);
            this.txtStudentID.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtStudentID.MinimumSize = new System.Drawing.Size(8, 4);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(136, 30);
            this.txtStudentID.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtStudentID.TabIndex = 1;
            this.txtStudentID.Text = "txtStudentID";
            this.txtStudentID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStudentID.WordWrap = false;
            this.txtStudentID.TextChanged += new System.EventHandler(this.txtStudentID_TextChanged);
            this.txtStudentID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStudentID_KeyPress);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Roboto Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor = System.Drawing.Color.DimGray;
            this.Label7.Location = new System.Drawing.Point(6, 19);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(96, 28);
            this.Label7.TabIndex = 67;
            this.Label7.Text = "รหัสประจำตัว";
            // 
            // txtRealization
            // 
            this.txtRealization.BackColor = System.Drawing.Color.White;
            this.txtRealization.BeforeTouchSize = new System.Drawing.Size(274, 155);
            this.txtRealization.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.txtRealization.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRealization.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRealization.Font = new System.Drawing.Font("Roboto Light", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRealization.ForeColor = System.Drawing.Color.DimGray;
            this.txtRealization.Location = new System.Drawing.Point(581, 53);
            this.txtRealization.Margin = new System.Windows.Forms.Padding(5);
            this.txtRealization.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtRealization.MinimumSize = new System.Drawing.Size(8, 4);
            this.txtRealization.Multiline = true;
            this.txtRealization.Name = "txtRealization";
            this.txtRealization.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRealization.Size = new System.Drawing.Size(276, 155);
            this.txtRealization.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtRealization.TabIndex = 9;
            this.txtRealization.Text = "txtRealization";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Roboto Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.ForeColor = System.Drawing.Color.DimGray;
            this.Label8.Location = new System.Drawing.Point(576, 20);
            this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(124, 28);
            this.Label8.TabIndex = 79;
            this.Label8.Text = "ผลการดำเนินการ";
            // 
            // txtImplementation
            // 
            this.txtImplementation.BackColor = System.Drawing.Color.White;
            this.txtImplementation.BeforeTouchSize = new System.Drawing.Size(274, 155);
            this.txtImplementation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.txtImplementation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtImplementation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtImplementation.Font = new System.Drawing.Font("Roboto Light", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImplementation.ForeColor = System.Drawing.Color.DimGray;
            this.txtImplementation.Location = new System.Drawing.Point(297, 53);
            this.txtImplementation.Margin = new System.Windows.Forms.Padding(5);
            this.txtImplementation.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtImplementation.MinimumSize = new System.Drawing.Size(8, 4);
            this.txtImplementation.Multiline = true;
            this.txtImplementation.Name = "txtImplementation";
            this.txtImplementation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtImplementation.Size = new System.Drawing.Size(274, 155);
            this.txtImplementation.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtImplementation.TabIndex = 8;
            this.txtImplementation.Text = "txtImplementation";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Roboto Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.Color.DimGray;
            this.Label6.Location = new System.Drawing.Point(292, 20);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(105, 28);
            this.Label6.TabIndex = 77;
            this.Label6.Text = "การดำเนินการ";
            // 
            // txtDetail
            // 
            this.txtDetail.BackColor = System.Drawing.Color.White;
            this.txtDetail.BeforeTouchSize = new System.Drawing.Size(274, 155);
            this.txtDetail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.txtDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDetail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDetail.Font = new System.Drawing.Font("Roboto Light", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetail.ForeColor = System.Drawing.Color.DimGray;
            this.txtDetail.Location = new System.Drawing.Point(13, 53);
            this.txtDetail.Margin = new System.Windows.Forms.Padding(5);
            this.txtDetail.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtDetail.MinimumSize = new System.Drawing.Size(8, 4);
            this.txtDetail.Multiline = true;
            this.txtDetail.Name = "txtDetail";
            this.txtDetail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDetail.Size = new System.Drawing.Size(274, 155);
            this.txtDetail.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtDetail.TabIndex = 7;
            this.txtDetail.Text = "txtDetail";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Roboto Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.DimGray;
            this.Label5.Location = new System.Drawing.Point(8, 20);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(84, 28);
            this.Label5.TabIndex = 75;
            this.Label5.Text = "รายละเอียด";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.txtRealization);
            this.GroupBox1.Controls.Add(this.Label8);
            this.GroupBox1.Controls.Add(this.txtImplementation);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Controls.Add(this.txtDetail);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Location = new System.Drawing.Point(2, 116);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(865, 224);
            this.GroupBox1.TabIndex = 2;
            this.GroupBox1.TabStop = false;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Roboto Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.DimGray;
            this.Label2.Location = new System.Drawing.Point(429, 20);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(68, 28);
            this.Label2.TabIndex = 71;
            this.Label2.Text = "นามสกุล";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.txtStudentFirstName);
            this.GroupBox2.Controls.Add(this.txtStudentLastName);
            this.GroupBox2.Controls.Add(this.btnRefresh);
            this.GroupBox2.Controls.Add(this.txtRoom);
            this.GroupBox2.Controls.Add(this.txtClass);
            this.GroupBox2.Controls.Add(this.Label4);
            this.GroupBox2.Controls.Add(this.Label3);
            this.GroupBox2.Controls.Add(this.Label2);
            this.GroupBox2.Controls.Add(this.Label1);
            this.GroupBox2.Controls.Add(this.txtStudentID);
            this.GroupBox2.Controls.Add(this.Label7);
            this.GroupBox2.Location = new System.Drawing.Point(2, 10);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(865, 100);
            this.GroupBox2.TabIndex = 1;
            this.GroupBox2.TabStop = false;
            // 
            // frmBehaviorDetail
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
            this.ClientSize = new System.Drawing.Size(869, 482);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.GroupBox2);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.MetroColor = System.Drawing.Color.Transparent;
            this.MinimizeBox = false;
            this.Name = "frmBehaviorDetail";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "รายละเอียดพฤติกรรม";
            this.Load += new System.EventHandler(this.frmBehaviorDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRecorderName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStudentFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStudentLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClass)).EndInit();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStudentID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRealization)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImplementation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDetail)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label9;
        private Syncfusion.Windows.Forms.ButtonAdv btnRefresh;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.GroupBox GroupBox2;
        protected Syncfusion.Windows.Forms.ButtonAdv btnDelete;
        protected Syncfusion.Windows.Forms.Tools.DateTimePickerAdv DateTimePicker;
        protected Syncfusion.Windows.Forms.Tools.TextBoxExt txtRecorderName;
        protected Syncfusion.Windows.Forms.Tools.ComboBoxAdv cbType;
        protected Syncfusion.Windows.Forms.ButtonAdv btnSave;
        protected Syncfusion.Windows.Forms.Tools.TextBoxExt txtStudentFirstName;
        protected Syncfusion.Windows.Forms.Tools.TextBoxExt txtStudentLastName;
        protected Syncfusion.Windows.Forms.Tools.TextBoxExt txtRoom;
        protected Syncfusion.Windows.Forms.Tools.TextBoxExt txtClass;
        protected Syncfusion.Windows.Forms.ButtonAdv btnCancle;
        protected Syncfusion.Windows.Forms.Tools.TextBoxExt txtStudentID;
        protected Syncfusion.Windows.Forms.Tools.TextBoxExt txtRealization;
        protected Syncfusion.Windows.Forms.Tools.TextBoxExt txtImplementation;
        protected Syncfusion.Windows.Forms.Tools.TextBoxExt txtDetail;
    }
}