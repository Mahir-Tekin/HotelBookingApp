using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace HotelBookingApp.Web.Models
{
    public class AppUser:IdentityUser<Guid>
    {
        [Required]
        [StringLength(50)]
        public string? Name { get; set; }

        [Required]
        [StringLength(50)]
        public string? Surname { get; set; }
    }
}
