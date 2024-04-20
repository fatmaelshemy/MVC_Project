using Microsoft.AspNetCore.Identity;

namespace ProjectMVC.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Byte[]? PictureProfile { get; set; }

    }
}
