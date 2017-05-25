using System;

namespace Model.Entities
{
    public class Postulation
    {

        public int OfferId { get; set; }
        
        public int EmployeeId { get; set; }

        public DateTime Date { get; set; }

        public string Status { get; set; }


        public Employee Employee { get; set;}

        public Offer Offer { get; set; }
    }
}
