using Microsoft.AspNetCore.Identity;

namespace HromadaGalerii.Models
{
    public class User : IdentityUser
    {
        
        public ICollection<Gallery>? Galleries { get; set; } = new List<Gallery>();
    }
}
