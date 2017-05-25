using Model.Context;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Queries
{
    public class OfferQueries
    {
        private readonly ContextFluent _contexte;

        public OfferQueries(ContextFluent context)
        {
            _contexte = context;
        }

        public Offer GetByID(int id)
        {
            return _contexte.Offers.FirstOrDefault(o => o.Id == id);
        }

        public IQueryable<Offer> GetAll()
        {
            return _contexte.Offers;
        }

    }
}
