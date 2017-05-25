using BusinessLayer.Queries;
using Model.Context;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BusinessManager
    {
        private readonly ContextFluent contexte;
        private static BusinessManager _businessManager = null;

        /// <summary>
        /// Constructeur, initialisation du contexte EF
        /// </summary>
        private BusinessManager()
        {
            contexte = new ContextFluent();
        }

        /// <summary>
        /// Récupérer l'instance du pattern Singleton
        /// </summary>
        public static BusinessManager Instance
        {
            get
            {
                if (_businessManager == null)
                    _businessManager = new BusinessManager();
                return _businessManager;
            }
        }

        public IQueryable<Offer> GetAllOffers()
        {
            OfferQueries oq = new OfferQueries(contexte);
            return oq.GetAll();
        }
    }
}
