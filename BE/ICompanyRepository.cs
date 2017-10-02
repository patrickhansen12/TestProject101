using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public interface ICompanyRepository
    {
        Company Create(Company company);

        List<Company> GetAll();
        Company Get(int Id);

        Company Delete(int Id);
    }
}
