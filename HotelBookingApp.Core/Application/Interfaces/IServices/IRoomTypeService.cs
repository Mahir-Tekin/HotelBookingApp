using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HotelBookingApp.Core.Application.Dto;
using HotelBookingApp.Core.Application.DTO;

namespace HotelBookingApp.Core.Application.Interfaces.IServices
{
    public interface IRoomTypeService
    {
        Task<ServiceResult<List<RoomTypeDto>>> GetRoomTypesByHotelIdAsync(Guid hotelId);
        Task<ServiceResult<RoomTypeDto>> GetRoomTypeByIdAsync(Guid id);
        Task<ServiceResult<bool>> CreateRoomTypeAsync(RoomTypeCreateRequest request);
        Task<ServiceResult<bool>> UpdateRoomTypeAsync(Guid id, RoomTypeUpdateRequest request);
        Task<ServiceResult<bool>> DeleteRoomTypeAsync(Guid id);
    }
}
