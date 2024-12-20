﻿using HotelBookingApp.Core.Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HotelBookingApp.Core.Application.Enums.CoreLayerEnums;

namespace HotelBookingApp.Core.Application.Interfaces.IServices
{
    public interface IReservationService
    {
        Task<ServiceResult<ReservationDto>> CreateReservation(string userId, CreateReservationRequest request);
        Task<ServiceResult<List<ReservationExtendedDetails>>> GetReservationsByUSerIdAsync(string userId);
        Task<ServiceResult<List<ReservationExtendedDetails>>> GetHotelReservations(
    string userMail, Guid hotel, string? status = null, int? reservationNumber = null);
        Task<ServiceResult<bool>> ChangeReservationStatusAsync(Guid reservaitonId, ReservationStatus status);
    }
}
