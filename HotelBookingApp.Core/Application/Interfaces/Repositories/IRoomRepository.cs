using HotelBookingApp.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingApp.Core.Application.Interfaces.Repositories
{
    public interface IRoomRepository : IRepository<Room>
    {
        Task<Room> GetFirstAvailableRoom(Guid roomTypeId, DateTime checkInDate, DateTime checkOutDate);
    }
}
