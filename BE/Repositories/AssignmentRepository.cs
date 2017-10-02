using DAL.Context;
using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Repositories
{
    class AssignmentRepository : IAssignmentRepository
    {
        TDDContext _context;
        public AssignmentRepository(TDDContext context)
        {
            _context = context;
        }

        public Assignment Create(Assignment assignment)
        {
            _context.Assignments.Add(assignment);
            return assignment;
        }

        public Assignment Delete(int Id)
        {
            var assignment = Get(Id);
            _context.Assignments.Remove(assignment);
            return assignment;
        }

        public Assignment Get(int Id)
        {
            return _context.Assignments.FirstOrDefault(p => p.Id == Id);
        }

        public List<Assignment> GetAll()
        {
            return _context.Assignments.ToList();
        }
    }
}
