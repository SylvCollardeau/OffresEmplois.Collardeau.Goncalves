using System;
using System.Collections.Generic;

namespace Model.Entities
{
    public class Employee
    {
        #region ----Properties----

        public int Id { get; set; }

        public string Name { get; set; }

        public string FirstName { get; set; }

        public DateTime BirthDate { get; set; }

        public int Seniority { get; set; }

        public string Biography { get; set; }

        public ICollection<Experience> Experiences { get; set; }

        public ICollection<Formation> Formations { get; set; }

        public ICollection<Postulation> Postulations { get; set; }

        #endregion
    }
}
