using HotelBookingApp.Core.Application.Interfaces.Repositories;
using HotelBookingApp.Core.Domain.Entities;
using HotelBookingApp.Infrastructure.Persistence;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HotelBookingApp.Infrastructure.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        private readonly Dictionary<Type, object> _repositories = new Dictionary<Type, object>();

        public IHotelRepository Hotels { get; }
        public IRoomTypeRepository RoomTypes { get; }
        public IRoomRepository Rooms { get; }
        public IReservationRepository Reservations { get; }
        public IIdentityRepository IdentityRepository { get; }

        public UnitOfWork(AppDbContext context, IHotelRepository hotelRepository, IRoomTypeRepository roomTypeRepository, IRoomRepository roomRepository, IReservationRepository reservationRepository, IIdentityRepository ıdentity)
        {
            _context = context;
            Hotels = hotelRepository;
            RoomTypes = roomTypeRepository;
            Rooms = roomRepository;
            Reservations = reservationRepository;
            IdentityRepository = ıdentity;    
        }

        public void Attach<TEntity>(TEntity entity) where TEntity : class
        {
            _context.Attach(entity);
        }

        public IRepository<T> Repository<T>() where T : class
        {
            if (_repositories.ContainsKey(typeof(T)))
            {
                return (IRepository<T>)_repositories[typeof(T)];
            }

            var repository = new Repository<T>(_context);
            _repositories.Add(typeof(T), repository);
            return repository;
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
