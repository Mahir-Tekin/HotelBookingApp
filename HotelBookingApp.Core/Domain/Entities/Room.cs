using System;

namespace HotelBookingApp.Core.Domain.Entities
{
    public class Room
    {
        public Guid Id { get; set; } // Benzersiz tanımlayıcı
        public string RoomNumber { get; set; } = default!; // Oda numarası

        // RoomType ile ilişki
        public Guid RoomTypeId { get; set; } // Yabancı anahtar
        public RoomType RoomType { get; set; } = default!; // Oda türü ile ilişki
    }
}
