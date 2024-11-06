

namespace HotelBookingApp.Core.Application.DTO
{
    public class RoomTypeDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
        public string? Description { get; set; }
        public int Capacity { get; set; }
        public string? Picture { get; set; }
        public Guid HotelId { get; set; }

        public List<RoomAmenityDto> roomAmenities { get; set; } = new List<RoomAmenityDto>();
    }
}
