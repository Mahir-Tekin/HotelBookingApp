using Microsoft.AspNetCore.Http;

namespace HotelBookingApp.Core.Application.DTO
{
    public record CreateHotelRequest
    {
        public string Name { get; set; } = default!;
        public string City { get; set; } = default!;
        public string? Address { get; set; }
        public int StarRating { get; set; }
        public int? RoomCount { get; set; }
        public string? Description { get; set; }

        public IFormFile? Picture { get; set; } 
    }
}
