using Model.Context;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Queries
{
    public class ExperienceQueries
    {
        private readonly ContextFluent _contexte;

        public ExperienceQueries(ContextFluent context)
        {
            _contexte = context;
        }

        public Experience GetByID(int id)
        {
            return _contexte.Experiences.FirstOrDefault(exp => exp.Id == id);
        }

        public IQueryable<Experience> GetAll()
        {
            return _contexte.Experiences;
        }

    }
}
