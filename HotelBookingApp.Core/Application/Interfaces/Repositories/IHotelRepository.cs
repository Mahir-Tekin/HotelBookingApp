using HotelBookingApp.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace HotelBookingApp.Core.Application.Interfaces.Repositories
{
    public interface IHotelRepository : IRepository<Hotel>
    {
        Task<Hotel?> GetHotelByIdWithAmenityAndRoomTypesAsync(Guid id);
        Task<Hotel?> GetFilteredHotelByIdWithAmenityAndRoomTypesAsync(Guid id, Expression<Func<Hotel, bool>>? filter = null);
        Task<IEnumerable<Hotel>> GetAllHotelsWithAmenityAsync();
        Task<IEnumerable<Hotel>> GetFilteredHotelsWithAmenityAsync(Expression<Func<Hotel, bool>>? filter = null);
        
    }
}
