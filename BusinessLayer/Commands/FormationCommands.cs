using Model.Context;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Commands
{
    public class FormationCommands
    {
        private readonly ContextFluent _contexte;

        public FormationCommands(ContextFluent context)
        {
            _contexte = context;
        }

        public int AddEmployee(Formation form)
        {
            _contexte.Formations.Add(form);
            return _contexte.SaveChanges();
        }

        public int UpdateFormation(Formation form)
        {
            Formation formation = _contexte.Formations.FirstOrDefault(f => f.Id == form.Id);
            if (formation != null)
            {
                formation.Title = form.Title;
                formation.Date = form.Date;
                formation.EmployeeId = form.EmployeeId;
            }
            return _contexte.SaveChanges();
        }

        public int DeleteFormation(Formation form)
        {
            _contexte.Formations.Remove(form);

            return _contexte.SaveChanges();
        }
    }
}
