using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entity
{
    public class Proposal
    {
        public String Title { get; set; }
        public String Objective { get; set; }
        public String Semester { get; set; }

        public Assignment Assignment { get; set; }
        public Company Company { get; set; }
        public List<Request> Requests { get; set; }
    }
}
