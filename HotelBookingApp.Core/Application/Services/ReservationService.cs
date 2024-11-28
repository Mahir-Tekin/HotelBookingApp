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
using static HotelBookingApp.Core.Application.Enums.CoreLayerEnums;

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

        public async Task<ServiceResult<List<ReservationExtendedDetails>>> GetHotelReservations(
    string userMail, Guid hotel, string? status = null, int? reservationNumber = null)
        {
            bool isManager = await _unitOfWork.IdentityRepository.IsManager(userMail, hotel);
            if (isManager)
            {
                var reservations = await _unitOfWork.Reservations.GetReservationsByHotelIdAsync(hotel);

                // Filtreleme işlemi
                if (!string.IsNullOrEmpty(status))
                {
                    if (Enum.TryParse(status, out ReservationStatus parsedStatus))
                    {
                        reservations = reservations.Where(x => x.Status == parsedStatus).ToList();
                    }
                }

                // Arama işlemi
                if (reservationNumber.HasValue)
                {
                    reservations = reservations.Where(x => x.ReservationNumber == reservationNumber.Value).ToList();
                }

                var reservationDtos = reservations.Select(x => new ReservationExtendedDetails
                {
                    HotelId = x.Room.RoomType.HotelId,
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
                }).ToList();

                return ServiceResult<List<ReservationExtendedDetails>>.SuccessResult(reservationDtos);
            }
            return ServiceResult<List<ReservationExtendedDetails>>.FailureResult("başarısız", HttpStatusCode.NoContent);
        }

        public async Task<ServiceResult<bool>> ChangeReservationStatusAsync(Guid reservaitonId,ReservationStatus status)
        {
            var result = await _unitOfWork.Reservations.ChangeReservationStatusAsync(reservaitonId, status);
            return ServiceResult<bool>.SuccessResult(result);
        }
    }
}
