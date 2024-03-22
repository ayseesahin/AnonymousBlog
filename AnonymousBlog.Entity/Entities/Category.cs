using System;
using AnonymousBlog.Core.Entities;

namespace AnonymousBlog.Entity.Entities
{
	public class Category : EntityBase
	{
        public Category()
        {
        }

        public Category(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public ICollection<Article> Articles { get; set; }
    }
}

