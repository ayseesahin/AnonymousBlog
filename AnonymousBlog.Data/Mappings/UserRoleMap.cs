using System;
using AnonymousBlog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AnonymousBlog.Data.Mappings
{
    public class UserRoleMap : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            // Primary key
            builder.HasKey(r => new { r.UserId, r.RoleId });

            // Maps to the AspNetUserRoles table
            builder.ToTable("AspNetUserRoles");

            builder.HasData(new AppUserRole
            {
                UserId = Guid.Parse("5c5f587c-b90b-462d-a34c-89a30660b79e"),
                RoleId = Guid.Parse("dd4c51df-1862-4ae1-a822-56d285856572")
            },
            new AppUserRole
            {
                UserId = Guid.Parse("1d83a60b-be44-4796-955c-186b1c9eaf5e"),
                RoleId = Guid.Parse("63430193-79eb-4341-afc4-6a04726d611e")
            });
        }
    }
}

