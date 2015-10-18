using HealthyJourney.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyJourney.Data.Repository
{
    class SpecialityRepository
    {
          
        private HealthyJourneyContext ctx = null;
        public SpecialityRepository()
        {
            ctx = new HealthyJourneyContext();
        }

        public void AddSpeciality(Speciality spe)
        {
            ctx.Specialities.Add(spe);
            ctx.SaveChanges();
        }

        public IEnumerable<Speciality> GetAllSpecialities()
        {

            return ctx.Specialities.ToList();

        }
    }
}
