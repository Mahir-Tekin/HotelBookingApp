
using HotelBookingApp.Core.Domain.Entities;

namespace HotelBookingApp.Core.Application.Interfaces.Repositories
{
    public interface IRoomTypeRepository : IRepository<RoomType>
    {
        // Özel RoomType işlemleri buraya eklenebilir
        Task<IEnumerable<RoomType>> GetRoomTypesByHotelIdAsync(Guid hotelId);
    }
}
