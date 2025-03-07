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
using DevExpress.XtraEditors;

namespace StudentCRUD
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private List<Models.Student> students = new List<Models.Student>();
        private int editingStudentIndex = -1;
        public MainForm()
        {
            InitializeComponent();
            gridViewStudent.RowClick += gridViewStudent_RowClick;
        }

        private void simpleButtonAdd_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                Models.Student student = new Models.Student();
                student.FirstName = textEditFirstName.Text;
                student.MiddleName = textEditMiddleName.Text;
                student.LastName = textEditLastName.Text;
                student.Age = int.Parse(textEditAge.Text); // Ensure age is a valid integer
                student.Address = textEditAddress.Text;
                var selectedGender = radioGroupGender.Properties.Items[radioGroupGender.SelectedIndex].Description;
                student.Gender = selectedGender;
                student.ContactNumber = textEditContactNumber.Text;

                if (editingStudentIndex == -1)
                {
                    students.Add(student);  //Add the student to the list
                }
                else
                {
                    students[editingStudentIndex] = student;  //Update the existing student in the list
                    editingStudentIndex = -1;
                }

                EmptyTextEdit();
                gridControlStudent.RefreshDataSource();
            }
            else
            {
                MessageBox.Show("Please fill in all required fields with valid values.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButtonLoad_Click(object sender, EventArgs e)
        {
            GetStudents();
        }

        private void gridViewStudent_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            editingStudentIndex = e.RowHandle;

            textEditFirstName.Text = Convert.ToString(gridViewStudent.GetFocusedRowCellValue("FirstName"));
            textEditMiddleName.Text = Convert.ToString(gridViewStudent.GetFocusedRowCellValue("MiddleName"));
            textEditLastName.Text = Convert.ToString(gridViewStudent.GetFocusedRowCellValue("LastName"));
            textEditContactNumber.Text = Convert.ToString(gridViewStudent.GetFocusedRowCellValue("ContactNumber"));
            textEditAddress.Text = Convert.ToString(gridViewStudent.GetFocusedRowCellValue("Address"));
            textEditAge.Text = Convert.ToString(gridViewStudent.GetFocusedRowCellValue("Age"));
        }

        private void simpleButtonEdit_Click(object sender, EventArgs e)
        {
            if (editingStudentIndex != -1 && ValidateInputs())
            {
                Models.Student student = students[editingStudentIndex];
                student.FirstName = textEditFirstName.Text;
                student.MiddleName = textEditMiddleName.Text;
                student.LastName = textEditLastName.Text;
                student.Age = int.Parse(textEditAge.Text); // Ensure age is a valid integer
                student.Address = textEditAddress.Text;
                var selectedGender = radioGroupGender.Properties.Items[radioGroupGender.SelectedIndex].Description;
                student.Gender = selectedGender;
                student.ContactNumber = textEditContactNumber.Text;

                gridControlStudent.RefreshDataSource();
                EmptyTextEdit();
                editingStudentIndex = -1;
            }
            else
            {
                XtraMessageBox.Show("Please fill in all required fields with valid values.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButtonDelete_Click(object sender, EventArgs e)
        {
            if (editingStudentIndex != -1)
            {
                students.RemoveAt(editingStudentIndex);
                gridControlStudent.RefreshDataSource();
                EmptyTextEdit();
                editingStudentIndex = -1;
            }
        }

        #region Methods
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

        private bool ValidateInputs()
        {
            bool isValid = !string.IsNullOrWhiteSpace(textEditFirstName.Text) &&
                           !string.IsNullOrWhiteSpace(textEditLastName.Text) &&
                           !string.IsNullOrWhiteSpace(textEditAddress.Text) &&
                           !string.IsNullOrWhiteSpace(textEditContactNumber.Text);

            if (isValid && int.TryParse(textEditAge.Text, out int age))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}
