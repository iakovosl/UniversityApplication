using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using WindowsFormsApp1.Impl;
using System.Linq;
using System.ComponentModel;

namespace WindowsFormsApp1.WUI {

    public partial class DataForm1 : Form {

        private University UniversityApp = new University();

        //private string _jsonFile = "Data.json";
        private const string _JsonFile = "UniData22.json";
        public List<Form> OpenForms { get; set; }
        public object EditObject { get; set; }
        public BindingList<Schedule> ScheduledCourses { get; set; }

        public DataForm1() {
            InitializeComponent();
        }

       
        private void DataForm_Load(object sender, EventArgs e) {
            

            // todo : load data on enter!

        }

        private void loadDataToolStripMenuItem_Click(object sender, EventArgs e) {
            serialize();
        }

        private void saveDataToolStripMenuItem_Click(object sender, EventArgs e) {
            saveDataToJSON();
        }
        

        #region new code
       


        private void UniversityDataInitialization() {
            //UniversityApp = new University();
           // UniversityApp.DataUniversity();
           // RefreshViews();
        }
       
        public void validate_professorCourse_with_studentCourse() {}

        #endregion
        private void ctrlSchedule_SelectedIndexChanged(object sender, EventArgs e) {}

      

        private void initializeDataToolStripMenuItem_Click(object sender, EventArgs e) {
            UniversityDataInitialization();
         }

        private void btnAdd_Click(object sender, EventArgs e) {
            AddNewSchedule();

        }

        private void btnSave_Click(object sender, EventArgs e) {
            // JsonController json = new JsonController(_JsonFile);
            //  json.SerializeToJson(UniversityApp);
            JavaScriptSerializer save_Serializer = new JavaScriptSerializer();

            File.WriteAllText("UniData22.json", save_Serializer.Serialize(UniversityApp));

        }
        private void DataForm1_Load(object sender, EventArgs e) {
            ctrlProfessorList.Visible = false;
            ctrlStudentList.Visible = false;
            ctrlCourseList.Visible = false;
            ctrlSchedule.Visible = false;
            button11.Visible = false;
            btnLoad.Visible = false;

            button9.Visible = false;
            button10.Visible = false;

            btnAdd.Visible = false;
            // todo : load data on enter!
            LoadUniversityData();


            ctrlProfessordataGridView.DataSource = UniversityApp.Professors;
            ctrlStudentdataGridView.DataSource = UniversityApp.Students;
            ctrlCoursedataGridView.DataSource = UniversityApp.Courses;
        }

        private void btnLoad_Click(object sender, EventArgs e) {
            // UniversityApp = (new JsonController(_JsonFile)).DeserializeFromJson();
            // RefreshViews();
            JavaScriptSerializer r = new JavaScriptSerializer();

            UniversityApp = r.Deserialize<University>(File.ReadAllText("UniData111.json"));

            foreach (Schedule schedule in UniversityApp.ScheduleList) {
                ctrlSchedule.Items.Add(schedule.Student + " " + schedule.Professor + " " + schedule.Course + " " + schedule.Calendar);
            }
        }


        private void btnAddNewSchedule_Click(object sender, EventArgs e) {

        }

         //1. CANNOT ADD SAME STUDENT + PROFESSOR IN SAME DATE & HOUR
        public bool StudentAvailabilityValidation(string tutorialTime, DateTime calendar, Guid studentID) {
            IEnumerable<Schedule> studentSchedule = UniversityApp.ScheduledCourses.Where(x => x.StudentID == studentID);
            foreach (Schedule schedule in studentSchedule) {
                if (schedule.Date == calendar.Date) {
                    if (schedule.CourseTime == tutorialTime) {
                        MessageBox.Show("Selected Student is in another course in selected hour");
                        return false;
                    }
                }
            }
            return true;
        }

        //  2. EACH STUDENT CANNOT HAVE MORE THAN 3 COURSES PER DAY!
        public bool StudentCoursesValidation(DateTime calendar, Guid studentID) {
            var studentSchedule = UniversityApp.ScheduledCourses.Where(x => x.StudentID == studentID);
            var countCourses = studentSchedule.Count(x => x.Date == calendar.Date);
            if (countCourses >= 3) {
                MessageBox.Show("Selected student cannot have more than 3 courses per day!");
                return false;
            }
            return true;
        }

