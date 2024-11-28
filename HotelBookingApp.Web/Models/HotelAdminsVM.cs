using HotelBookingApp.Core.Domain.Entities;

namespace HotelBookingApp.Web.Models
{
    public class HotelAdminsVM
    {
        public List<ApplicationUser> users = new List<ApplicationUser>();
        public Guid Hotel {  get; set; }
    }
}
