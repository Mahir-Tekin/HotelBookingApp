using HotelBookingApp.Core.Application.DTO;

namespace HotelBookingApp.Web.Models
{
    public class RoomTypeListVM
    {
        public List<RoomTypeDto> RoomTypeList { get; set; } = new List<RoomTypeDto>();
        public RoomTypeFilterRequest Filter { get; set; } = new RoomTypeFilterRequest();

    }
}
