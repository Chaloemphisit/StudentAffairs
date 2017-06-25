#region Copyright Syncfusion Inc. 2001 - 2017
// Copyright Syncfusion Inc. 2001 - 2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using StudentAffairs.Module;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Grid.Grouping;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace StudentAffairs.formData {
    public partial class frmBehaviorList : Syncfusion.Windows.Forms.MetroForm {
        public frmBehaviorList() {
            InitializeComponent();
            
        }

        private void frmBehaviorList_Load(object sender, EventArgs e) {
            RetrieveData();
        }

        private void InitGridGroup() {
            //---------------------------------------------------------------------------------------
            // Grid Stacked Header Descriptor

                    // Add any initialization after the InitializeComponent() call.
                    GridStackedHeaderDescriptor shd1 = new GridStackedHeaderDescriptor("header1", "ข้อมูลทั้่วไป");
                    GridStackedHeaderDescriptor shd2 = new GridStackedHeaderDescriptor("header2", "พฤติกรรม");

                    shd1.VisibleColumns.AddRange(new GridStackedHeaderVisibleColumnDescriptor[] {
                        new GridStackedHeaderVisibleColumnDescriptor("std_ID"),
                    new GridStackedHeaderVisibleColumnDescriptor("std_FirstName"),
                    new GridStackedHeaderVisibleColumnDescriptor("std_LastName"),
                    new GridStackedHeaderVisibleColumnDescriptor("std_Class"),
                    new GridStackedHeaderVisibleColumnDescriptor("std_Room")
                    });

                    shd2.VisibleColumns.AddRange(new GridStackedHeaderVisibleColumnDescriptor[] {
                        new GridStackedHeaderVisibleColumnDescriptor("BehaviorDetail"),
                    new GridStackedHeaderVisibleColumnDescriptor("Implementation"),
                    new GridStackedHeaderVisibleColumnDescriptor("Realization"),
                    new GridStackedHeaderVisibleColumnDescriptor("Type"),
                    new GridStackedHeaderVisibleColumnDescriptor("CreateAt"),
                    new GridStackedHeaderVisibleColumnDescriptor("UpdateAt"),
                    new GridStackedHeaderVisibleColumnDescriptor("RecorderName")
                    });

                    GridStackedHeaderRowDescriptor shrd = new GridStackedHeaderRowDescriptor("Row1", new GridStackedHeaderDescriptor[] { shd1, shd2 });

                    // Step 4: Add the GridStackedRowHeaderDescriptor collection to the StackedHeaderRows
                    GGC.TableDescriptor.StackedHeaderRows.Add(shrd);

                    // Display Stacked Headers 
                    GGC.TopLevelGroupOptions.ShowStackedHeaders = true;
            //---------------------------------------------------------------------------------------

            // Initialize Columns GridGroup

            // Hidden  Column
            GGC.TableDescriptor.VisibleColumns.Remove("RecorderID");
            GGC.TableDescriptor.VisibleColumns.Remove("BehaviorType");
            GGC.TableDescriptor.VisibleColumns.Remove("PK");

            //Using Column Name
            GGC.TableDescriptor.Columns["std_ID"].HeaderText = "รหัสนักเรียน";
            GGC.TableDescriptor.Columns["std_FirstName"].HeaderText = "ชื่อ";
            GGC.TableDescriptor.Columns["std_LastName"].HeaderText = "นามสกุล";
            GGC.TableDescriptor.Columns["std_Class"].HeaderText = "ชั้น";
            GGC.TableDescriptor.Columns["std_Room"].HeaderText = "ห้อง";
            GGC.TableDescriptor.Columns["BehaviorDetail"].HeaderText = "รายละอียด";
            GGC.TableDescriptor.Columns["Implementation"].HeaderText = "การดำเนินการ";
            GGC.TableDescriptor.Columns["Realization"].HeaderText = "ผลการดำเนินการ";
            GGC.TableDescriptor.Columns["Type"].HeaderText = "ประเภท";
            GGC.TableDescriptor.Columns["CreateAt"].HeaderText = "วันที่บันทึก";
            GGC.TableDescriptor.Columns["CreateAt"].Appearance.AnyRecordFieldCell.Format = "dd/MM/yyyy";
            GGC.TableDescriptor.Columns["CreateAt"].Appearance.AnyRecordFieldCell.CellType = GridCellTypeName.TextBox;
            GGC.TableDescriptor.Columns["UpdateAt"].HeaderText = "วันที่แก้ไขล่าสุด";
            GGC.TableDescriptor.Columns["UpdateAt"].Appearance.AnyRecordFieldCell.Format = "dd/MM/yyyy";
            GGC.TableDescriptor.Columns["UpdateAt"].Appearance.AnyRecordFieldCell.CellType = GridCellTypeName.TextBox;
            GGC.TableDescriptor.Columns["RecorderName"].HeaderText = "ผู้บันทึก";


            //GridVerticalAlignment.Middle
            for (int i = 0; i < 15; i++) {
                GGC.TableDescriptor.Columns[i].Appearance.AnyRecordFieldCell.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle;
                GGC.TableDescriptor.Columns[i].AllowGroupByColumn = false;
                // GGC.TableDescriptor.Columns[i].Appearance.AnyRecordFieldCell.AutoSize = AutoSize;
            }


            //Initialize normal GridGrouping

            //Allows GroupDropArea to be visible    
            GGC.ShowGroupDropArea = false;  // Disable

            //Hidden Top Level of Grouping
            GGC.TopLevelGroupOptions.ShowCaption = true;

            //Metro Styles
            GGC.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;

            //Disables editing in GridGroupingControl
            GGC.ActivateCurrentCellBehavior = Syncfusion.Windows.Forms.Grid.GridCellActivateAction.None;

            //Disable Add New
            GGC.TableDescriptor.AllowNew = false;

            //Autofit Columns
            //GGC.AllowProportionalColumnSizing = true;

            //Row Height
            GGC.Table.DefaultRecordRowHeight = 25;
            //
            GGC.Table.DefaultCaptionRowHeight = 25;
            GGC.Table.DefaultColumnHeaderRowHeight = 40; //Columns Header

            //Selection
            GGC.TableOptions.ListBoxSelectionMode = SelectionMode.One;

            //Selection Back color
            GGC.TableOptions.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            ////
            GGC.Appearance.ColumnHeaderCell.TextColor = Color.DarkBlue;

            //Applies back color as LightCyan for alternative records in the Grid.
            GGC.Appearance.AlternateRecordFieldCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(224)))));

            //Disable record preview row 
            GGC.TableOptions.ShowRecordPreviewRow = false;
            //
            //Will enable the Group Header for the top most group.
            GGC.TopLevelGroupOptions.ShowGroupHeader = false; // true

            //Will enable the Group Footer for the group.
            GGC.TopLevelGroupOptions.ShowGroupFooter = true; //true
            //
            GGC.TableOptions.GroupHeaderSectionHeight = 30;
            GGC.TableOptions.GroupFooterSectionHeight = 30;

            //Enabling Readonly for whole Grid
            GGC.TableModel.ReadOnly = true;
        }
        private void RetrieveData(Boolean blnSearch = false) {
            database.Conn = database.ConnectDB();

            database.strSQL =
                "SELECT tblBehavior.PK, tblStudent.std_ID, tblStudent.std_FirstName, tblStudent.std_LastName, " +
                "tblStudent.std_Class, tblStudent.std_Room, tblBehavior.BehaviorDetail, " +
                "tblBehavior.Implementation, tblBehavior.Realization, tblBehaviorType.Type, " +
                "tblBehavior.CreateAt, tblBehavior.UpdateAt, " +
                "[tblTeacher].[TeacherFirstName] + ' ' + [TeacherLastName] AS RecorderName, " +
                "tblBehavior.RecorderID, tblBehavior.BehaviorType FROM tblTeacher " +
                "INNER JOIN (tblStudent INNER JOIN (tblBehaviorType INNER JOIN tblBehavior " +
                "ON tblBehaviorType.BehaviorTypePK = tblBehavior.BehaviorType) " +
                "ON tblStudent.std_ID = tblBehavior.std_ID) " +
                "ON tblTeacher.TeacherID = tblBehavior.RecorderID ";

            // blnSearch = True for Serach

            if (blnSearch) {
                database.strSQL = database.strSQL +
                    " WHERE " +
                    " [std_ID] " + " Like '%" + txtSearch.Text + "%'" + " OR " +
                    " [std_FirstName] " + " Like '%" + txtSearch.Text + "%'" + " OR " +
                    " [std_LastName] " + " Like '%" + txtSearch.Text + "%'";// +
                    //" ORDER BY [std_ID] ";
            } else {
                database.strSQL = database.strSQL + " ORDER BY tblBehavior.PK ";
            }
            //MessageBox.Show(database.strSQL);

            //
            if (database.Conn.State == ConnectionState.Closed) { database.Conn.Open(); }
            DataTable dt = new DataTable();
            database.DA = new OleDbDataAdapter(database.strSQL, database.Conn);
            database.DA.Fill(dt);
            GGC.DataSource = dt;
            lblRecordCount.Text = ("[Total: " + (dt.Rows.Count) + " Records.]");
            database.Conn.Close();

            //
            InitGridGroup();
            //
            txtSearch.Clear();
            this.WindowState = FormWindowState.Maximized;
        }

    }
}
