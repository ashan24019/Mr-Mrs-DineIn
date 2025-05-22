using Microsoft.AspNetCore.Identity;

namespace Mr_and_Mrs_DineIn.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<Order> Orders { get; set; }
    }
}
