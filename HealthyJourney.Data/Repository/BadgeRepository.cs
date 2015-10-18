using HealthyJourney.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyJourney.Data.Repository
{
    class BadgeRepository
    {
          
        private HealthyJourneyContext ctx = null;
        public BadgeRepository()
        {
            ctx = new HealthyJourneyContext();
        }

        public void AddBadge(Badge b)
        {
            ctx.Badges.Add(b);
            ctx.SaveChanges();
        }

        public IEnumerable<Badge> GetAllBadges()
        {
            
            return ctx.Badges.ToList();

        }
    }
}