        //3. A PROFESSOR CANNOT TEACH MORE THAN 4 COURSES PER DAY AND 40 COURSES PER WEEK
        public bool ProfessorCoursesValidation(DateTime calendar, Guid professorID) {
            var professorSchedule = UniversityApp.ScheduledCourses.Where(x => x.ProfessorID == professorID);
            var countCourses = professorSchedule.Count(x => x.Date == calendar.Date);
            if (countCourses >= 4) {
                MessageBox.Show("Selected Professor cannot teach more than 4 courses per day!");
                return false;
            }
            return true;
        }

        //Check if professor is in another course same time.
        public bool ProfessorAvailabilityValidation(string tutorialTime, DateTime calendar, Guid professorID) {
            IEnumerable<Schedule> professorSchedule = UniversityApp.ScheduledCourses.Where(x => x.ProfessorID == professorID);
            foreach (Schedule schedule in professorSchedule) {
                if (schedule.Date == calendar.Date) {
                    if (schedule.CourseTime == tutorialTime) {
                        MessageBox.Show("Selected Professor is in another scheduled course in selected hour");
                        return false;
                    }
                }
            }
            return true;
        }
              // Display on a grid
    private void LoadUniversityData() {
            //load data from University class to object
            UniversityApp.DataUniversity(); 
            //populate University Data
            PopulateUniversityDataColumns();
            foreach (Professor professor in UniversityApp.Professors) {
                // Add professors data to list
                ctrlProfessorList.Items.Add($"{professor.ID}\t{professor.Name}\t{professor.Surname}\t{professor.Age}\t{professor.Rank}");
            }
            foreach (Student student in UniversityApp.Students) {
                // Add students data to list
                ctrlStudentList.Items.Add($"{student.ID}\t{student.Name}\t{student.Surname}\t{student.Age}\t{student.RegistrationNumber}");
            }
            foreach (Course course in UniversityApp.Courses) {
                //Add courses data to list
                ctrlCourseList.Items.Add($"{course.ID}\t{course.Code}\t{course.Subject}\t{course.Hours}");
            }
        }

        //Populate University data in Columns
        private void PopulateUniversityDataColumns() {
            ctrlProfessorList.Items.Add(String.Format("Name", "Surname", "Age", "Rank"));
            ctrlStudentList.Items.Add(String.Format( "Name", "Surname", "Age", "RegNumber"));
            ctrlCourseList.Items.Add(String.Format( "Code", "Subject", "Hours"));
        }
       
        private void btnAddNewSchedule_Click_1(object sender, EventArgs e) {
            //get the selected cells in a DataGridView control
            //get the selected rows in a DataGridView control
            DataGridViewSelectedRowCollection selectedProfessorItem = ctrlProfessordataGridView.SelectedRows;
            DataGridViewSelectedRowCollection selectedStudentItem = ctrlStudentdataGridView.SelectedRows;
            DataGridViewSelectedRowCollection selectedCourseItem = ctrlCoursedataGridView.SelectedRows;
            //Data grid view selected cell value ID
            var professorID = (Guid)selectedProfessorItem[0].Cells[4].Value;
            var studentID = (Guid)selectedStudentItem[0].Cells[4].Value;
            var courseID = (Guid)selectedCourseItem[0].Cells[4].Value;

            dateTimePickerDays.CustomFormat = "dd/MM/yyyy";

            DateTime calendar = dateTimePickerDays.Value;

            string courseTime = dateTimePickerHours.Text;

            if (string.IsNullOrEmpty(courseTime)) {
                MessageBox.Show("Please choose a Course Time first! ");
                return;
            }

            if (StudentCoursesValidation(calendar, studentID) == false) {
                return;
            }
            else if (ProfessorCoursesValidation(calendar, professorID) == false) {
                return;
            }
            else if (StudentAvailabilityValidation(courseTime, calendar, studentID) == false) {
                return;
            }
            else if (ProfessorAvailabilityValidation(courseTime, calendar, professorID) == false) {
                return;
            }

            //Adding new scheduled course in grid
            UniversityApp.AddScheduledCourse(courseID, professorID, studentID, calendar.Date, courseTime); 
            //View data to schedule Grid
            ctrlScheduledataGridView.DataSource = UniversityApp.ScheduledCourses;  

            // TODO: 3. A PROFESSOR CANNOT TEACH MORE THAN 4 COURSES PER DAY AND 40 COURSES PER WEEK

        }

