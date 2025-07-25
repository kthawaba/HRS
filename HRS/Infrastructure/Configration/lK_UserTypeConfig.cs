using HRS.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HRS.Infrastructure.Configration
{
    public class lK_UserTypeConfig :IEntityTypeConfiguration<lK_UserType>
    {
        public void Configure(EntityTypeBuilder<lK_UserType> builder)
        {
            builder.ToTable("lK_UserType");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CreatedDate).IsRequired().HasDefaultValueSql("Getdate()");


        }
    }
}
