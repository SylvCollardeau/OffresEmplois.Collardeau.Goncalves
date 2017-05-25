using Model.Context;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Commands
{
    public class StatusCommands
    {
        private readonly ContextFluent _contexte;

        public StatusCommands(ContextFluent context)
        {
            _contexte = context;
        }

        public int AddStatus(Status sta)
        { 
            _contexte.Status.Add(sta);
            return _contexte.SaveChanges();
        }

        public int UpdateStatus(Status sta)
        {
            Status status = _contexte.Status.FirstOrDefault(s => s.Id == sta.Id);
            if (status != null)
            {
                status.Label = sta.Label;
                sta.Offers = sta.Offers;
            }
            return _contexte.SaveChanges();
        }

        public int DeleteStatus(Status sta)
        {
            _contexte.Status.Remove(sta);

            return _contexte.SaveChanges();
        }
    }
}
