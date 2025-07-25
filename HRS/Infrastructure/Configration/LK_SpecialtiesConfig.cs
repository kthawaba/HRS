using HRS.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HRS.Infrastructure.Configration
{
    public class LK_SpecialtiesConfig: IEntityTypeConfiguration<LK_Specialties>
    {
        public void Configure(EntityTypeBuilder<LK_Specialties> builder)
        {
            builder.ToTable("lk_specialties");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.SpecialtyName).IsRequired().HasMaxLength(100);
            builder.HasIndex(x => x.SpecialtyName).IsUnique(true);
            builder.Property(x => x.CreatedDate).IsRequired().HasDefaultValueSql("Getdate()");
            builder.HasOne(x=>x.Doctor).WithOne(x=>x.LK_Specialties).HasForeignKey<Doctor>(x=>x.LK_SpecialtiesID).OnDelete(DeleteBehavior.Restrict);

        }
    }
}
