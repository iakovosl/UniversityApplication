﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Base {
   public class Person: Entity {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public Person() {
        }
    }
}
