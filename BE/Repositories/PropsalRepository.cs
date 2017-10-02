using System;
using System.Collections.Generic;
using System.Text;
using DAL.Entity;
using DAL.Context;
using System.Linq;

namespace DAL.Repositories
{
    class PropsalRepository : IProposalRepository
    {
        TDDContext _context;
        public PropsalRepository(TDDContext context)
        {
            _context = context;
        }

        public Proposal Create(Proposal proposal)
        {
            _context.Proposals.Add(proposal);
            return proposal;
        }

        public Proposal Delete(int Id)
        {
            var proposal = Get(Id);
            _context.Proposals.Remove(proposal);
            return proposal;
        }

        public Proposal Get(int Id)
        {
            return _context.Proposals.FirstOrDefault(p => p.Id == Id);
        }

        public List<Proposal> GetAll()
        {
            return _context.Proposals.ToList();
        }
    }
}
