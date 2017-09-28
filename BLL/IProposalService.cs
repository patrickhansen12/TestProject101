using BLL.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    interface IProposalService
    {
        ProposalBO Create(ProposalBO proposal);
    }
}
