
using Microsoft.AspNetCore.Http;

namespace HotelBookingApp.Core.Application.DTO
{
    public record RoomTypeCreateRequest
    {
        public string Name { get; set; } = default!; 
        public string? Description { get; set; }
        public int Capacity { get; set; }
        public Guid HotelId { get; set; }
        public IFormFile? Picture { get; set; }
        public decimal Price { get; set; }

        public List<AmenityDto> Amenities { get; set; } = new List<AmenityDto>();

    }
}
