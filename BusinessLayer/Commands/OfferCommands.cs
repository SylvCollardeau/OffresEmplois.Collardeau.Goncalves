using Model.Context;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Commands
{
    public class OfferCommands
    {
        private readonly ContextFluent _contexte;

        public OfferCommands(ContextFluent context)
        {
            _contexte = context;
        }

        public int AddOffer(Offer off)
        {
            _contexte.Offers.Add(off);
            return _contexte.SaveChanges();
        }

        public int UpdateOffer(Offer off)
        {
            Offer offer = _contexte.Offers.FirstOrDefault(o => o.Id == off.Id);
            if (offer != null)
            {
                offer.Title = off.Title;
                offer.Description = off.Description;
                offer.Date = off.Date;
                offer.Responsible = off.Responsible;
                offer.Salary = off.Salary;
                offer.Postulations = off.Postulations;
                offer.StatusId = off.StatusId;
            }
            return _contexte.SaveChanges();
        }

        public int DeleteOffer(Offer off)
        {
            _contexte.Offers.Remove(off);

            return _contexte.SaveChanges();
        }
    }
}
