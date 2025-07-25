using HRS.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HRS.Infrastructure.Configration
{
    public class DoctorConfig : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.ToTable("Doctor");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(100);
            builder.Property(x => x.CreatedDate).IsRequired().HasDefaultValueSql("Getdate()");
            builder.HasMany(x=>x.Appointments).WithOne(x=>x.Doctor).HasForeignKey(x=>x.DoctorId);
            builder.HasMany(x=>x.DaysWork).WithOne(x=>x.Doctor).HasForeignKey(x=>x.DoctorId);

        }
    }
}
