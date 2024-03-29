using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ProjectMVC.Models
{
    public class ApplicationUser : IdentityUser
    {
         public string Image { get; set; }

    }
}
