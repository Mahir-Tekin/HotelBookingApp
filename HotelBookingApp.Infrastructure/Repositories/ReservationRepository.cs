using HotelBookingApp.Core.Application.Interfaces.Repositories;
using HotelBookingApp.Core.Domain.Entities;
using HotelBookingApp.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static HotelBookingApp.Core.Application.Enums.CoreLayerEnums;

namespace HotelBookingApp.Infrastructure.Repository
{
    public class ReservationRepository : Repository<Reservation>, IReservationRepository
    {
        private readonly AppDbContext _appDbContext;
        public ReservationRepository(AppDbContext context) : base(context)
        {
            _appDbContext = context;
        }

        public async Task<List<Reservation>> GetReservationsByUserIdAsync(string userId)
        {
            return await _appDbContext.Reservations.Where(r => r.ApplicationUserId == userId).AsNoTracking()
                .Include(rs => rs.Room).ThenInclude(ro => ro.RoomType).ThenInclude(rt => rt.Hotel)
                .Include(rs => rs.User)
                .ToListAsync();
        }

        public async Task<List<Reservation>> GetReservationsByHotelIdAsync(Guid hotel)
        {
            return await _appDbContext.Reservations.Where(r => r.Room.RoomType.HotelId == hotel).AsNoTracking()
                .Include(rs => rs.Room).ThenInclude(ro => ro.RoomType).ThenInclude(rt => rt.Hotel)
                .Include(rs => rs.User)
                .ToListAsync();
        }
        public async Task<bool> ChangeReservationStatusAsync(Guid reservaitonId, ReservationStatus status)
        {
            var reservation = _appDbContext.Reservations.FirstOrDefault(r => r.Id == reservaitonId);
            if (reservation == null) { return false; }
            reservation.Status = status;
            _appDbContext.SaveChanges();
            return true;
        }

    }
}
