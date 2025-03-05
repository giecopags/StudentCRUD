namespace StudentCRUD
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.textEditFirstName = new DevExpress.XtraEditors.TextEdit();
            this.textEditMiddleName = new DevExpress.XtraEditors.TextEdit();
            this.textEditLastName = new DevExpress.XtraEditors.TextEdit();
            this.textEditAge = new DevExpress.XtraEditors.TextEdit();
            this.textEditAddress = new DevExpress.XtraEditors.TextEdit();
            this.radioGroupGender = new DevExpress.XtraEditors.RadioGroup();
            this.labelControlFirstName = new DevExpress.XtraEditors.LabelControl();
            this.labelControlMiddleName = new DevExpress.XtraEditors.LabelControl();
            this.labelControlLastName = new DevExpress.XtraEditors.LabelControl();
            this.labelControlAge = new DevExpress.XtraEditors.LabelControl();
            this.labelControlAddress = new DevExpress.XtraEditors.LabelControl();
            this.labelControlGender = new DevExpress.XtraEditors.LabelControl();
            this.textEditContactNumber = new DevExpress.XtraEditors.TextEdit();
            this.labelControlContactNumber = new DevExpress.XtraEditors.LabelControl();
            this.simpleButtonAdd = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonEdit = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonDelete = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlStudent = new DevExpress.XtraGrid.GridControl();
            this.gridViewStudent = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.StudentName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Age = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Gender = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Address = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ContactNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButtonLoad = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditFirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMiddleName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditLastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAge.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupGender.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditContactNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 1;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(746, 32);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // textEditFirstName
            // 
            this.textEditFirstName.Location = new System.Drawing.Point(12, 105);
            this.textEditFirstName.MenuManager = this.ribbonControl1;
            this.textEditFirstName.Name = "textEditFirstName";
            this.textEditFirstName.Size = new System.Drawing.Size(100, 20);
            this.textEditFirstName.TabIndex = 1;
            // 
            // textEditMiddleName
            // 
            this.textEditMiddleName.Location = new System.Drawing.Point(118, 105);
            this.textEditMiddleName.MenuManager = this.ribbonControl1;
            this.textEditMiddleName.Name = "textEditMiddleName";
            this.textEditMiddleName.Size = new System.Drawing.Size(100, 20);
            this.textEditMiddleName.TabIndex = 2;
            // 
            // textEditLastName
            // 
            this.textEditLastName.Location = new System.Drawing.Point(224, 105);
            this.textEditLastName.MenuManager = this.ribbonControl1;
            this.textEditLastName.Name = "textEditLastName";
            this.textEditLastName.Size = new System.Drawing.Size(100, 20);
            this.textEditLastName.TabIndex = 3;
            // 
            // textEditAge
            // 
            this.textEditAge.Location = new System.Drawing.Point(330, 105);
            this.textEditAge.MenuManager = this.ribbonControl1;
            this.textEditAge.Name = "textEditAge";
            this.textEditAge.Size = new System.Drawing.Size(100, 20);
            this.textEditAge.TabIndex = 4;
            // 
            // textEditAddress
            // 
            this.textEditAddress.Location = new System.Drawing.Point(12, 158);
            this.textEditAddress.MenuManager = this.ribbonControl1;
            this.textEditAddress.Name = "textEditAddress";
            this.textEditAddress.Size = new System.Drawing.Size(312, 20);
            this.textEditAddress.TabIndex = 5;
            // 
            // radioGroupGender
            // 
            this.radioGroupGender.Location = new System.Drawing.Point(483, 94);
            this.radioGroupGender.MenuManager = this.ribbonControl1;
            this.radioGroupGender.Name = "radioGroupGender";
            this.radioGroupGender.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.radioGroupGender.Properties.Appearance.Options.UseBackColor = true;
            this.radioGroupGender.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.radioGroupGender.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Male", true, "Male"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Female", true, "Female")});
            this.radioGroupGender.Size = new System.Drawing.Size(120, 42);
            this.radioGroupGender.TabIndex = 6;
            // 
            // labelControlFirstName
            // 
            this.labelControlFirstName.Location = new System.Drawing.Point(12, 86);
            this.labelControlFirstName.Name = "labelControlFirstName";
            this.labelControlFirstName.Size = new System.Drawing.Size(51, 13);
            this.labelControlFirstName.TabIndex = 7;
            this.labelControlFirstName.Text = "First Name";
            // 
            // labelControlMiddleName
            // 
            this.labelControlMiddleName.Location = new System.Drawing.Point(118, 86);
            this.labelControlMiddleName.Name = "labelControlMiddleName";
            this.labelControlMiddleName.Size = new System.Drawing.Size(60, 13);
            this.labelControlMiddleName.TabIndex = 8;
            this.labelControlMiddleName.Text = "Middle Name";
            // 
            // labelControlLastName
            // 
            this.labelControlLastName.Location = new System.Drawing.Point(224, 86);
            this.labelControlLastName.Name = "labelControlLastName";
            this.labelControlLastName.Size = new System.Drawing.Size(50, 13);
            this.labelControlLastName.TabIndex = 9;
            this.labelControlLastName.Text = "Last Name";
            // 
            // labelControlAge
            // 
            this.labelControlAge.Location = new System.Drawing.Point(330, 86);
            this.labelControlAge.Name = "labelControlAge";
            this.labelControlAge.Size = new System.Drawing.Size(19, 13);
            this.labelControlAge.TabIndex = 10;
            this.labelControlAge.Text = "Age";
            // 
            // labelControlAddress
            // 
            this.labelControlAddress.Location = new System.Drawing.Point(12, 139);
            this.labelControlAddress.Name = "labelControlAddress";
            this.labelControlAddress.Size = new System.Drawing.Size(39, 13);
            this.labelControlAddress.TabIndex = 11;
            this.labelControlAddress.Text = "Address";
            // 
            // labelControlGender
            // 
            this.labelControlGender.Location = new System.Drawing.Point(442, 108);
            this.labelControlGender.Name = "labelControlGender";
            this.labelControlGender.Size = new System.Drawing.Size(35, 13);
            this.labelControlGender.TabIndex = 12;
            this.labelControlGender.Text = "Gender";
            // 
            // textEditContactNumber
            // 
            this.textEditContactNumber.Location = new System.Drawing.Point(330, 158);
            this.textEditContactNumber.MenuManager = this.ribbonControl1;
            this.textEditContactNumber.Name = "textEditContactNumber";
            this.textEditContactNumber.Size = new System.Drawing.Size(100, 20);
            this.textEditContactNumber.TabIndex = 13;
            // 
            // labelControlContactNumber
            // 
            this.labelControlContactNumber.Location = new System.Drawing.Point(330, 139);
            this.labelControlContactNumber.Name = "labelControlContactNumber";
            this.labelControlContactNumber.Size = new System.Drawing.Size(78, 13);
            this.labelControlContactNumber.TabIndex = 14;
            this.labelControlContactNumber.Text = "Contact Number";
            // 
            // simpleButtonAdd
            // 
            this.simpleButtonAdd.Location = new System.Drawing.Point(442, 156);
            this.simpleButtonAdd.Name = "simpleButtonAdd";
            this.simpleButtonAdd.Size = new System.Drawing.Size(64, 23);
            this.simpleButtonAdd.TabIndex = 15;
            this.simpleButtonAdd.Text = "ADD";
            this.simpleButtonAdd.Click += new System.EventHandler(this.simpleButtonAdd_Click);
            // 
            // simpleButtonEdit
            // 
            this.simpleButtonEdit.Location = new System.Drawing.Point(512, 156);
            this.simpleButtonEdit.Name = "simpleButtonEdit";
            this.simpleButtonEdit.Size = new System.Drawing.Size(72, 23);
            this.simpleButtonEdit.TabIndex = 16;
            this.simpleButtonEdit.Text = "EDIT";
            // 
            // simpleButtonDelete
            // 
            this.simpleButtonDelete.Location = new System.Drawing.Point(590, 156);
            this.simpleButtonDelete.Name = "simpleButtonDelete";
            this.simpleButtonDelete.Size = new System.Drawing.Size(68, 23);
            this.simpleButtonDelete.TabIndex = 17;
            this.simpleButtonDelete.Text = "DELETE";
            // 
            // gridControlStudent
            // 
            this.gridControlStudent.Location = new System.Drawing.Point(12, 193);
            this.gridControlStudent.MainView = this.gridViewStudent;
            this.gridControlStudent.MenuManager = this.ribbonControl1;
            this.gridControlStudent.Name = "gridControlStudent";
            this.gridControlStudent.Size = new System.Drawing.Size(722, 380);
            this.gridControlStudent.TabIndex = 18;
            this.gridControlStudent.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewStudent});
            // 
            // gridViewStudent
            // 
            this.gridViewStudent.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.StudentName,
            this.Age,
            this.Gender,
            this.Address,
            this.ContactNumber});
            this.gridViewStudent.GridControl = this.gridControlStudent;
            this.gridViewStudent.Name = "gridViewStudent";
            this.gridViewStudent.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewStudent_RowClick);
            // 
            // StudentName
            // 
            this.StudentName.Caption = "Student Name";
            this.StudentName.FieldName = "StudentName";
            this.StudentName.Name = "StudentName";
            this.StudentName.OptionsColumn.AllowEdit = false;
            this.StudentName.OptionsColumn.AllowFocus = false;
            this.StudentName.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.StudentName.Visible = true;
            this.StudentName.VisibleIndex = 0;
            this.StudentName.Width = 163;
            // 
            // Age
            // 
            this.Age.Caption = "Age";
            this.Age.FieldName = "Age";
            this.Age.Name = "Age";
            this.Age.OptionsColumn.AllowEdit = false;
            this.Age.OptionsColumn.AllowFocus = false;
            this.Age.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.Age.Visible = true;
            this.Age.VisibleIndex = 1;
            this.Age.Width = 31;
            // 
            // Gender
            // 
            this.Gender.Caption = "Gender";
            this.Gender.FieldName = "Gender";
            this.Gender.Name = "Gender";
            this.Gender.OptionsColumn.AllowEdit = false;
            this.Gender.OptionsColumn.AllowFocus = false;
            this.Gender.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.Gender.Visible = true;
            this.Gender.VisibleIndex = 2;
            this.Gender.Width = 54;
            // 
            // Address
            // 
            this.Address.Caption = "Address";
            this.Address.FieldName = "Address";
            this.Address.Name = "Address";
            this.Address.OptionsColumn.AllowEdit = false;
            this.Address.OptionsColumn.AllowFocus = false;
            this.Address.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.Address.Visible = true;
            this.Address.VisibleIndex = 3;
            this.Address.Width = 229;
            // 
            // ContactNumber
            // 
            this.ContactNumber.Caption = "Contact Number";
            this.ContactNumber.FieldName = "ContactNumber";
            this.ContactNumber.Name = "ContactNumber";
            this.ContactNumber.OptionsColumn.AllowEdit = false;
            this.ContactNumber.OptionsColumn.AllowFocus = false;
            this.ContactNumber.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.ContactNumber.Visible = true;
            this.ContactNumber.VisibleIndex = 4;
            this.ContactNumber.Width = 244;
            // 
            // simpleButtonLoad
            // 
            this.simpleButtonLoad.Location = new System.Drawing.Point(664, 156);
            this.simpleButtonLoad.Name = "simpleButtonLoad";
            this.simpleButtonLoad.Size = new System.Drawing.Size(70, 23);
            this.simpleButtonLoad.TabIndex = 20;
            this.simpleButtonLoad.Text = "LOAD";
            this.simpleButtonLoad.Click += new System.EventHandler(this.simpleButtonLoad_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 589);
            this.Controls.Add(this.simpleButtonLoad);
            this.Controls.Add(this.gridControlStudent);
            this.Controls.Add(this.simpleButtonDelete);
            this.Controls.Add(this.simpleButtonEdit);
            this.Controls.Add(this.simpleButtonAdd);
            this.Controls.Add(this.labelControlContactNumber);
            this.Controls.Add(this.textEditContactNumber);
            this.Controls.Add(this.labelControlGender);
            this.Controls.Add(this.labelControlAddress);
            this.Controls.Add(this.labelControlAge);
            this.Controls.Add(this.labelControlLastName);
            this.Controls.Add(this.labelControlMiddleName);
            this.Controls.Add(this.labelControlFirstName);
            this.Controls.Add(this.radioGroupGender);
            this.Controls.Add(this.textEditAddress);
            this.Controls.Add(this.textEditAge);
            this.Controls.Add(this.textEditLastName);
            this.Controls.Add(this.textEditMiddleName);
            this.Controls.Add(this.textEditFirstName);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "MainForm";
            this.Ribbon = this.ribbonControl1;
            this.RibbonVisibility = DevExpress.XtraBars.Ribbon.RibbonVisibility.Hidden;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditFirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMiddleName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditLastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAge.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupGender.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditContactNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraEditors.TextEdit textEditFirstName;
        private DevExpress.XtraEditors.TextEdit textEditMiddleName;
        private DevExpress.XtraEditors.TextEdit textEditLastName;
        private DevExpress.XtraEditors.TextEdit textEditAge;
        private DevExpress.XtraEditors.TextEdit textEditAddress;
        private DevExpress.XtraEditors.RadioGroup radioGroupGender;
        private DevExpress.XtraEditors.LabelControl labelControlFirstName;
        private DevExpress.XtraEditors.LabelControl labelControlMiddleName;
        private DevExpress.XtraEditors.LabelControl labelControlLastName;
        private DevExpress.XtraEditors.LabelControl labelControlAge;
        private DevExpress.XtraEditors.LabelControl labelControlAddress;
        private DevExpress.XtraEditors.LabelControl labelControlGender;
        private DevExpress.XtraEditors.TextEdit textEditContactNumber;
        private DevExpress.XtraEditors.LabelControl labelControlContactNumber;
        private DevExpress.XtraEditors.SimpleButton simpleButtonAdd;
        private DevExpress.XtraEditors.SimpleButton simpleButtonEdit;
        private DevExpress.XtraEditors.SimpleButton simpleButtonDelete;
        private DevExpress.XtraGrid.GridControl gridControlStudent;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewStudent;
        private DevExpress.XtraEditors.SimpleButton simpleButtonLoad;
        private DevExpress.XtraGrid.Columns.GridColumn StudentName;
        private DevExpress.XtraGrid.Columns.GridColumn Age;
        private DevExpress.XtraGrid.Columns.GridColumn Gender;
        private DevExpress.XtraGrid.Columns.GridColumn Address;
        private DevExpress.XtraGrid.Columns.GridColumn ContactNumber;
    }
}

