using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthyJourney.Data;
using HealthyJourney.Domain.Entities;

namespace HealthyJourney.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            HealthyJourneyContext ctx = null;
            ctx = new HealthyJourneyContext();

            Badge badge = new Badge { Label="thaer" };

            ctx.Badges.Add(badge);
            ctx.SaveChanges();
        }
    }
}
