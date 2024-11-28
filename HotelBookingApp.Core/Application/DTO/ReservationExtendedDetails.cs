using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingApp.Core.Application.DTO
{
    public class ReservationExtendedDetails
    {
        public ReservationDto Reservation { get; set; } = new ReservationDto();
        public string? HotelName { get; set; }
        public string? RoomName { get; set; }
        public string? RoomTypePictue { get; set; }
        public Guid? HotelId { get; set; }

    }
}
