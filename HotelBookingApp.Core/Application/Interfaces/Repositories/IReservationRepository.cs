using HotelBookingApp.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingApp.Core.Application.Interfaces.Repositories
{
    public interface IReservationRepository : IRepository<Reservation>
    {
        Task<List<Reservation>> GetReservationsByUserIdAsync(string userId);
        Task<List<Reservation>> GetReservationsByHotelIdAsync(Guid hotel);
    }
}
