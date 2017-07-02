#region Copyright Syncfusion Inc. 2001 - 2017
// Copyright Syncfusion Inc. 2001 - 2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using StudentAffairs.Module;
using Syncfusion.Grouping;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Grid.Grouping;
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
    public partial class frmUserList : Syncfusion.Windows.Forms.MetroForm {
        private int currentCellIndex=-1;
        frmUserDetail frmUserDetail;

        public frmUserList() {
            frmWait frmWait = new frmWait();
            Thread splashThread = new Thread(new ThreadStart(
                    () => { frmWait.ShowDialog(); }));//Application.Run(frmWait);
            splashThread.SetApartmentState(ApartmentState.MTA);
            splashThread.Start();
            InitializeComponent();
            RetrieveData();
            splashThread.Abort();
        }

        private void frmUserList_Load(object sender, EventArgs e) {

        }

        private void InitGridGroup() {

            // Initialize Columns GridGroup

            // Hidden  Column
            GGC.TableDescriptor.VisibleColumns.Remove("Password");
            GGC.TableDescriptor.VisibleColumns.Remove("RoleID");

            //Using Column Name
            GGC.TableDescriptor.Columns["TeacherID"].HeaderText = "���ʻ�Шӵ��";
            GGC.TableDescriptor.Columns["TeacherFirstName"].HeaderText = "����";
            GGC.TableDescriptor.Columns["TeacherLastName"].HeaderText = "���ʡ��";
            GGC.TableDescriptor.Columns["TeacherRole"].HeaderText = "���˹�";
            GGC.TableDescriptor.Columns["Username"].HeaderText = "���ͼ����";
            GGC.TableDescriptor.Columns["Password"].HeaderText = "Password";
            GGC.TableDescriptor.Columns["RoleDescription"].HeaderText = "�Է�ԡ����ҹ";
            GGC.TableDescriptor.Columns["CreateByID"].HeaderText = "���ҧ��";
            GGC.TableDescriptor.Columns["CreateDate"].HeaderText = "�ѹ������ҧ";
            GGC.TableDescriptor.Columns["UpdateBy"].HeaderText = "�Ѿഷ��";
            GGC.TableDescriptor.Columns["UpdateAt"].HeaderText = "�ѹ����Ѿഷ";


            //GridVerticalAlignment.Middle
            for (int i = 0; i < 10; i++) {
                GGC.TableDescriptor.Columns[i].Appearance.AnyRecordFieldCell.VerticalAlignment = GridVerticalAlignment.Middle;
                GGC.TableDescriptor.Columns[i].AllowGroupByColumn = false;
                // GGC.TableDescriptor.Columns[i].Appearance.AnyRecordFieldCell.AutoSize = AutoSize;
            }


            //Initialize normal GridGrouping

            //Allows GroupDropArea to be visible    
            GGC.ShowGroupDropArea = false;  // Disable

            //Hidden Top Level of Grouping
            GGC.TopLevelGroupOptions.ShowCaption = true;

            //Metro Styles
            GGC.GridVisualStyles = GridVisualStyles.Metro;

            //Disables editing in GridGroupingControl
            GGC.ActivateCurrentCellBehavior = GridCellActivateAction.None;

            //Disable Add New
            GGC.TableDescriptor.AllowNew = false;

            //Autofit Columns
            //GGC.AllowProportionalColumnSizing = true;

            //Column Width
            GGC.TableDescriptor.Columns["TeacherID"].Width = 150;
            GGC.TableDescriptor.Columns["TeacherFirstName"].Width = 200;
            GGC.TableDescriptor.Columns["TeacherLastName"].Width = 200;
            GGC.TableDescriptor.Columns["TeacherRole"].Width = 200;
            GGC.TableDescriptor.Columns["Username"].Width = 150;
            GGC.TableDescriptor.Columns["CreateByID"].Width = 150;
            GGC.TableDescriptor.Columns["UpdateBy"].Width = 150;

            //Row Height
            GGC.Table.DefaultRecordRowHeight = 25;
            //
            GGC.Table.DefaultCaptionRowHeight = 25;
            GGC.Table.DefaultColumnHeaderRowHeight = 40; //Columns Header

            //Selection
            GGC.TableOptions.ListBoxSelectionMode = SelectionMode.One;
            GGC.TableOptions.AllowSelection = GridSelectionFlags.AlphaBlend | GridSelectionFlags.Cell;

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
            GGC.TopLevelGroupOptions.ShowGroupFooter = false; //true
            //
            GGC.TableOptions.GroupHeaderSectionHeight = 30;
            GGC.TableOptions.GroupFooterSectionHeight = 30;

            //Enabling Readonly for whole Grid
            GGC.TableModel.ReadOnly = true;
        }
        public void RetrieveData(Boolean blnSearch = false) {
            database.Conn = database.ConnectDB();

            database.strSQL =
                "SELECT tblTeacher.TeacherID, tblTeacher.TeacherFirstName, tblTeacher.TeacherLastName, "+
                "tblTeacher.TeacherRole, tblUser.Username, tblUser.Password, tblUserRole.RoleID,  " +
                "tblRole.RoleDescription, tblUser.CreateByID, tblUser.CreateDate, tblUser.UpdateBy,  " +
                "tblUser.UpdateAt FROM(tblTeacher INNER JOIN tblUser  " +
                "ON tblTeacher.TeacherID = tblUser.TeacherID) INNER JOIN(tblRole INNER JOIN tblUserRole  " +
                "ON tblRole.RoleID = tblUserRole.RoleID)  " +
                "ON(tblTeacher.TeacherID = tblUserRole.TeacherID)  " +
                "AND(tblUser.TeacherID = tblUserRole.TeacherID)";

            // blnSearch = True for Serach
            if (blnSearch) {
                database.strSQL = database.strSQL +
                    " WHERE " +
                    " [TeacherID] " + " Like '%" + txtSearch.Text + "%'" + " OR " +
                    " [Username] " + " Like '%" + txtSearch.Text + "%'" + " OR " +
                    " [TeacherFirstName] " + " Like '%" + txtSearch.Text + "%'" + " OR " +
                    " [TeacherLastName] " + " Like '%" + txtSearch.Text + "%'";
            } else {
                database.strSQL = database.strSQL + " ORDER BY tblTeacher.TeacherID ";
            }
            //MessageBox(database.strSQL);

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

        private void GGC_TableControlCurrentCellActivated(object sender, GridTableControlEventArgs e) {
            //Notify the double click performed in a cell
            Record rec = GGC.Table.DisplayElements[e.TableControl.CurrentCell.RowIndex].ParentRecord;
            //If(rec) IsNot Nothing Then
            if (rec != null) {
                frmUserDetail.TeacherID = rec.GetValue("TeacherID").ToString();
                currentCellIndex = e.TableControl.CurrentCell.RowIndex;
            }
        }

        private void GGC_TableControlCellDoubleClick(object sender, GridTableControlCellClickEventArgs e) {

            //Notify the double click performed in a cell
            Record rec = GGC.Table.DisplayElements[e.TableControl.CurrentCell.RowIndex].ParentRecord;
            //If(rec) IsNot Nothing Then
            if (rec != null) {
                frmUserDetail = new frmUserDetail();
                frmUserDetail.TeacherID = rec.GetValue("TeacherID").ToString();
                frmUserDetail.ShowDialog();
                RetrieveData();
            }
            RetrieveData();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            new formAuth.frmRegister().ShowDialog();
            RetrieveData();
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            if (currentCellIndex < 0) {
                MessageBoxAdv.Show("��س����͡������㹵��ҧ��͹����¡��!", "��§ҹ�����Դ��Ҵ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                GGC.Focus();
            } else {
                frmUserDetail = new frmUserDetail();
                frmUserDetail.ShowDialog();
                currentCellIndex = -1;
            }
            RetrieveData();
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            if (currentCellIndex < 0) {
                MessageBoxAdv.Show("��س����͡������㹵��ҧ��͹����¡��!", "��§ҹ�����Դ��Ҵ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                GGC.Focus();
            } else {
                frmUserDetail = new frmUserDetail();
                frmUserDetail.deleteData();
                currentCellIndex = -1;
            }
            RetrieveData();
        }

        private void btnRefresh_Click(object sender, EventArgs e) {
            RetrieveData();
        }
    }
}
