using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class UserAccountConfiguration : IEntityTypeConfiguration<UserAccount>
    {
        public void Configure(EntityTypeBuilder<UserAccount> builder)
        {
            builder.HasKey(u => u.UserId);
            builder.Property(u => u.Email).IsRequired().HasMaxLength(255).IsUnicode(false);
            builder.Property(u => u.Phone).HasMaxLength(20).IsUnicode(false);
            builder.Property(u => u.Fullname).HasMaxLength(255);
            builder.Property(u => u.Gender).HasMaxLength(20);
            builder.Property(u => u.DateOfBirth);
            builder.Property(u => u.Address).HasMaxLength(255);
            builder.Property(u => u.Password).IsRequired().HasMaxLength(255).IsUnicode(false);
            builder.Property(u => u.Specialization).HasMaxLength(255).IsUnicode(false);
            builder.Property(u => u.Degree).HasMaxLength(255).IsUnicode(false);
            builder.Property(u => u.ProfilePicture).HasMaxLength(1000).IsUnicode(false);
            builder.Property(u => u.RoleId).IsRequired();

            builder.HasOne(u => u.Role)
                .WithMany(r => r.UserAccounts)
                .HasForeignKey(u => u.RoleId);
        }
    }
} 