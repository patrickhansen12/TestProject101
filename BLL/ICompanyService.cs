using BLL.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public interface ICompanyService
    {
        CompanyBO Create(CompanyBO company);

        List<CompanyBO> GetAll();
        CompanyBO Get(int Id);

        CompanyBO Update(CompanyBO company);

        CompanyBO Delete(int Id);
    }
}
