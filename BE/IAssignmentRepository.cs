using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public interface IAssignmentRepository
    {
        Assignment Create(Assignment assignment);

        List<Assignment> GetAll();
        Assignment Get(int Id);

        Assignment Delete(int Id);
    }
}
