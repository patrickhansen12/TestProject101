using System;
using System.Collections.Generic;
using System.Text;

namespace BE.Entity
{
    public class Student
    {
        public String Name { get; set; }
        public String Email { get; set; }
        public String Tlf { get; set; }

        public Group Group { get; set; }
    }
}
