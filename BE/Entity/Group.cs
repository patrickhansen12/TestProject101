using System;
using System.Collections.Generic;
using System.Text;

namespace BE.Entity
{
    public class Group
    {
        public String Name { get; set; }

        public List<Student> Students { get; set; }
        public List<Request> Requests { get; set; }
        public Assignment Assignment { get; set; }
    }
}
