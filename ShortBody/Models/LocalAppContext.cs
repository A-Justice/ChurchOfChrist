using System.Data.Entity;
using System.Diagnostics;

namespace ShortBody.Models
{
    [DebuggerStepThrough]
    public class LocalAppContext : DbContext
    {
        static LocalAppContext()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<LocalAppContext>());

        }
        //DefaultConnection
        //ProductionMachineConnection
        public LocalAppContext() : base("DefaultConnection")
        {
        }
        /// <summary>
        /// efw
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // modelBuilder.Entity<Person>().HasOptional<Service>(p=>p.Service).WithMany().WillCascadeOnDelete(false);

            //modelBuilder.Entity<Person>().HasOptional<Area>(p => p.Area).WithMany().WillCascadeOnDelete(false);
            //base.OnModelreating(modelBuilder); 
        }

        public DbSet<Church> Churches { get; set; }

        public DbSet<ChurchAccountDetail> ChurchAccountDetails { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<MasterPassword> MasterPasswords { get; set; }

        public DbSet<Person> People { get; set; }

        public DbSet<Family> Families { get; set; }


        public DbSet<Event> Events { get; set; }



        public DbSet<Ministry> Ministries { get; set; }


        public DbSet<Report> Reports { get; set; }

        public DbSet<Group> Groups { get; set; }


        public DbSet<Zone> Zones { get; set; }


        public DbSet<Class> Classes { get; set; }

        public DbSet<Area> Areas { get; set; }


        public DbSet<Setting> Settings { get; set; }
    }
}
