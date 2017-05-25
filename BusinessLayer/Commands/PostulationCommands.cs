using Model.Context;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Commands
{
    public class PostulationCommands
    {
        private readonly ContextFluent _contexte;

        public PostulationCommands(ContextFluent context)
        {
            _contexte = context;
        }

        public int AddEmployee(Postulation post)
        {
            _contexte.Postulations.Add(post);
            return _contexte.SaveChanges();
        }

        public int UpdatePostulation(Postulation post)
        {
            Postulation postulation = _contexte.Postulations.FirstOrDefault(p => p.OfferId == post.OfferId && p.EmployeeId == post.EmployeeId);
            if (postulation != null)
            {
                postulation.OfferId = post.OfferId;
                postulation.Status = post.Status;
                postulation.EmployeeId = post.EmployeeId;
            }
            return _contexte.SaveChanges();
        }

        public int DeletePostulation(Postulation post)
        {
            _contexte.Postulations.Remove(post);

            return _contexte.SaveChanges();
        }
    }
}
