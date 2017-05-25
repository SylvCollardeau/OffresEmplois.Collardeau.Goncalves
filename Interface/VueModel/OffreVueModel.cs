using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Interface.VueModel
{
    public class OffreVueModel : BaseViewModel
    {
        Offer _offre = null;

        public OffreVueModel(Offer o) {
            _offre = o;
        }

        #region Data Bindings

        /// <summary>
        /// Code du produit
        /// </summary>
        public string Title
        {
            get { return _offre.Title; }
            set { _offre.Title = value; }
        }

        /// <summary>
        /// Nom du produit
        /// </summary>
        public string Description
        {
            get { return _offre.Description; }
            set { _offre.Description = value; }
        }

        public DateTime Date
        {
            get { return _offre.Date; }
            set { _offre.Date = value; }
        }

        public ICollection<Postulation> Postulations
        {
            get { return _offre.Postulations; }
            set { _offre.Postulations = value; }
        }

        public float Salary
        {
            get { return _offre.Salary; }
            set { _offre.Salary = value; }
        }

        public string Responsible
        {
            get { return _offre.Responsible; }
            set { _offre.Responsible = value; }
        }

        #endregion
    }
}

