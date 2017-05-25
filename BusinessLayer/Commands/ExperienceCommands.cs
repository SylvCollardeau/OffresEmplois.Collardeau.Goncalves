using Model.Context;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Commands
{
    public class ExperienceCommands
    {
        private readonly ContextFluent _contexte;

        public ExperienceCommands(ContextFluent context)
        {
            _contexte = context;
        }

        public int AddEmployee(Experience exp)
        {
            _contexte.Experiences.Add(exp);
            return _contexte.SaveChanges();
        }

        public int UpdateEmployee(Experience exp)
        {
            Experience experience = _contexte.Experiences.FirstOrDefault(ex => ex.Id == exp.Id);
            if (experience != null)
            {
                experience.Title = exp.Title;
                experience.Date = exp.Date;
                experience.EmployeeId = exp.EmployeeId;
            }
            return _contexte.SaveChanges();
        }

        public int DeleteExperience(Experience exp)
        {
            _contexte.Experiences.Remove(exp);

            return _contexte.SaveChanges();
        }
    }
}
