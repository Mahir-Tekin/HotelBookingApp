using HotelBookingApp.Core.Application.Interfaces.Repositories;
using HotelBookingApp.Core.Domain.Entities;
using HotelBookingApp.Infrastructure.Persistence;
using HotelBookingApp.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingApp.Infrastructure.Repositories
{
    public class RoomRepository : Repository<Room>, IRoomRepository
    {
        private readonly AppDbContext _context;

        public RoomRepository(AppDbContext context) : base(context)
        {
            _context = context ;
        }

        public async Task<Room?> GetFirstAvailableRoom(Guid roomTypeId, DateTime checkInDate, DateTime checkOutDate)
        {
            // Uygun odanın sorgulanması
            var room = await _context.Rooms
                .Where(r => r.RoomTypeId == roomTypeId &&
                            r.Reservations.All(rs => rs.CheckInDate >= checkOutDate || rs.CheckOutDate <= checkInDate))
                .FirstOrDefaultAsync();

            return room;
        }

    }
}
