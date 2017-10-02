using System;
using System.Collections.Generic;
using System.Text;
using BLL.BusinessObjects;

namespace BLL.Services
{
    class ProposalService : IProposalService
    {
        RentalConverter conv = new RentalConverter();

        private DALFacade _facade;

        public RentalService(DALFacade facade)
        {
            _facade = facade;
        }
    }
}
