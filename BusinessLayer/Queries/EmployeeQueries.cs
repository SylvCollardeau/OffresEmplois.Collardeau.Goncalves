using Model.Context;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Queries
{
    public class EmployeeQueries
    {
        private readonly ContextFluent _contexte;

        public EmployeeQueries(ContextFluent context)
        {
            _contexte = context;
        }

        public Employee GetByID(int id)
        {
            return _contexte.Employees.FirstOrDefault(e => e.Id == id);
        }

        public IQueryable<Employee> GetAll()
        {
            return _contexte.Employees;
        }

    }
}
