using System;
using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using samplemvcapp.Models;

namespace samplemvcapp.Data
{
    public class SampleContext : IdentityDbContext<ApplicationUser>
    {
        public SampleContext() : base("DefaultConnection", throwIfV1Schema: false)
        {
            Database.SetInitializer<SampleContext>(new DropCreateDatabaseIfModelChanges<SampleContext>());
        }

        public static SampleContext Create()
        {
            return new SampleContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }

        public DbSet<Movie> Movies { get; set; }
    }
}
