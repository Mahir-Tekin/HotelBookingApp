using HotelBookingApp.Core.Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingApp.Core.Application.Interfaces.IServices
{
    public interface IRoomService
    {

        Task<ServiceResult<List<RoomDto>>> GetRoomsByRoomTypeId(Guid roomTypeId);
        Task<ServiceResult<bool>> CreateRoomAsync(RoomCreateRequest request);
        Task<ServiceResult<bool>> DeleteRoomAsync(Guid roomId);
    }
}
