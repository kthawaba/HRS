using HRS.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace HRS.Infrastructure.Configration
{
    public class PatientConfig :IEntityTypeConfiguration<Patient>
    {
        
            public void Configure(EntityTypeBuilder<Patient> builder)
            {
                builder.ToTable("Patient");
                builder.HasKey(x => x.Id);
                builder.Property(x => x.Name).IsRequired().HasMaxLength(100);
                builder.Property(x => x.CreateDate).IsRequired().HasDefaultValueSql("Getdate()");
                builder.HasMany(x => x.Appointments).WithOne(x => x.Patients).HasForeignKey(x => x.PatientID);

        }
         
    }
}
