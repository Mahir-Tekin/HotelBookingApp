using System;
using System.Threading.Tasks;

namespace HotelBookingApp.Core.Application.Interfaces.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IHotelRepository Hotels { get; }
        IRoomTypeRepository RoomTypes { get; } 
        Task<int> CompleteAsync(); 
    }
}
