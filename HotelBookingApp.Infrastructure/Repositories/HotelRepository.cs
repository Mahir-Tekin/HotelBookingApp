using HotelBookingApp.Core.Application.Interfaces.Repositories;
using HotelBookingApp.Core.Domain.Entities;
using HotelBookingApp.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;


namespace HotelBookingApp.Infrastructure.Repository
{
    public class HotelRepository : Repository<Hotel>, IHotelRepository
    {
        private readonly AppDbContext _context;

        public HotelRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        // Otelin olanaklarıyla birlikte getirme
        public async Task<Hotel?> GetHotelByIdWithAmenityAndRoomTypesAsync(Guid id)
        {
            return await _context.Hotels
                .Include(h => h.Amenities)
                .Include(h => h.RoomTypes).ThenInclude(h => h.Amenities)
                .FirstOrDefaultAsync(h => h.Id == id);
        }
        public async Task<Hotel?> GetFilteredHotelByIdWithAmenityAndRoomTypesAsync(Guid id,Expression<Func<Hotel,bool>>? filter = null)
        {
            return await _context.Hotels
                .Include(h => h.Amenities)
                .Include(h => h.RoomTypes).ThenInclude(h => h.Amenities)
                .FirstOrDefaultAsync(h => h.Id == id);
        }
        public async Task<IEnumerable<Hotel>> GetFilteredHotelsWithAmenityAsync(Expression<Func<Hotel, bool>>? filter = null)
        {
            Expression<Func<Hotel, bool>> defaultFilter = h => true;
            return await _context.Hotels
                .Where(filter ?? defaultFilter)
                .Include(h => h.Amenities)
                .Include(h => h.RoomTypes)
                    .ThenInclude(rt => rt.Rooms)
                        .ThenInclude(r => r.Reservations)
                .ToListAsync();
        }
        // Tüm otelleri olanaklarıyla birlikte listeleme
        public async Task<IEnumerable<Hotel>> GetAllHotelsWithAmenityAsync()
        {
            return await _context.Hotels
                .Include(h => h.Amenities)
                .ToListAsync();
        }
    }
}
