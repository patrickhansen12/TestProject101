using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entity
{
    public class Assignment
    {
        public int Id { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public Group Group { get; set; }
        public Proposal Proposal { get; set; }
    }
}
