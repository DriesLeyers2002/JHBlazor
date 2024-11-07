using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jeugdhuis.Models
{
    public class Boardmember : IdentityUser
    {
        [NotMapped]
        public string DisplayRole { get; set; }

        public bool IsActive { get; set; }
    }
}
