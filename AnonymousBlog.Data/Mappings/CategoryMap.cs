using System;
using AnonymousBlog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AnonymousBlog.Data.Mappings
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
               new Category
               {
                   Id = Guid.Parse("207d25af-103c-424b-8f7a-42c57345b18e"),
                   Name = "Asp.Net Core",
                   CreatedBy = "Admin Test",
                   CreatedDate = DateTime.Now,
                   IsDeleted = false,
               },
               new Category
               {
                   Id = Guid.Parse("2ce92254-c0d8-4e72-b51b-1cbadfd8c21c"),
                   Name = "Visual Studio",
                   CreatedBy = "Admin Test",
                   CreatedDate = DateTime.Now,
                   IsDeleted = false,
               });
        }
    }
}

