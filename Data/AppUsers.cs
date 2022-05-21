using Microsoft.AspNetCore.Identity;

namespace CustomIdentity.Data
{
    public class AppUsers :IdentityUser
    {
        public int UserId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

    }
}
