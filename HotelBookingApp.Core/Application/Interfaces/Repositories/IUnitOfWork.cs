using System;
using System.Threading.Tasks;

namespace HotelBookingApp.Core.Application.Interfaces.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IHotelRepository Hotels { get; }
        IRoomTypeRepository RoomTypes { get; }

        IRepository<T> Repository<T>() where T : class;

        void Attach<TEntity>(TEntity entity) where TEntity : class;

        Task<int> CompleteAsync();
    }
}
