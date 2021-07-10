using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Impl {
    public class University {
        public List<Student> Students { get; set; }
        public List<Professor> Professors { get; set; }
        public List<Course> Courses { get; set; }
        public List<Schedule> ScheduleList { get; set; }

        public University() {
            Students = new List<Student>();
            Professors = new List<Professor>();
            Courses = new List<Course>();
            ScheduleList = new List<Schedule>();
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
                ID = Guid.NewGuid(),
                Name = "Fotis",
                Surname = "Chrysoulas",
                RegistrationNumber = "1234",
                CanLearn = new List<CourseCategoryEnum>() { CourseCategoryEnum.Chemistry, CourseCategoryEnum.Financial }
            });


            Students.Add(new Student() {
                ID = Guid.NewGuid(),
                Name = "Dimitris",
                Surname = "Raptodimos",
                RegistrationNumber = "1235",
                CanLearn = new List<CourseCategoryEnum>() { CourseCategoryEnum.Physics, CourseCategoryEnum.Financial }
            });

            Professors.Add(new Professor() {
                Name = "Maria",
                Surname = "Papadopoulou",
                Rank = "1"
            });


        }
    }
}
