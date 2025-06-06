using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasKey(r => r.RoleId);
            builder.Property(r => r.RoleName)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false); // varchar
            builder.Property(r => r.Description)
                .HasMaxLength(2000)
                .IsUnicode(true); // nvarchar
        }
    }
} 