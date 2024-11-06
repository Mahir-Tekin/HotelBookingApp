

namespace HotelBookingApp.Core.Application.DTO
{
    public record RoomCreateRequest
    {
        public Guid RoomTypeId { get; set; }
        public string RoomNumber { get; set; } = default!;
    }
}
