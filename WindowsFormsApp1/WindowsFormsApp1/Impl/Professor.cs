using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Base;

namespace WindowsFormsApp1.Impl {
    public class Professor: Person {

        public string Rank { get; set; }
        public List<CourseCategoryEnum> CanTeach { get; set; } = new List<CourseCategoryEnum>();

        public string Teach => String.Join(",", CanTeach.Select(x => x.ToString()));
        public Professor( ) : base() {
        }
    }
}
