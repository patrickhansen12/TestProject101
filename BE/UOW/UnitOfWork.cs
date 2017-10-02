using DAL.Context;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.UOW
{
    public class UnitOfWork : IUnitOfWork
    {
        public ICompanyRepository CompanyRepository { get; internal set; }
        public IProposalRepository ProposalRepository { get; internal set; }
        private TDDContext context;

        public UnitOfWork()
        {
            context = new TDDContext();
            CompanyRepository = new CompanyRepository(context);
            ProposalRepository = new PropsalRepository(context);
        }

        public int Complete()
        {
            return context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
