using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetCare.Domain.Entities;

namespace PetCare.Persistence.Data.Maps
{
    public class OwnerMap : IEntityTypeConfiguration<OwnerEntity>
    {
        public void Configure(EntityTypeBuilder<OwnerEntity> builder)
        {
            builder.ToTable("TB_OWNERS");
            
            builder.HasKey(c => c.OwnerID);
            
            builder.Property(c => c.FirstName).HasMaxLength(30).IsRequired(true);
            builder.Property(c => c.LastName).HasMaxLength(40).IsRequired(true);
            builder.Property(c => c.Email).HasMaxLength(100).IsRequired(true);

            builder.HasIndex(c => c.Email).IsUnique().HasDatabaseName("IX_EMAIL");
        }
    }
}
