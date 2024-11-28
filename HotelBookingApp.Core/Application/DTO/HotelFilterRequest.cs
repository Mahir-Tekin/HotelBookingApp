

namespace HotelBookingApp.Core.Application.DTO
{
    public class HotelFilterRequest
    {
        public string? City { get; set; }
        public DateTime? CheckInDate { get; set; } 
        public DateTime? CheckOutDate { get; set; }
        public int? GuestCount { get; set; }
    }
}
