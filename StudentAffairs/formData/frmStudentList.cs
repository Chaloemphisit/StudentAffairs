#region Copyright Syncfusion Inc. 2001 - 2017
// Copyright Syncfusion Inc. 2001 - 2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using StudentAffairs.Module;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;

using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace StudentAffairs.formData {
    public partial class frmStudentList : Syncfusion.Windows.Forms.MetroForm {

        public static event EventHandler LoadCompleted;

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            this.OnLoadCompleted(EventArgs.Empty);
        }
        protected virtual void OnLoadCompleted(EventArgs e) {
            var handler = LoadCompleted;
            if (handler != null) handler(this, e);
            loadForm.eventCompleted = true;    

        }

        public frmStudentList() {
            frmWait frmWait = new frmWait();
            Thread splashThread = new Thread(new ThreadStart(
                    () => { Application.Run(frmWait); }));
            splashThread.SetApartmentState(ApartmentState.STA);
            splashThread.Start();
            InitializeComponent();
            RetrieveData();
            splashThread.Abort();
        }

        private void frmStudentList_Load(object sender, EventArgs e) {
            
        }


        private void InitGridGroup() {
            // Initialize Columns GridGroup

            // Hidden Primary Key Column
            //TableDescriptor.VisibleColumns.Remove("PrimaryKey");

            //'Using Column Name
            GGC.TableDescriptor.Columns["std_ID"].HeaderText = "รหัสนักเรียน";
            GGC.TableDescriptor.Columns["std_IDCard"].HeaderText = "รหัสประจำตัวประชาชน";
            //GGC.TableDescriptor.VisibleColumns.Remove("std_IDCard");
            GGC.TableDescriptor.Columns["Prefix"].HeaderText = "คำนำหน้า";
            GGC.TableDescriptor.Columns["std_FirstName"].HeaderText = "ชื่อ";
            GGC.TableDescriptor.Columns["std_LastName"].HeaderText = "นามสกุล";
            GGC.TableDescriptor.Columns["Gender"].HeaderText = "เพศ";
            GGC.TableDescriptor.Columns["std_Class"].HeaderText = "ชั้น";
            GGC.TableDescriptor.Columns["std_Room"].HeaderText = "ห้อง";
            GGC.TableDescriptor.Columns["std_Birthday"].HeaderText = "วันเกิด";
            GGC.TableDescriptor.Columns["std_Birthday"].Appearance.AnyRecordFieldCell.Format= "dd/MM/yyyy";
            GGC.TableDescriptor.Columns["std_Birthday"].Appearance.AnyRecordFieldCell.CellType = Text;
            GGC.TableDescriptor.Columns["std_AgeY"].HeaderText = "อายุ";
            GGC.TableDescriptor.VisibleColumns.Remove("std_AgeM");
            GGC.TableDescriptor.Columns["std_Blood"].HeaderText = "หมู่เลือด";
            GGC.TableDescriptor.Columns["std_Ethnicity"].HeaderText = "เชื้อชาติ";
            GGC.TableDescriptor.Columns["std_Nationality"].HeaderText = "สัญชาติ";
            GGC.TableDescriptor.Columns["std_Religion"].HeaderText = "ศาสนา";


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
            GGC.AllowProportionalColumnSizing = true;

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

        void RetrieveData(Boolean blnSearch = false) {
            database.Conn = database.ConnectDB();

            database.strSQL =
                "SELECT tblStudent.std_ID, tblStudent.std_IDCard, tblPrefix.Prefix, tblStudent.std_FirstName, " +
                "tblStudent.std_LastName, tblGender.Gender, tblStudent.std_Class, tblStudent.std_Room, " +
                "tblStudent.std_Birthday, tblStudent.std_AgeY, tblStudent.std_AgeM, tblStudent.std_Blood, " +
                "tblStudent.std_Ethnicity, tblStudent.std_Nationality, tblStudent.std_Religion " +
                "FROM tblPrefix INNER JOIN (tblGender INNER JOIN tblStudent ON tblGender.GenderPK = tblStudent.std_Gender) " +
                "ON tblPrefix.PrefixPK = tblStudent.std_Prefix";

            // blnSearch = True for Serach

            if (blnSearch) {
                database.strSQL = database.strSQL +
                    " WHERE " +
                    " [std_ID] " + " Like '%" + txtSearch.Text + "%'" + " OR " +
                    " [std_IDCard] " + " Like '%" + txtSearch.Text + "%'" + " OR " +
                    " [std_FirstName] " + " Like '%" + txtSearch.Text + "%'" + " OR " +
                    " [std_LastName] " + " Like '%" + txtSearch.Text + "%'" +
                    " ORDER BY std_ID ";
            } else {
                database.strSQL = database.strSQL + " ORDER BY std_ID ";
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

        private void btnRefresh_Click(object sender, EventArgs e) {
            RetrieveData();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e) {
            if (string.IsNullOrWhiteSpace(txtSearch.Text)) {return;}
            // Undesirable characters for the database ex.  ', *or %
            txtSearch.Text = txtSearch.Text.Trim().Replace("\'", "");
            txtSearch.Text = txtSearch.Text.Trim().Replace("%", "");
            txtSearch.Text = txtSearch.Text.Trim().Replace("*", "");

            // RetrieveData(True) It means searching for information.
            if (e.KeyChar == (char)13){
                // No beep.
                e.Handled = true;
                RetrieveData(true);
            }
        }
    }

}
