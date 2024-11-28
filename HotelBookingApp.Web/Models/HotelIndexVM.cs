using HotelBookingApp.Core.Application.DTO;

namespace HotelBookingApp.Web.Models
{
    public class HotelIndexVM
    {
        public List<HotelDto> Hotels { get; set; } = new List<HotelDto>();
        public HotelFilterRequest Filter { get; set; } = new HotelFilterRequest();
    }
}
