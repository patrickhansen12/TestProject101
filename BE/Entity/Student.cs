using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entity
{
    public class Student
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Email { get; set; }
        public String Tlf { get; set; }

        public Group Group { get; set; }
    }
}
