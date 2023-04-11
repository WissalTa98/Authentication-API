using Microsoft.AspNetCore.Identity;

namespace DevAuth.Model
{
	public class UserDTO : IdentityUser
	{
		public string? FirstName { get; set; }

		public string? LastName { get; set; }

		public bool IsAdmin { get; set; }


	}
}
