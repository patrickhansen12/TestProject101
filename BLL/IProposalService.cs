using BLL.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public interface IProposalService
    {
        ProposalBO Create(ProposalBO proposal);

        List<ProposalBO> GetAll();
        ProposalBO Get(int Id);

        ProposalBO Update(ProposalBO proposal);

        ProposalBO Delete(int Id);
    }
}
