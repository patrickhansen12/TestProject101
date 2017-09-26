using System;
using System.Collections.Generic;
using System.Text;

namespace BE.Entity
{
    public class Assignment
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public Group Group { get; set; }
        public Proposal Proposal { get; set; }
    }
}
