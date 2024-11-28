using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HotelBookingApp.Core.Application.Enums.CoreLayerEnums;

namespace HotelBookingApp.Core.Domain.Entities
{
    public class Reservation
    {
        public Guid Id { get; set; }
        public int ReservationNumber { get; set; }
        public String ApplicationUserId { get; set; } = default!;
        public Guid RoomId { get; set; }
        public decimal PaidPrice { get; set; }
        public DateTime PaidDate { get; set; } = DateTime.Now;
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public ReservationStatus Status {  get; set; } = ReservationStatus.Waiting;
        
        public ApplicationUser User { get; set; } = default!;
        public Room Room { get; set; } = default!;
    }
}
