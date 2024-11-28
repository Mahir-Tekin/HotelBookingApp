using HotelBookingApp.Core.Application.DTO;

namespace HotelBookingApp.Web.Models
{
    public class HotelDetailsVM
    {
        public HotelDto Hotel { get; set; } = new HotelDto();
        public RoomTypeFilterRequest Filter { get; set; } = new RoomTypeFilterRequest();
    }
}
