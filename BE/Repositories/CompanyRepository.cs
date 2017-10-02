using System;
using System.Collections.Generic;
using System.Text;
using DAL.Entity;
using DAL.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DAL.Repositories
{
    class CompanyRepository : ICompanyRepository
    {
        TDDContext _context;
        public CompanyRepository(TDDContext context)
        {
            _context = context;
        }

        public Company Create(Company company)
        {
            _context.Companies.Add(company);
            return company;
        }

        public Company Delete(int Id)
        {
            var company = Get(Id);
            _context.Companies.Remove(company);
            return company;
        }

        public Company Get(int Id)
        {
            return _context.Companies.Include(c => c.Proposals).FirstOrDefault(x => x.Id == Id);
        }

        public List<Company> GetAll()
        {
            return _context.Companies
                .Include(c => c.Proposals)
                .ToList();
        }
    }
}
