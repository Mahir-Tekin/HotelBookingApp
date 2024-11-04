using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingApp.Core.Application.DTO
{
    public class HotelAmenityUpdateRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
        public string IconClass { get; set; } = default!;
    }
}
