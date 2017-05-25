using BusinessLayer;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.VueModel
{
    public class ListOffresVueModel : BaseViewModel
    {
        private ObservableCollection<OffreVueModel> _offres;
        private OffreVueModel _selectedOffer;

        public ListOffresVueModel()
        {
            // on appelle le mock pour initialiser une liste de produits
            _offres = new ObservableCollection<OffreVueModel>();
            foreach (Offer o in BusinessManager.Instance.GetAllOffers())
            {
                _offres.Add(new OffreVueModel(o));
            }

            if (_offres != null && _offres.Count > 0)
                _selectedOffer = _offres.ElementAt(0);
        }

        #region Data Bindings

        /// <summary>
        /// Obtient ou définit une collection de DetailProduitViewModel (Observable)
        /// </summary>
        public ObservableCollection<OffreVueModel> Offres
        {
            get { return _offres; }
            set
            {
                _offres = value;
                OnPropertyChanged("Offres");
            }
        }

        /// <summary>
        /// Obtient ou défini le produit en cours de sélection dans la liste de DetailProduitViewModel
        /// </summary>
        public OffreVueModel SelectedOffer
        {
            get { return _selectedOffer; }
            set
            {
                _selectedOffer = value;
                OnPropertyChanged("SelectedOffer");
            }
        }
        #endregion
    }
}

