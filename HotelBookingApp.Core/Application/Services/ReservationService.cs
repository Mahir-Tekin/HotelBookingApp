using HotelBookingApp.Core.Application.DTO;
using HotelBookingApp.Core.Application.Interfaces.IServices;
using HotelBookingApp.Core.Application.Interfaces.Repositories;
using HotelBookingApp.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingApp.Core.Application.Services
{
    public class ReservationService : IReservationService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ReservationService(IUnitOfWork unitOfWork) 
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ServiceResult<ReservationDto>> CreateReservation(string userId,CreateReservationRequest request)
        {
            if (request == null) return ServiceResult<ReservationDto>.FailureResult("Invalid Request.", HttpStatusCode.BadRequest);

            var room =await _unitOfWork.Rooms.GetFirstAvailableRoom(request.RoomTypeId,request.CheckInDate,request.CheckOutDate);

            if (room == null)
            {
                return ServiceResult<ReservationDto>.FailureResult("No available room found.", HttpStatusCode.BadRequest);
            }
            var reservation = new Reservation
            {
                Id = Guid.NewGuid(),
                ApplicationUserId = userId,
                RoomId = room.Id,
                PaidPrice = request.PaidPrice,
                PaidDate = request.PaidDate,
                CheckInDate = request.CheckInDate,
                CheckOutDate = request.CheckOutDate,
            };
            await _unitOfWork.Reservations.AddAsync(reservation);
            var result =await _unitOfWork.CompleteAsync();
            var reservationDto = new ReservationDto
            {
                Id = reservation.Id,
                ApplicationUserId = userId,
                RoomId = room.Id,
                RoomNumber = room.RoomNumber,
                ReservationNumber = reservation.ReservationNumber,
                PaidPrice = request.PaidPrice,
                PaidDate = request.PaidDate,
                CheckInDate = request.CheckInDate,
                CheckOutDate = request.CheckOutDate,
            };
            
            return ServiceResult<ReservationDto>.SuccessResult(reservationDto);
        }

        public async Task<ServiceResult<List<ReservationExtendedDetails>>> GetReservationsByUSerIdAsync(string userId)
        {
            var reservations =  await _unitOfWork.Reservations.GetReservationsByUserIdAsync(userId);

            var reservationDtos = reservations.Select(x => new ReservationExtendedDetails
            {
                HotelName = x.Room.RoomType.Hotel.Name,
                RoomName = x.Room.RoomType.Name,
                RoomTypePictue = x.Room.RoomType.Picture,
                Reservation = new ReservationDto
                {
                    Id = x.Id,
                    ApplicationUserId = x.ApplicationUserId,
                    RoomId = x.RoomId,
                    RoomNumber = x.Room.RoomNumber,
                    ReservationNumber = x.ReservationNumber,
                    CheckInDate = x.CheckInDate,
                    CheckOutDate = x.CheckOutDate,
                    PaidDate = x.PaidDate,
                    PaidPrice = x.PaidPrice,
                    GuestName = x.User.FirstName + " " + x.User.LastName,
                    UserName = x.User.UserName,
                    Status = x.Status,
                }
                
            }
            ).ToList();
            return ServiceResult<List<ReservationExtendedDetails>>.SuccessResult(reservationDtos);
        }
        
        public async Task<ServiceResult<List<ReservationExtendedDetails>>> GetHotelReservations(string userMail,Guid hotel)
        {
            bool isManager =await _unitOfWork.IdentityRepository.IsManager(userMail,hotel);
            if (isManager) {
                var reservations = await _unitOfWork.Reservations.GetReservationsByHotelIdAsync(hotel);

                var reservationDtos = reservations.Select(x => new ReservationExtendedDetails
                {
                    HotelName = x.Room.RoomType.Hotel.Name,
                    RoomName = x.Room.RoomType.Name,
                    RoomTypePictue = x.Room.RoomType.Picture,
                    Reservation = new ReservationDto
                    {
                        Id = x.Id,
                        ApplicationUserId = x.ApplicationUserId,
                        RoomId = x.RoomId,
                        RoomNumber = x.Room.RoomNumber,
                        ReservationNumber = x.ReservationNumber,
                        CheckInDate = x.CheckInDate,
                        CheckOutDate = x.CheckOutDate,
                        PaidDate = x.PaidDate,
                        PaidPrice = x.PaidPrice,
                        GuestName = x.User.FirstName + " " + x.User.LastName,
                        UserName = x.User.UserName,
                        Status = x.Status,
                    }

                }
                ).ToList();

                return ServiceResult<List<ReservationExtendedDetails>>.SuccessResult(reservationDtos);
            }
            return ServiceResult<List<ReservationExtendedDetails>>.FailureResult("başarısız",HttpStatusCode.NoContent);
        }
    }
}
