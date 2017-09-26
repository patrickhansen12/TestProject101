using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entity
{
    public class Company
    {
        public String Name { get; set; }
        public String Address { get; set; }
        public String Tlf { get; set; }
        public String Contact { get; set; }

        public List<Proposal> Proposals { get; set; }
    }
}
