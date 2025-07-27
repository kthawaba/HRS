using HRS.Infrastructure.Configration;
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
        public DbSet<User> User { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<LK_Specialties> LK_Specialtie { get; set; }
        public DbSet<lK_UserType> lK_UserType { get; set; }
        public DbSet<Doctor> Doctor { get; set; }
        public DbSet<DaysWork> DaysWork { get; set; }
        public DbSet<Patient> Patient { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        //    base.OnModelCreating(modelBuilder);
        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DoctorConfig());
            modelBuilder.ApplyConfiguration(new LK_SpecialtiesConfig());
            base.OnModelCreating(modelBuilder);
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<LK_Specialties>().HasData(
        new LK_Specialties
        {
            Id = 1,
            SpecialtyName = "Cardiology",
            SpecialtyCode = "CARD",
            Description = "Heart and cardiovascular specialist",
            Status = true,
            CreatedDate = DateTime.Now
        },
        new LK_Specialties
        {
            Id = 2,
            SpecialtyName = "Neurology",
            SpecialtyCode = "NEUR",
            Description = "Brain and nervous system specialist",
            Status = true,
            CreatedDate = DateTime.Now
        }
    );

            modelBuilder.Entity<lK_UserType>().HasData(
               new lK_UserType
               {
                   Id = 1,
                   UserTypeName = "Admin",
                   Status = true,
                   CreatedDate = DateTime.Now
               },
               new lK_UserType
               {
                   Id = 2,
                   UserTypeName = "Doctor",
                   Status = true,
                   CreatedDate = DateTime.Now
               },
               new lK_UserType
               {
                   Id = 3,
                   UserTypeName = "Patient",
                   Status = true,
                   CreatedDate = DateTime.Now
               }
           );
            modelBuilder.Entity<User>().HasData(
               new User
               {
                   Id = 1,
                   Name = "System Admin",
                   UserName = "admin",
                   Mobile = "0507319204",
                   Status = true,
                   CreatedDate = DateTime.UtcNow,
                   UserTypeId = 1
               },
               new User
               {
                   Id = 2,
                   Name = "Doctor Ali",
                   UserName = "Doctor",
                   Mobile = "0551234567",
                   Status = true,
                   CreatedDate = DateTime.UtcNow,
                   UserTypeId = 2
               },
               new User
               {
                   Id = 3,
                   Name = "khaled",
                   UserName = "Patient",
                   Mobile = "0500206391",
                   Status = true,
                   CreatedDate = DateTime.UtcNow,
                   UserTypeId = 3
               }
           );
            modelBuilder.Entity<Doctor>().HasData(
          new Doctor
          {
              Id = 1,
              Name = "Dr. khaled Abdullah",
              LK_SpecialtiesID = 1,
              AddUser = 1,
              Status = true,
              CreatedDate = DateTime.UtcNow
          },
          new Doctor
          {
              Id = 2,
              Name = "Dr.Lana khaled",
              LK_SpecialtiesID = 2,
              AddUser = 2,
              Status = true,
              CreatedDate = DateTime.UtcNow
          }
      );




        }
    }
}
