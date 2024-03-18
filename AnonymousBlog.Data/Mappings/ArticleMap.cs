using AnonymousBlog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AnonymousBlog.Data.Mappings
{
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {

        public void Configure(EntityTypeBuilder<Article> builder)
        {
            // builder.Property(x => x.Title).HasMaxLength(150);
            // builder.Property(x => x.Title).IsRequired(false);

            builder.HasData(new Article
            {
                Id = Guid.NewGuid(),
                Title = "Asp.Net Core Deneme Makalesi 1",
                Content = "Asp.Net Core Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.\n\n\n\n\n\n\n",
                ViewCount = 15,
                CategoryId = Guid.Parse("207d25af-103c-424b-8f7a-42c57345b18e"),
                ImageId = Guid.Parse("3b21b170-ada6-439d-ac46-7f3ca44fc051"),
                CreatedBy = "Admin Time",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                UserId = Guid.Parse("5c5f587c-b90b-462d-a34c-89a30660b79e"),
            },
             new Article
             {
                 Id = Guid.NewGuid(),
                 Title = "Visual Studio Deneme Makalesi 1",
                 Content = "Visual Studio Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.\n\n\n\n\n\n\n",
                 ViewCount = 15,
                 CategoryId = Guid.Parse("2ce92254-c0d8-4e72-b51b-1cbadfd8c21c"),
                 ImageId = Guid.Parse("f5658d11-19f7-44d8-8393-8262e7d849aa"),
                 CreatedBy = "Admin Time",
                 CreatedDate = DateTime.Now,
                 IsDeleted = false,
                 UserId = Guid.Parse("1d83a60b-be44-4796-955c-186b1c9eaf5e"),
             });
        }
    }
}
