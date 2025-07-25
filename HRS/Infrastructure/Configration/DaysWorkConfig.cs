using HRS.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace HRS.Infrastructure.Configration
{
    public class DaysWorkConfig : IEntityTypeConfiguration<DaysWork>
    {
        public void Configure(EntityTypeBuilder<DaysWork> builder)
        {
            builder.ToTable("DaysWork");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CreatedDate).IsRequired().HasDefaultValueSql("Getdate()");
        }
    }
}
