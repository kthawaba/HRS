using HRS.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace HRS.Infrastructure.Extension
{
    public class ApplicationdbContext: DbContext
    {
        public ApplicationdbContext(DbContextOptions<ApplicationdbContext> option) : base(option)
        {

        }


        public DbSet<User> Users { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<LK_Specialties> LK_Specialties { get; set; }
        public DbSet<lK_UserType> lK_UserTypes { get; set; }
        public DbSet<Doctor> Doctor { get; set; }
        public DbSet<DaysWork> DaysWork { get; set; }
        public DbSet<Patient> Patient { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
