using BLL.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Converters
{
    class CompanyConverter
    {
        internal Company Convert(CompanyBO company)
        {
            if (company == null) { return null; }
            return new Company()
            {
                Id = company.Id,
                Name = company.Name,
                Address = company.Address,
                Tlf = company.Tlf,
                Contact = company.Contact
            };
        }

        internal CompanyBO Convert(Company company)
        {
            if (company == null) { return null; }
            return new CompanyBO()
            {
                Id = company.Id,
                Name = company.Name,
                Address = company.Address,
                Tlf = company.Tlf,
                Contact = company.Contact
            };
        }
    }
}
