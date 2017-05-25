using Model.Context;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Queries
{
    public class PostulationQueries
    {
        private readonly ContextFluent _contexte;

        public PostulationQueries(ContextFluent context)
        {
            _contexte = context;
        }

        /// <summary>
        /// Récupère une postulation en fonction d'un identifiant d'employé et un identifiant d'offre.
        /// </summary>
        /// <param name="offerId"></param>
        /// <param name="empId"></param>
        /// <returns></returns>
        public Postulation GetPostulation(int offerId, int empId)
        {
            return _contexte.Postulations.FirstOrDefault(e => e.OfferId == offerId && e.EmployeeId == empId);
        }

        public IQueryable<Employee> GetAll()
        {
            return _contexte.Employees;
        }

    }
}
