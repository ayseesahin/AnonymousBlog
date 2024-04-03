using AnonymousBlog.Core.Entities;
using Microsoft.AspNetCore.Identity;

namespace AnonymousBlog.Entity.Entities
{
	public class AppUser : IdentityUser<Guid> , IEntityBase
    {
		public string FirstName { get; set; }
        public string LastName { get; set; }

		public Guid ImageId { get; set; } = Guid.Parse("a8ffde55-8e69-4bad-9075-3754404452c4");
		public Image Image { get; set; }

		public ICollection<Article> Articles { get; set; }
	}
}

