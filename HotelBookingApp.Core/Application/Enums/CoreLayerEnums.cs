using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingApp.Core.Application.Enums
{
    public class CoreLayerEnums
    {
        public enum ReservationStatus
        {
            Waiting,
            Rejected,
            Accepted,
            Cancelled,
        }
    }
}
