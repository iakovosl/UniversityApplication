using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Base;

namespace WindowsFormsApp1.Impl {
    public class University: Person {
        public List<Student> Students { get; set; }
        public List<Professor> Professors { get; set; }
        public List<Course> Courses { get; set; }
        public List<Schedule> ScheduleList { get; set; }
        public BindingList<Schedule> ScheduledCourses { get; set; }

        public University() {
            Students = new List<Student>();
            Professors = new List<Professor>();
            Courses = new List<Course>();
            ScheduleList = new List<Schedule>();
            ScheduledCourses = new BindingList<Schedule>();
        }
        public void DataUniversity() {
            Courses.Add(new Course() {
                Code = "1",
                Subject = "Quantum Physics",
                Category = CourseCategoryEnum.Physics, 
                Hours = 100
            });

            Courses.Add(new Course() {
                Code = "2",
                Subject = "Electo-Dynamics",
                Category = CourseCategoryEnum.Physics, // physics ?
                Hours = 50
            });

            Courses.Add(new Course() {
                Code = "3",
                Subject = "Basic Chemistry",
                Category = CourseCategoryEnum.Chemistry, 
                Hours = 50
            });

            Courses.Add(new Course() {
                Code = "4",
                Subject = "Financial II",
                Category = CourseCategoryEnum.Financial, 
                Hours = 50
            });

            Courses.Add(new Course() {
                Code = "5",
                Subject = "Mathematics I",
                Category = CourseCategoryEnum.Mathematics, 
                Hours = 50
            });

            Students.Add(new Student() {
               
                Name = "Fotis",
                Surname = "Chrysoulas",
                RegistrationNumber = 1234,
                Age = 21,
                CanLearn = new List<CourseCategoryEnum>() { CourseCategoryEnum.Chemistry, CourseCategoryEnum.Financial }
            });


            Students.Add(new Student() {
                
                Name = "Dimitris",
                Surname = "Raptodimos",
                RegistrationNumber = 1235,
                Age = 23,
                CanLearn = new List<CourseCategoryEnum>() { CourseCategoryEnum.Physics, CourseCategoryEnum.Financial }
            });

            Professors.Add(new Professor() {
                Name = "Maria",
                Surname = "Papadopoulou",
                Age = 33,
                Rank = "1",
                CanTeach = new List<CourseCategoryEnum>() { CourseCategoryEnum.Chemistry, CourseCategoryEnum.Financial }
            });

            Professors.Add(new Professor() { 
                Name = "Eirini",
                Surname = "Papa",
                Age = 36,
                Rank = "2",
                CanTeach = new List<CourseCategoryEnum>() { CourseCategoryEnum.Chemistry, CourseCategoryEnum.Financial }
            });

            Professors.Add(new Professor() {
                Name = "Sofia",
                Surname = "Papadopoulou",
                Age = 33,
                Rank = "3",
                CanTeach = new List<CourseCategoryEnum>() { CourseCategoryEnum.Chemistry, CourseCategoryEnum.Financial }
            });

            Professors.Add(new Professor() {
                Name = "Nikos",
                Surname = "Papas",
                Age = 33,
                Rank = "4",
                CanTeach = new List<CourseCategoryEnum>() { CourseCategoryEnum.Chemistry, CourseCategoryEnum.Financial }
            });
        }

        public void AddScheduledCourse(Guid courseID, Guid professorID, Guid studentID, DateTime date, string tutorialTime) {

            string professorName = Professors.FirstOrDefault(x => x.ID == professorID).Name;
            string studentName = Students.FirstOrDefault(x => x.ID == studentID).Name;
            string courseSubject = Courses.FirstOrDefault(x => x.ID == courseID).Subject;
            string professorSurname = Professors.FirstOrDefault(x => x.ID == professorID).Surname;
            string studentSurname = Students.FirstOrDefault(x => x.ID == studentID).Surname;

            Schedule schedule = new Schedule() {
                ProfessorID = professorID,
                ProfessorName = professorName,
                ProfessorSurname = professorSurname,
                StudentID = studentID,
                StudentName = studentName,
                StudentSurname = studentSurname,
                CourseID = courseID,
                CourseSubject = courseSubject,
                CourseTime = tutorialTime,
                Date = date
            };

            ScheduledCourses.Add(schedule);
        }

    }
}
