using HealthyJourney.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyJourney.Data.Repository
{
    class ServiceProviderRepository
    {
          
        private HealthyJourneyContext ctx = null;
        public ServiceProviderRepository()
        {
            ctx = new HealthyJourneyContext();
        }

        public void AddServiceProvider(ServiceProvider s)
        {
            ctx.ServiceProviders.Add(s);
            ctx.SaveChanges();
        }

        public IEnumerable<Doctor> GetAllDoctors()
        {
            return ctx.ServiceProviders.OfType<Doctor>().ToList();
        }

        public IEnumerable<MedicalCenter> GetAllMedicalCenters()
        {
            return ctx.ServiceProviders.OfType<MedicalCenter>().ToList();
        }

        public IEnumerable<Insurance> GetAllInsurances()
        {
            return ctx.ServiceProviders.OfType<Insurance>().ToList();
        }
    }
}
