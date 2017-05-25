using Model.Context;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Queries
{
    public class FormationQueries
    {
        private readonly ContextFluent _contexte;

        public FormationQueries(ContextFluent context)
        {
            _contexte = context;
        }

        public Formation GetByID(int id)
        {
            return _contexte.Formations.FirstOrDefault(f => f.Id == id);
        }

        public IQueryable<Formation> GetAll()
        {
            return _contexte.Formations;
        }

    }
}
