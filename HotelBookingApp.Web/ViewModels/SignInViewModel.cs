using System.ComponentModel.DataAnnotations;

namespace HotelBookingApp.Web.ViewModels
{
    public class SignInViewModel
    {
        public SignInViewModel()
        {
            
        }

        [Required]
        [EmailAddress]
        [Display(Name ="Email")]
        public string? Email { get; set; }

        [Required]
        [Display(Name ="Password")]
        public string? Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
