using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.BusinessObjects
{
     public class ProposalBO
    {
        public int Id { get; set; }
        public String Title { get; set; }
        public String Objective { get; set; }
        public String Semester { get; set; }

        public int CompanyId { get; set; }
        public CompanyBO Company { get; set; }
    }
}
