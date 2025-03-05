using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Dapper;

namespace StudentCRUD
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private List<Models.Student> students = new List<Models.Student>();
        public MainForm()
        {
            InitializeComponent();

            gridViewStudent.RowClick += gridViewStudent_RowClick;
        }

        private void simpleButtonAdd_Click(object sender, EventArgs e)
        {
            Models.Student student = new Models.Student();
                student.FirstName = textEditFirstName.Text;
                student.MiddleName = textEditMiddleName.Text;
                student.LastName = textEditLastName.Text;
                student.Age = Convert.ToInt32(textEditAge.Text);
                student.Address = textEditAddress.Text;
                var selectedGender = radioGroupGender.Properties.Items[radioGroupGender.SelectedIndex].Description;
                student.Gender = selectedGender;
                student.ContactNumber = textEditContactNumber.Text;

            students.Add(student);  //Add the student to the list

            EmptyTextEdit();

            gridControlStudent.RefreshDataSource();
        }

        public List<Models.Student> GetStudents()
        {
            gridControlStudent.DataSource = students;
            gridViewStudent.Columns["StudentName"].Visible = true;
            return students;
        }

        private void EmptyTextEdit()
        {
            textEditFirstName.Text = string.Empty;
            textEditMiddleName.Text = string.Empty;
            textEditLastName.Text = string.Empty;
            textEditAge.Text = string.Empty;
            textEditAddress.Text = string.Empty;
            textEditContactNumber.Text = string.Empty;
        }

        private void simpleButtonLoad_Click(object sender, EventArgs e)
        {
            GetStudents();
        }

        private void gridViewStudent_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            textEditFirstName.Text = Convert.ToString(gridViewStudent.GetFocusedRowCellValue("FirstName"));
            textEditMiddleName.Text = Convert.ToString(gridViewStudent.GetFocusedRowCellValue("MiddleName"));
            textEditLastName.Text = Convert.ToString(gridViewStudent.GetFocusedRowCellValue("LastName"));
            textEditContactNumber.Text = Convert.ToString(gridViewStudent.GetFocusedRowCellValue("ContactNumber"));
            textEditAddress.Text = Convert.ToString(gridViewStudent.GetFocusedRowCellValue("Address"));
            textEditAge.Text = Convert.ToString(gridViewStudent.GetFocusedRowCellValue("Age"));
        }
    }
}
