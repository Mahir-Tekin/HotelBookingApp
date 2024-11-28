using System;
using System.Collections.Generic;

namespace HotelBookingApp.Core.Domain.Entities
{
    public class RoomType
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
        public string? Description { get; set; }
        public int Capacity { get; set; }
        public decimal Price { get; set; }

        public Guid HotelId { get; set; }
        public Hotel Hotel { get; set; } = default!;
        public string? Picture { get; set; }

        public ICollection<Room> Rooms { get; set; } = new List<Room>();

        public ICollection<RoomAmenity> Amenities { get; set; } = new List<RoomAmenity>();
    }
}
