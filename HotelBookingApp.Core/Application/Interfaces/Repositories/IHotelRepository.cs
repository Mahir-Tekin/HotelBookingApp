using HotelBookingApp.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HotelBookingApp.Core.Application.Interfaces.Repositories
{
    public interface IHotelRepository : IRepository<Hotel>
    {
        // Otelin olanaklarıyla birlikte getirme
        Task<Hotel?> GetHotelByIdWithAmenityAsync(Guid id);

        // Tüm otelleri olanaklarıyla birlikte listeleme
        Task<List<Hotel>> GetAllHotelsWithAmenityAsync();
    }
}
