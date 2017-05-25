using System.Collections.Generic;

namespace Model.Entities
{
    public class Status
    {
        /// <summary>
        /// The id of the status
        /// </summary>
        public int Id { get; set; }


        /// <summary>
        /// the label of the status
        /// </summary>
        public string Label { get; set; }

        public ICollection<Offer> Offers { get; set; }
    }
}
