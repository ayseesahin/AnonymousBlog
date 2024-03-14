using System;
using Microsoft.EntityFrameworkCore;
using AnonymousBlog.Entity.Entities;


namespace AnonymousBlog.Data.Context
{
    public class AppDbContext : DbContext
    {
        protected AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Image> Images { get; set; }



    }
}

