using Model.Context;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Commands
{
    public class EmployeeCommands
    {
        private readonly ContextFluent _contexte;

        public EmployeeCommands(ContextFluent context)
        {
            _contexte = context;
        }

        public int AddEmployee(Employee emp)
        {
            _contexte.Employees.Add(emp);
            return _contexte.SaveChanges();
        }

        public int UpdateEmployee(Employee emp)
        {
            Employee employee = _contexte.Employees.FirstOrDefault(e => e.Id == emp.Id);
            if(employee != null)
            {
                employee.Name = emp.Name;
                employee.Postulations = emp.Postulations;
                employee.Seniority = emp.Seniority;
                employee.Experiences = emp.Experiences;
                employee.Biography = emp.Biography;
                employee.BirthDate = emp.BirthDate;
            }
            return _contexte.SaveChanges();
        }

        public int DeleteEmployee(Employee emp)
        {
            _contexte.Employees.Remove(emp);

            return _contexte.SaveChanges();
        }
        
    }
}
