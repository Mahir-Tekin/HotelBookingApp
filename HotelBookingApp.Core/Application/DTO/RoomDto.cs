

namespace HotelBookingApp.Core.Application.DTO
{
    public record RoomDto
    {
        public Guid Id { get; set; }
        public string RoomNumber { get; set; } = default!;
        public Guid RoomTypeId { get; set; }

    }
}
