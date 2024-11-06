using System;

namespace HotelBookingApp.Core.Domain.Entities
{
    public class Room
    {
        public Guid Id { get; set; } 
        public string RoomNumber { get; set; } = default!; 

        // RoomType ile ilişki
        public Guid RoomTypeId { get; set; } 
        public RoomType RoomType { get; set; } = default!; 
    }
}
