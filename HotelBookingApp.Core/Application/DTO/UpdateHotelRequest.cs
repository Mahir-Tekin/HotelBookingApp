using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingApp.Core.Application.DTO
{
    public record UpdateHotelRequest
    {
        public string? Name { get; set; }
        public string? City { get; set; }
        public string? Address { get; set; }
        public int? StarRating { get; set; }
        public int? RoomCount { get; set; }
        public string? Description { get; set; }
        public IFormFile? Picture { get; set; }
    }
}
