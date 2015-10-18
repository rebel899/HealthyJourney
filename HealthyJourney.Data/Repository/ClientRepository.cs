using HealthyJourney.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyJourney.Data.Repository
{
    class ClientRepository
    {
          
        private HealthyJourneyContext ctx = null;
        public ClientRepository()
        {
            ctx = new HealthyJourneyContext();
        }

        public void AddClient(Client c)
        {
            ctx.Clients.Add(c);
            ctx.SaveChanges();
        }

        public IEnumerable<Client> GetAllClients()
        {
            /*  var req = from c in ctx.Clients
                        orderby c.Id
                        select c;
              return req.ToList(); */

            return ctx.Clients.ToList();

        }

    }
}
