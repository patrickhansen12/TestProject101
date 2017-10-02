using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.BusinessObjects
{
    public class CompanyBO
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Address { get; set; }
        public String Tlf { get; set; }
        public String Contact { get; set; }

        public List<int> PropsalIds { get; set; }
        public List<ProposalBO> Proposals { get; set; }
    }
}
