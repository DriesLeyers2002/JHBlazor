using Microsoft.AspNetCore.Identity;

namespace Jeugdhuis.Models
{
    public class Boardmember : IdentityUser
    {
        public string Name { get; set; }
        public string Role { get; set; }
    }
}
