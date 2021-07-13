using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Base;

namespace WindowsFormsApp1.Impl {
   public class Student: Person {
        // PROPERTIES
        public int RegistrationNumber { get; set; }
        public List<CourseCategoryEnum> CanLearn { get; set; }
        public string Learn => String.Join(",", CanLearn.Select(x => x.ToString()));


        public Student():base() { }
    }
}
