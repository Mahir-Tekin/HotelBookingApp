using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingApp.Core.Domain.Entities
{
    public class Hotel
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
        public string City { get; set; } = default!;
        public string? Address { get; set; }
        public int StarRating { get; set; } = default!;
        public int? RoomCount { get; set; }
        public string? Description { get; set; }
        public string? Picture { get; set; }


        public ICollection<RoomType> RoomTypes { get; set; } = new List<RoomType>();

    }
}
