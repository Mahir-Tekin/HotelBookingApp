
using HotelBookingApp.Core.Application.Interfaces.Repositories;
using HotelBookingApp.Core.Domain.Entities;
using HotelBookingApp.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace HotelBookingApp.Infrastructure.Repositories
{
    public class RoomTypeRepository : Repository<RoomType>, IRoomTypeRepository
    {
        private readonly AppDbContext _context;

        public RoomTypeRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        // Belirli bir HotelId'ye göre RoomType'ları getirme
        public async Task<IEnumerable<RoomType>> GetRoomTypesByHotelIdAsync(Guid hotelId)
        {
            return await _context.RoomTypes
                                 .Where(rt => rt.HotelId == hotelId)
                                 .ToListAsync();
        }
    }
}
