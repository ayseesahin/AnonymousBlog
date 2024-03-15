using System;
using AnonymousBlog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AnonymousBlog.Data.Mappings
{
    public class ImageMap : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasData(
                new Image
                {
                    Id = Guid.Parse("3b21b170-ada6-439d-ac46-7f3ca44fc051"),
                    FileName = "images/testimage",
                    FileType = "jpg",
                    CreatedBy = "Admin Test",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false,
                },
                new Image
                {
                    Id = Guid.Parse("f5658d11-19f7-44d8-8393-8262e7d849aa"),
                    FileName = "images/vstest",
                    FileType = "png",
                    CreatedBy = "Admin Test",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false,
                }
                    );
        }
    }
}

