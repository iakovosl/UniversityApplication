using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using WindowsFormsApp1.Impl;

namespace WindowsFormsApp1.WUI {

    public partial class DataForm1 : Form {

        private University UniversityApp = new University();

        //private string _jsonFile = "Data.json";
        private const string _JsonFile = "UniData111.json";
        public List<Form> OpenForms { get; set; }
        public object EditObject { get; set; }

        public DataForm1() {
            InitializeComponent();
        }

        #region old code
        private void DataForm_Load(object sender, EventArgs e) {

            // todo : load data on enter!
           
        }

        private void loadDataToolStripMenuItem_Click(object sender, EventArgs e) {

            JavaScriptSerializer r = new JavaScriptSerializer();

            UniversityApp = r.Deserialize<University>(File.ReadAllText("Data.json"));

            foreach (Student student in UniversityApp.Students) {
                list1.Items.Add(student.Name + " " + student.Surname);
            }

            for (int i = 0; i < UniversityApp.Courses.Count - 1; i++) {

                listBox1.Items.Add(UniversityApp.Courses[i].Code + "--" + UniversityApp.Courses[i].Subject);
            }


            foreach (Professor professor in UniversityApp.Professors) {
                list3.Items.Add(string.Format("{0}  {1}", professor.Name, professor.Surname));
            }
        }

        private void saveDataToolStripMenuItem_Click(object sender, EventArgs e) {
            JavaScriptSerializer save_Serializer = new JavaScriptSerializer();

            File.WriteAllText("Data.json", save_Serializer.Serialize(UniversityApp));
        }
        #endregion

        #region new code
        private void DataForm1_Load(object sender, EventArgs e) {

            // todo : load data on enter!
        }

      
        private void UniversityDataInitialization() {
            UniversityApp = new University();
            UniversityApp.DataUniversity();
            RefreshViews();
        }
        private void RefreshViews() {
            foreach (Student student in UniversityApp.Students) {
                list1.Items.Add(student.Name + " " + student.Surname);
            }

            foreach (Course course in UniversityApp.Courses) {
                listBox1.Items.Add(course.Code + "--" + course.Subject);
            }


            foreach (Professor professor in UniversityApp.Professors) {

                list3.Items.Add(string.Format("{0}  {1}", professor.Name, professor.Surname));
            }

        }

        private void button9_Click(object sender, EventArgs e) {

            JavaScriptSerializer GG = new JavaScriptSerializer();

            UniversityApp = GG.Deserialize<University>(File.ReadAllText("Data.json"));

            foreach (Student student in UniversityApp.Students) {
                list1.Items.Add(student.Name + " " + student.Surname);
            }

            for (int i = 0; i < UniversityApp.Courses.Count - 1; i++) {

                listBox1.Items.Add(UniversityApp.Courses[i].Code + "--" + UniversityApp.Courses[i].Subject);
            }

            // we do a loop
            foreach (Professor professor in UniversityApp.Professors) {
                // we add to the list
                list3.Items.Add(string.Format("{0}  {1}", professor.Name, professor.Surname));
            }

        }

        private void button10_Click(object sender, EventArgs e) {
            JavaScriptSerializer ff = new JavaScriptSerializer();

            File.WriteAllText("Data.json", ff.Serialize(UniversityApp));
        }



        public void validate_professorCourse_with_studentCourse() { 
        
            //TODO: ???

        }

        #endregion

        private void button11_Click(object sender, EventArgs e) {

            

            //UniversityApp.run_once();

            foreach (Student student in UniversityApp.Students) {
                list1.Items.Add(student.Name + " " + student.Surname);
            }

            foreach (Course course in UniversityApp.Courses) {
                listBox1.Items.Add(course.Code + "--" + course.Subject);
            }


            foreach (Professor cc1 in UniversityApp.Professors) {

                list3.Items.Add(string.Format("{0}  {1}", cc1.Name, cc1.Surname));
            }

            //should run only once!
            button11.Hide();
        }

        private void addToScheduleToolStripMenuItem_Click(object sender, EventArgs e) {

            // todo : display on a grid??

            // todo: add exception handling?
                UniversityApp.ScheduleList.Add(new Schedule() { 
                    Course = listBox1.SelectedItem.ToString(), Student = list1.SelectedItem.ToString()
                        , Professor = list3.SelectedItem.ToString(), Calendar = dateTimePicker2.Value });

                ctrlSchedule.Items.Clear();
                foreach (var schedulelist in UniversityApp.ScheduleList) {

                    ctrlSchedule.Items.Add(
                        schedulelist.Calendar + " " +
                        schedulelist.Course + " " +
                        schedulelist.Student + " " +
                        schedulelist.Professor);

                }
        
        }

        private void ctrlSchedule_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void button8_Click(object sender, EventArgs e) {

        }

        private void initializeDataToolStripMenuItem_Click(object sender, EventArgs e) {
            UniversityDataInitialization();

        }

        private void btnAdd_Click(object sender, EventArgs e) {
            AddNewSchedule();

        }

        private void AddNewSchedule() {
            try {

                // TODO: 1. CANNOT ADD SAME STUDENT + PROFESSOR IN SAME DATE & HOUR

                // TODO: 2. EACH STUDENT CANNOT HAVE MORE THAN 3 COURSES PER DAY!

                // TODO: 3. A PROFESSOR CANNOT TEACH MORE THAN 4 COURSES PER DAY AND 40 COURSES PER WEEK

                UniversityApp.ScheduleList.Add(new Schedule() { Course = listBox1.SelectedItem.ToString(), Student = list1.SelectedItem.ToString(), Professor = list3.SelectedItem.ToString(), Calendar = dateTimePicker2.Value });

                ctrlSchedule.Items.Clear();
                foreach (var AA in UniversityApp.ScheduleList) {

                    ctrlSchedule.Items.Add(AA.Calendar + " | " + AA.Course + " | " + AA.Student + " | " + AA.Professor);

                }
            }
            catch {

            }
            finally {
                MessageBox.Show("all ok!");

            }
        }

        private void btnSave_Click(object sender, EventArgs e) {
            // JsonController json = new JsonController(_JsonFile);
            //  json.SerializeToJson(UniversityApp);
            JavaScriptSerializer save_Serializer = new JavaScriptSerializer();

            File.WriteAllText("UniData111.json", save_Serializer.Serialize(UniversityApp));

        }

        private void btnLoad_Click(object sender, EventArgs e) {
            // UniversityApp = (new JsonController(_JsonFile)).DeserializeFromJson();
            // RefreshViews();
            JavaScriptSerializer r = new JavaScriptSerializer();

            UniversityApp = r.Deserialize<University>(File.ReadAllText("UniData111.json"));

            foreach (Schedule schedule in UniversityApp.ScheduleList) {
                ctrlSchedule.Items.Add(schedule.Student + " " + schedule.Professor + " " +schedule.Course + " " +schedule.Calendar);
            }
        }
    }
}

