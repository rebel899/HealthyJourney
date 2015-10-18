using HealthyJourney.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyJourney.Data.Repository
{
    class MedicalRecordRepository
    {
          
        private HealthyJourneyContext ctx = null;
        public MedicalRecordRepository()
        {
            ctx = new HealthyJourneyContext();
        }


        public void AddMedicalRecord(MedicalRecord record)
        {
            ctx.MedicalRecords.Add(record);
            ctx.SaveChanges();
        }

        public IEnumerable<MedicalRecord> GetAllMedicalRecords()
        {
           
            return ctx.MedicalRecords.ToList();
        }

        public IEnumerable<MedicalRecord> GetClientsMedicalRecords(Client c)
        {
            return ctx.MedicalRecords.Where(r => r.Client == c).ToList();
        }
    }
}
