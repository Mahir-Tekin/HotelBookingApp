using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingApp.Core.Domain.Entities
{
    public class RoomAmenity
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
        public string IconClass { get; set; } = default!;
        public ICollection<RoomType> RoomTypes { get; set; } = new List<RoomType>();
    }
}
