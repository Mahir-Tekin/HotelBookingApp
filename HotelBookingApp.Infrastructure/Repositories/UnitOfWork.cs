
using HotelBookingApp.Core.Application.Interfaces.Repositories;
using HotelBookingApp.Infrastructure.Persistence;

namespace HotelBookingApp.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public IHotelRepository Hotels { get; }
        public IRoomTypeRepository RoomTypes { get; }

        public UnitOfWork(AppDbContext context, IHotelRepository hotelRepository, IRoomTypeRepository roomTypeRepository)
        {
            _context = context;
            Hotels = hotelRepository;
            RoomTypes = roomTypeRepository;
        }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
