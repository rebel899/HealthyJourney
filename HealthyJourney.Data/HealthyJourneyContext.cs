using HealthyJourney.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyJourney.Data
{
    public class HealthyJourneyContext : DbContext
    {

        public HealthyJourneyContext() : base("Name=HealthyJourneyConnection")
        {

        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<ServiceProvider> ServiceProviders { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Consultant> Consultants { get; set; }

        public DbSet<Badge> Badges { get; set; }
        public DbSet<MedicalRecord> MedicalRecords { get; set; }
        public DbSet<Speciality> Specialities { get; set; }
        public DbSet<MedicalCenterMetadata> MedicalCenterMetadatas { get; set; }
        public DbSet<ServiceProviderBadge> ServiceProviderBadges { get; set; }

    }
}
