using GMMWorkshopApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GMMWorkshopApp.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Motorist> Motorists { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Repair> Repairs { get; set; }
        public DbSet<Part> Parts { get; set; }
        public DbSet<Volunteer> Volunteers { get; set; }
        public DbSet<ClassSessions> ClassSessions { get; set; }
        public DbSet<ClassAttendance> ClassAttendances { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Repair>()
                .Property(r => r.LabourHours)
                .HasPrecision(10, 2);

            builder.Entity<Part>()
                .Property(p => p.UnitCost)
                .HasPrecision(10, 2);
        }
    }
}