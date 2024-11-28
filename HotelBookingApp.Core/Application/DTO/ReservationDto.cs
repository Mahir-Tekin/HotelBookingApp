using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HotelBookingApp.Core.Application.Enums.CoreLayerEnums;

namespace HotelBookingApp.Core.Application.DTO
{
    public class ReservationDto
    {
        public Guid? Id { get; set; }
        public int? ReservationNumber { get; set; }
        public String? ApplicationUserId { get; set; } = default!;
        public Guid? RoomId { get; set; }
        public string? RoomNumber { get; set; }
        public decimal? PaidPrice { get; set; }
        public DateTime? PaidDate { get; set; } = DateTime.Now;
        public DateTime? CheckInDate { get; set; }
        public DateTime? CheckOutDate { get; set; }
        public string? GuestName { get; set; }
        public string? UserName { get; set; }
        public ReservationStatus? Status { get; set; }
    }
}