        private void RemoveButton() {
            // int rowIndex = ctrlScheduledataGridView.CurrentCell.RowIndex;
            // ctrlScheduledataGridView.Rows.RemoveAt(rowIndex);
            foreach (DataGridViewRow row in ctrlScheduledataGridView.SelectedRows) {
                ctrlScheduledataGridView.Rows.Remove(row);
            }
        }


        #region methods
        private void scheduleBindingSource_CurrentChanged(object sender, EventArgs e) {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {

        }

        private void btnRemove_Click(object sender, EventArgs e) {
            RemoveButton();
        }

       
        private void serialize() {

            JavaScriptSerializer r = new JavaScriptSerializer();

            UniversityApp = r.Deserialize<University>(File.ReadAllText("Data.json"));

            foreach (Student student in UniversityApp.Students) {
                ctrlStudentList.Items.Add(student.Name + " " + student.Surname);
            }

            for (int i = 0; i < UniversityApp.Courses.Count - 1; i++) {

                ctrlCourseList.Items.Add(UniversityApp.Courses[i].Code + "--" + UniversityApp.Courses[i].Subject);
            }


            foreach (Professor professor in UniversityApp.Professors) {
                ctrlProfessorList.Items.Add(string.Format("{0}  {1}", professor.Name, professor.Surname));
            }
        }
        private void saveDataToJSON() {
            JavaScriptSerializer save_Serializer = new JavaScriptSerializer();

            File.WriteAllText("UniData21.json", save_Serializer.Serialize(UniversityApp));
        }

        private void RefreshViews() {
            foreach (Student student in UniversityApp.Students) {
                ctrlProfessorList.Items.Add(student.Name + " " + student.Surname);
            }

            foreach (Course course in UniversityApp.Courses) {
                ctrlStudentList.Items.Add(course.Code + "--" + course.Subject);
            }


            foreach (Professor professor in UniversityApp.Professors) {

                ctrlCourseList.Items.Add(string.Format("{0}  {1}", professor.Name, professor.Surname));
            }

        }

        private void addToScheduleToolStripMenuItem_Click(object sender, EventArgs e) {

            // todo : display on a grid??

            // todo: add exception handling?
            UniversityApp.ScheduleList.Add(new Schedule() {
                Student = ctrlStudentList.SelectedItem.ToString(),
                Professor = ctrlProfessorList.SelectedItem.ToString(),
                Course = ctrlCourseList.SelectedItem.ToString(),
                Calendar = dateTimePickerDays.Value
            });

            ctrlSchedule.Items.Clear();
            foreach (var schedulelist in UniversityApp.ScheduleList) {

                ctrlSchedule.Items.Add(
                    schedulelist.Calendar + " " +
                    schedulelist.Course + " " +
                    schedulelist.Student + " " +
                    schedulelist.Professor);

            }

        }
        private void AddNewSchedule() {
            try {
                UniversityApp.ScheduleList.Add(new Schedule() { Course = ctrlStudentList.SelectedItem.ToString(), Student = ctrlProfessorList.SelectedItem.ToString(), Professor = ctrlCourseList.SelectedItem.ToString(), Calendar = dateTimePickerDays.Value });

                ctrlSchedule.Items.Clear();
                foreach (var AA in UniversityApp.ScheduleList) {

                    ctrlSchedule.Items.Add(AA.Calendar + " | " + AA.Course + " | " + AA.Student + " | " + AA.Professor);

                }
            }
            catch {

            }
            finally {
                MessageBox.Show("The record succesfully added");

            }
        }
        #endregion
    }
}

