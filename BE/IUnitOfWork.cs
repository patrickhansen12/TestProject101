using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public interface IUnitOfWork : IDisposable
    {
        ICompanyRepository CompanyRepository { get; }
        IProposalRepository ProposalRepository { get; }
        IAssignmentRepository AssignmentRepository { get; }
        int Complete();
    }
}
