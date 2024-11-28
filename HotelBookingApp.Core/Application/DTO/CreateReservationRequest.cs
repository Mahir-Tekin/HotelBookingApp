using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingApp.Core.Application.DTO
{
    public class CreateReservationRequest
    {
        public Guid RoomTypeId { get; set; }
        public decimal PaidPrice { get; set; }
        public DateTime PaidDate { get; set; } = DateTime.Now;
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
    }
}
