using Microsoft.AspNetCore.Http;
using System;

namespace HotelBookingApp.Core.Application.DTO
{
    public class RoomTypeUpdateRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
        public string? Description { get; set; }
        public int Capacity { get; set; }
        public string? Picture { get; set; }
        public IFormFile? newPicture { get; set; }
        public Guid HotelId { get; set; }
        public decimal Price { get; set; }
        public List<AmenityDto> Amenities { get; set; } = new List<AmenityDto>();
    }
}
