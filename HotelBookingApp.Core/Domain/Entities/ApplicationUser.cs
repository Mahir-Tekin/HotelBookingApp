using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace HotelBookingApp.Core.Domain.Entities
{
    public class ApplicationUser : IdentityUser 
    {
        [Required]
        public string FirstName { get; set; } = default!; 
        [Required]
        public string LastName { get; set; } = default!;  
    }
}
