
namespace WindowsFormsApp1.WUI {
    partial class DataForm1 {
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
            this.ctrlSchedule = new System.Windows.Forms.ListBox();
            this.ctrlCourseList = new System.Windows.Forms.ListBox();
            this.ctrlStudentList = new System.Windows.Forms.ListBox();
            this.ctrlProfessorList = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.dateTimePickerDays = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.initializeDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.addToScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.loadDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.ctrlStudentdataGridView = new System.Windows.Forms.DataGridView();
            this.ctrlProfessordataGridView = new System.Windows.Forms.DataGridView();
            this.ctrlCoursedataGridView = new System.Windows.Forms.DataGridView();
            this.ctrlScheduledataGridView = new System.Windows.Forms.DataGridView();
            this.btnAddNewSchedule = new System.Windows.Forms.Button();
            this.dateTimePickerHours = new System.Windows.Forms.ComboBox();
            this.lblStudent = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.iDDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professorSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseSubjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rankDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrationNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlStudentdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlProfessordataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCoursedataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlScheduledataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlSchedule
            // 
            this.ctrlSchedule.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlSchedule.FormattingEnabled = true;
            this.ctrlSchedule.ItemHeight = 25;
            this.ctrlSchedule.Location = new System.Drawing.Point(1193, 407);
            this.ctrlSchedule.Name = "ctrlSchedule";
            this.ctrlSchedule.Size = new System.Drawing.Size(50, 54);
            this.ctrlSchedule.TabIndex = 7;
            this.ctrlSchedule.SelectedIndexChanged += new System.EventHandler(this.ctrlSchedule_SelectedIndexChanged);
            // 
            // ctrlCourseList
            // 
            this.ctrlCourseList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlCourseList.FormattingEnabled = true;
            this.ctrlCourseList.ItemHeight = 21;
            this.ctrlCourseList.Location = new System.Drawing.Point(0, 321);
            this.ctrlCourseList.Name = "ctrlCourseList";
            this.ctrlCourseList.Size = new System.Drawing.Size(80, 67);
            this.ctrlCourseList.TabIndex = 6;
            // 
            // ctrlStudentList
            // 
            this.ctrlStudentList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlStudentList.FormattingEnabled = true;
            this.ctrlStudentList.ItemHeight = 21;
            this.ctrlStudentList.Location = new System.Drawing.Point(1163, 355);
            this.ctrlStudentList.Name = "ctrlStudentList";
            this.ctrlStudentList.Size = new System.Drawing.Size(80, 46);
            this.ctrlStudentList.TabIndex = 5;
            // 
            // ctrlProfessorList
            // 
            this.ctrlProfessorList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlProfessorList.FormattingEnabled = true;
            this.ctrlProfessorList.ItemHeight = 21;
            this.ctrlProfessorList.Location = new System.Drawing.Point(0, 404);
            this.ctrlProfessorList.Name = "ctrlProfessorList";
            this.ctrlProfessorList.Size = new System.Drawing.Size(80, 46);
            this.ctrlProfessorList.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(0, 476);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(61, 32);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(977, 355);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(120, 39);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "Remove Selected Record";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // dateTimePickerDays
            // 
            this.dateTimePickerDays.Location = new System.Drawing.Point(12, 60);
            this.dateTimePickerDays.Name = "dateTimePickerDays";
            this.dateTimePickerDays.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDays.TabIndex = 10;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1243, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.initializeDataToolStripMenuItem,
            this.toolStripMenuItem1,
            this.addToScheduleToolStripMenuItem,
            this.toolStripMenuItem2,
            this.loadDataToolStripMenuItem,
            this.saveDataToolStripMenuItem});
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.mainToolStripMenuItem.Text = "Main";
            // 
            // initializeDataToolStripMenuItem
            // 
            this.initializeDataToolStripMenuItem.Name = "initializeDataToolStripMenuItem";
            this.initializeDataToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.initializeDataToolStripMenuItem.Text = "Data Initialization";
            this.initializeDataToolStripMenuItem.Click += new System.EventHandler(this.initializeDataToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(168, 6);
            // 
            // addToScheduleToolStripMenuItem
            // 
            this.addToScheduleToolStripMenuItem.Name = "addToScheduleToolStripMenuItem";
            this.addToScheduleToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.addToScheduleToolStripMenuItem.Text = "Add To Schedule...";
            this.addToScheduleToolStripMenuItem.Click += new System.EventHandler(this.addToScheduleToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(168, 6);
            // 
            // loadDataToolStripMenuItem
            // 
            this.loadDataToolStripMenuItem.Name = "loadDataToolStripMenuItem";
            this.loadDataToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.loadDataToolStripMenuItem.Text = "Load Data";
            this.loadDataToolStripMenuItem.Click += new System.EventHandler(this.loadDataToolStripMenuItem_Click);
            // 
            // saveDataToolStripMenuItem
            // 
            this.saveDataToolStripMenuItem.Name = "saveDataToolStripMenuItem";
            this.saveDataToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.saveDataToolStripMenuItem.Text = "Save Data";
            this.saveDataToolStripMenuItem.Click += new System.EventHandler(this.saveDataToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(994, 407);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 32);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(1176, 467);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(67, 32);
            this.btnLoad.TabIndex = 17;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // ctrlStudentdataGridView
            // 
            this.ctrlStudentdataGridView.AllowUserToAddRows = false;
            this.ctrlStudentdataGridView.AllowUserToDeleteRows = false;
            this.ctrlStudentdataGridView.AutoGenerateColumns = false;
            this.ctrlStudentdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ctrlStudentdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.registrationNumberDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn});
            this.ctrlStudentdataGridView.DataSource = this.studentBindingSource;
            this.ctrlStudentdataGridView.Location = new System.Drawing.Point(0, 134);
            this.ctrlStudentdataGridView.Name = "ctrlStudentdataGridView";
            this.ctrlStudentdataGridView.ReadOnly = true;
            this.ctrlStudentdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ctrlStudentdataGridView.Size = new System.Drawing.Size(406, 150);
            this.ctrlStudentdataGridView.TabIndex = 18;
            // 
            // ctrlProfessordataGridView
            // 
            this.ctrlProfessordataGridView.AllowUserToAddRows = false;
            this.ctrlProfessordataGridView.AllowUserToDeleteRows = false;
            this.ctrlProfessordataGridView.AutoGenerateColumns = false;
            this.ctrlProfessordataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ctrlProfessordataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1,
            this.surnameDataGridViewTextBoxColumn1,
            this.ageDataGridViewTextBoxColumn1,
            this.rankDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn1});
            this.ctrlProfessordataGridView.DataSource = this.professorBindingSource;
            this.ctrlProfessordataGridView.Location = new System.Drawing.Point(412, 134);
            this.ctrlProfessordataGridView.Name = "ctrlProfessordataGridView";
            this.ctrlProfessordataGridView.ReadOnly = true;
            this.ctrlProfessordataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ctrlProfessordataGridView.Size = new System.Drawing.Size(422, 150);
            this.ctrlProfessordataGridView.TabIndex = 19;
            // 
            // ctrlCoursedataGridView
            // 
            this.ctrlCoursedataGridView.AllowUserToAddRows = false;
            this.ctrlCoursedataGridView.AllowUserToDeleteRows = false;
            this.ctrlCoursedataGridView.AutoGenerateColumns = false;
            this.ctrlCoursedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ctrlCoursedataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeDataGridViewTextBoxColumn,
            this.subjectDataGridViewTextBoxColumn,
            this.hoursDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn2});
            this.ctrlCoursedataGridView.DataSource = this.courseBindingSource;
            this.ctrlCoursedataGridView.Location = new System.Drawing.Point(800, 134);
            this.ctrlCoursedataGridView.Name = "ctrlCoursedataGridView";
            this.ctrlCoursedataGridView.ReadOnly = true;
            this.ctrlCoursedataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ctrlCoursedataGridView.Size = new System.Drawing.Size(443, 150);
            this.ctrlCoursedataGridView.TabIndex = 20;
            // 
            // ctrlScheduledataGridView
            // 
            this.ctrlScheduledataGridView.AllowUserToAddRows = false;
            this.ctrlScheduledataGridView.AllowUserToDeleteRows = false;
            this.ctrlScheduledataGridView.AutoGenerateColumns = false;
            this.ctrlScheduledataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ctrlScheduledataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn3,
            this.courseIDDataGridViewTextBoxColumn,
            this.professorIDDataGridViewTextBoxColumn,
            this.studentIDDataGridViewTextBoxColumn,
            this.professorNameDataGridViewTextBoxColumn,
            this.professorSurnameDataGridViewTextBoxColumn,
            this.studentNameDataGridViewTextBoxColumn,
            this.studentSurnameDataGridViewTextBoxColumn,
            this.courseSubjectDataGridViewTextBoxColumn,
            this.courseTimeDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.ctrlScheduledataGridView.DataSource = this.scheduleBindingSource;
            this.ctrlScheduledataGridView.Location = new System.Drawing.Point(220, 321);
            this.ctrlScheduledataGridView.Name = "ctrlScheduledataGridView";
            this.ctrlScheduledataGridView.ReadOnly = true;
            this.ctrlScheduledataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ctrlScheduledataGridView.Size = new System.Drawing.Size(751, 187);
            this.ctrlScheduledataGridView.TabIndex = 21;
            // 
            // btnAddNewSchedule
            // 
            this.btnAddNewSchedule.Location = new System.Drawing.Point(355, 56);
            this.btnAddNewSchedule.Name = "btnAddNewSchedule";
            this.btnAddNewSchedule.Size = new System.Drawing.Size(143, 32);
            this.btnAddNewSchedule.TabIndex = 22;
            this.btnAddNewSchedule.Text = "Add New Schedule";
            this.btnAddNewSchedule.UseVisualStyleBackColor = true;
            this.btnAddNewSchedule.Click += new System.EventHandler(this.btnAddNewSchedule_Click_1);
            // 
            // dateTimePickerHours
            // 
            this.dateTimePickerHours.FormattingEnabled = true;
            this.dateTimePickerHours.Items.AddRange(new object[] {
            "08:00-10:00",
            "10:00-12:00",
            "12:00-14:00",
            "14:00-16:00",
            "16:00-18:00",
            "18:00-20:00"});
            this.dateTimePickerHours.Location = new System.Drawing.Point(228, 60);
            this.dateTimePickerHours.Name = "dateTimePickerHours";
            this.dateTimePickerHours.Size = new System.Drawing.Size(121, 21);
            this.dateTimePickerHours.TabIndex = 23;
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblStudent.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblStudent.Location = new System.Drawing.Point(566, 101);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(92, 18);
            this.lblStudent.TabIndex = 24;
            this.lblStudent.Text = "Professors";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(138, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 18);
            this.label7.TabIndex = 25;
            this.label7.Text = "Students";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Location = new System.Drawing.Point(956, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 18);
            this.label8.TabIndex = 26;
            this.label8.Text = "Courses";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Location = new System.Drawing.Point(542, 300);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 18);
            this.label9.TabIndex = 27;
            this.label9.Text = "Schedules";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(490, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(331, 25);
            this.label6.TabIndex = 28;
            this.label6.Text = "University Courses Scheduler ";
            // 
            // iDDataGridViewTextBoxColumn3
            // 
            this.iDDataGridViewTextBoxColumn3.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn3.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn3.Name = "iDDataGridViewTextBoxColumn3";
            this.iDDataGridViewTextBoxColumn3.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn3.Visible = false;
            // 
            // courseIDDataGridViewTextBoxColumn
            // 
            this.courseIDDataGridViewTextBoxColumn.DataPropertyName = "CourseID";
            this.courseIDDataGridViewTextBoxColumn.HeaderText = "CourseID";
            this.courseIDDataGridViewTextBoxColumn.Name = "courseIDDataGridViewTextBoxColumn";
            this.courseIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.courseIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // professorIDDataGridViewTextBoxColumn
            // 
            this.professorIDDataGridViewTextBoxColumn.DataPropertyName = "ProfessorID";
            this.professorIDDataGridViewTextBoxColumn.HeaderText = "ProfessorID";
            this.professorIDDataGridViewTextBoxColumn.Name = "professorIDDataGridViewTextBoxColumn";
            this.professorIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.professorIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            this.studentIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // professorNameDataGridViewTextBoxColumn
            // 
            this.professorNameDataGridViewTextBoxColumn.DataPropertyName = "ProfessorName";
            this.professorNameDataGridViewTextBoxColumn.HeaderText = "Professor Name";
            this.professorNameDataGridViewTextBoxColumn.Name = "professorNameDataGridViewTextBoxColumn";
            this.professorNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // professorSurnameDataGridViewTextBoxColumn
            // 
            this.professorSurnameDataGridViewTextBoxColumn.DataPropertyName = "ProfessorSurname";
            this.professorSurnameDataGridViewTextBoxColumn.HeaderText = "Professor Surname";
            this.professorSurnameDataGridViewTextBoxColumn.Name = "professorSurnameDataGridViewTextBoxColumn";
            this.professorSurnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentNameDataGridViewTextBoxColumn
            // 
            this.studentNameDataGridViewTextBoxColumn.DataPropertyName = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.HeaderText = "Student Name";
            this.studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
            this.studentNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentSurnameDataGridViewTextBoxColumn
            // 
            this.studentSurnameDataGridViewTextBoxColumn.DataPropertyName = "StudentSurname";
            this.studentSurnameDataGridViewTextBoxColumn.HeaderText = "Student Surname";
            this.studentSurnameDataGridViewTextBoxColumn.Name = "studentSurnameDataGridViewTextBoxColumn";
            this.studentSurnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseSubjectDataGridViewTextBoxColumn
            // 
            this.courseSubjectDataGridViewTextBoxColumn.DataPropertyName = "CourseSubject";
            this.courseSubjectDataGridViewTextBoxColumn.HeaderText = "Course Subject";
            this.courseSubjectDataGridViewTextBoxColumn.Name = "courseSubjectDataGridViewTextBoxColumn";
            this.courseSubjectDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseTimeDataGridViewTextBoxColumn
            // 
            this.courseTimeDataGridViewTextBoxColumn.DataPropertyName = "CourseTime";
            this.courseTimeDataGridViewTextBoxColumn.HeaderText = "Course Time";
            this.courseTimeDataGridViewTextBoxColumn.Name = "courseTimeDataGridViewTextBoxColumn";
            this.courseTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // scheduleBindingSource
            // 
            this.scheduleBindingSource.DataSource = typeof(WindowsFormsApp1.Impl.Schedule);
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subjectDataGridViewTextBoxColumn
            // 
            this.subjectDataGridViewTextBoxColumn.DataPropertyName = "Subject";
            this.subjectDataGridViewTextBoxColumn.HeaderText = "Subject";
            this.subjectDataGridViewTextBoxColumn.Name = "subjectDataGridViewTextBoxColumn";
            this.subjectDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hoursDataGridViewTextBoxColumn
            // 
            this.hoursDataGridViewTextBoxColumn.DataPropertyName = "Hours";
            this.hoursDataGridViewTextBoxColumn.HeaderText = "Hours";
            this.hoursDataGridViewTextBoxColumn.Name = "hoursDataGridViewTextBoxColumn";
            this.hoursDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDDataGridViewTextBoxColumn2
            // 
            this.iDDataGridViewTextBoxColumn2.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn2.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn2.Name = "iDDataGridViewTextBoxColumn2";
            this.iDDataGridViewTextBoxColumn2.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn2.Visible = false;
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataSource = typeof(WindowsFormsApp1.Impl.Course);
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // surnameDataGridViewTextBoxColumn1
            // 
            this.surnameDataGridViewTextBoxColumn1.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn1.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn1.Name = "surnameDataGridViewTextBoxColumn1";
            this.surnameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ageDataGridViewTextBoxColumn1
            // 
            this.ageDataGridViewTextBoxColumn1.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn1.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn1.Name = "ageDataGridViewTextBoxColumn1";
            this.ageDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // rankDataGridViewTextBoxColumn
            // 
            this.rankDataGridViewTextBoxColumn.DataPropertyName = "Rank";
            this.rankDataGridViewTextBoxColumn.HeaderText = "Rank";
            this.rankDataGridViewTextBoxColumn.Name = "rankDataGridViewTextBoxColumn";
            this.rankDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // professorBindingSource
            // 
            this.professorBindingSource.DataSource = typeof(WindowsFormsApp1.Impl.Professor);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // registrationNumberDataGridViewTextBoxColumn
            // 
            this.registrationNumberDataGridViewTextBoxColumn.DataPropertyName = "RegistrationNumber";
            this.registrationNumberDataGridViewTextBoxColumn.HeaderText = "RegistrationNumber";
            this.registrationNumberDataGridViewTextBoxColumn.Name = "registrationNumberDataGridViewTextBoxColumn";
            this.registrationNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(WindowsFormsApp1.Impl.Student);
            // 
            // DataForm1
            // 
            this.ClientSize = new System.Drawing.Size(1243, 547);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblStudent);
            this.Controls.Add(this.dateTimePickerHours);
            this.Controls.Add(this.btnAddNewSchedule);
            this.Controls.Add(this.ctrlScheduledataGridView);
            this.Controls.Add(this.ctrlCoursedataGridView);
            this.Controls.Add(this.ctrlProfessordataGridView);
            this.Controls.Add(this.ctrlStudentdataGridView);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dateTimePickerDays);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.ctrlSchedule);
            this.Controls.Add(this.ctrlCourseList);
            this.Controls.Add(this.ctrlStudentList);
            this.Controls.Add(this.ctrlProfessorList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DataForm1";
            this.Load += new System.EventHandler(this.DataForm1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlStudentdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlProfessordataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCoursedataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlScheduledataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.professorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        
        private System.Windows.Forms.Button button6;
 
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
  
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListBox ctrlSchedule;
        private System.Windows.Forms.ListBox ctrlCourseList;
        private System.Windows.Forms.ListBox ctrlStudentList;
        private System.Windows.Forms.ListBox ctrlProfessorList;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DateTimePicker dateTimePickerDays;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem initializeDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addToScheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem loadDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridView ctrlStudentdataGridView;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.DataGridView ctrlProfessordataGridView;
        private System.Windows.Forms.BindingSource professorBindingSource;
        private System.Windows.Forms.DataGridView ctrlCoursedataGridView;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private System.Windows.Forms.DataGridView ctrlScheduledataGridView;
        private System.Windows.Forms.Button btnAddNewSchedule;
        private System.Windows.Forms.ComboBox dateTimePickerHours;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn professorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn calendarDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource scheduleBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn professorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn professorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn professorSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseSubjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrationNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rankDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label6;
    }
}