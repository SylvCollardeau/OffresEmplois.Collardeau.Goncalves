using System;

namespace Model.Entities
{
    public class Formation
    {
        
        public int Id { get; set; }
        
        public int EmployeeId { get; set; }

        public string Title { get; set; }

        public DateTime Date { get; set; }

        public Employee Employee { get; set; }


    }
}
