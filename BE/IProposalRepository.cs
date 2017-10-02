using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public interface IProposalRepository
    {
        Proposal Create(Proposal proposal);

        List<Proposal> GetAll();
        Proposal Get(int Id);

        Proposal Delete(int Id);
    }
}
