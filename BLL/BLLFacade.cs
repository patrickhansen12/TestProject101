using BLL.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class BLLFacade
    {
        public ICompanyService CompanyService
        {
            get { return new CompanyService(new DALFacade()); }
        }

        public IProposalService ProposalService
        {
            get { return new ProposalService(new DALFacade()); }
        }
    }
}
