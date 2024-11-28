using System;
using System.Threading.Tasks;

namespace HotelBookingApp.Core.Application.Interfaces.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IHotelRepository Hotels { get; }
        IRoomTypeRepository RoomTypes { get; }
        IReservationRepository Reservations { get; }
        IRoomRepository Rooms { get; }
        IRepository<T> Repository<T>() where T : class;
        IIdentityRepository IdentityRepository { get; }

        void Attach<TEntity>(TEntity entity) where TEntity : class;

        Task<int> CompleteAsync();
    }
}
