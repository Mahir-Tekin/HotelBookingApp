using HotelBookingApp.Core.Application.Interfaces.Repositories;
using HotelBookingApp.Core.Domain.Entities;
using HotelBookingApp.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelBookingApp.Infrastructure.Repositories
{
    public class HotelRepository : Repository<Hotel>, IHotelRepository
    {
        private readonly AppDbContext _context;

        public HotelRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        // Otelin olanaklarıyla birlikte getirme
        public async Task<Hotel?> GetHotelByIdWithAmenityAsync(Guid id)
        {
            return await _context.Hotels
                .Include(h => h.Amenities)
                .FirstOrDefaultAsync(h => h.Id == id);
        }

        // Tüm otelleri olanaklarıyla birlikte listeleme
        public async Task<List<Hotel>> GetAllHotelsWithAmenityAsync()
        {
            return await _context.Hotels
                .Include(h => h.Amenities)
                .ToListAsync();
        }
    }
}
