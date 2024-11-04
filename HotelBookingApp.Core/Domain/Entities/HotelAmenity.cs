using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingApp.Core.Domain.Entities
{
    public class HotelAmenity
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
        public string IconClass { get; set; } = default!;
        public ICollection<Hotel> Hotels { get; set; } = new List<Hotel>();
    }

}
