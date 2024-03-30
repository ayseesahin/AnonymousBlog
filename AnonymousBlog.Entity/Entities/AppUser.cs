using Microsoft.AspNetCore.Identity;

namespace AnonymousBlog.Entity.Entities
{
	public class AppUser : IdentityUser<Guid>
	{
		public string FirstName { get; set; }
        public string LastName { get; set; }

		public Guid ImageId { get; set; } = Guid.Parse("f5658d11-19f7-44d8-8393-8262e7d849aa");
		public Image Image { get; set; }

		public ICollection<Article> Articles { get; set; }
	}
}

