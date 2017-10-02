using BLL.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Text;
using DAL.Entity;

namespace BLL.Converters
{
    class ProposalConverter
    {
        internal Proposal Convert(ProposalBO proposal)
        {
            if (proposal == null) { return null; }
            return new Proposal()
            {
                Id = proposal.Id,
                Title = proposal.Title,
                Objective = proposal.Objective,
                Semester = proposal.Semester,
                CompanyId = proposal.CompanyId
            };
        }

        internal ProposalBO Convert(Proposal proposal)
        {
            if (proposal == null) { return null; }
            return new ProposalBO()
            {
                Id = proposal.Id,
                Title = proposal.Title,
                Objective = proposal.Objective,
                Semester = proposal.Semester,
                Company = new CompanyConverter().Convert(proposal.Company),
                CompanyId = proposal.CompanyId
            };
        }
    }
}
