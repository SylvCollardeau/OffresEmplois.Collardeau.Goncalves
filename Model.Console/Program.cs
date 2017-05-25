using Model.Context;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            ContextFluent cf = new ContextFluent();
            cf.Employees.ToList();

            cf.Status.Add(new Status()
            {
                Label = "test"
            });

            cf.Offers.Add(new Offer()
            {
                Date = DateTime.Today,
                Title = "Offre 1",
                Description = "Nouvelle Offre !",
                Salary = 1300,
                Responsible = "Moi",
                StatusId = 1
            });

        }
    }
}
