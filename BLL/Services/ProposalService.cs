using System;
using System.Collections.Generic;
using System.Text;
using BLL.BusinessObjects;

namespace BLL.Services
{
    class ProposalService : IProposalService
    {
        public ProposalBO Create(ProposalBO proposal)
        {
            return proposal;
        }
    }
}
