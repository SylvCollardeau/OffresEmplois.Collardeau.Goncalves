using Model.Context;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Queries
{
    public class StatusQueries
    {
        private readonly ContextFluent _contexte;

        public StatusQueries(ContextFluent context)
        {
            _contexte = context;
        }

        public Status GetByID(int id)
        {
            return _contexte.Status.FirstOrDefault(e => e.Id == id);
        }

        public IQueryable<Status> GetAll()
        {
            return _contexte.Status;
        }

    }
}
