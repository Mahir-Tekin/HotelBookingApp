using HotelBookingApp.Core.Application.DTO;
using HotelBookingApp.Core.Application.Interfaces.IServices;
using HotelBookingApp.Core.Application.Interfaces.Repositories;
using HotelBookingApp.Core.Domain.Entities;
using System.Net;

namespace HotelBookingApp.Core.Application.Services
{
    public class RoomService : IRoomService
    {
        private readonly IUnitOfWork _unitOfWork;

        public RoomService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // Odaların oda türüne göre listelenmesi
        public async Task<ServiceResult<List<RoomDto>>> GetRoomsByRoomTypeId(Guid roomTypeId)
        {
            var rooms = await _unitOfWork.Repository<Room>().FindAsync(r => r.RoomTypeId == roomTypeId);

            if (rooms == null || !rooms.Any())
                return ServiceResult<List<RoomDto>>.FailureResult("No rooms found for the specified room type", HttpStatusCode.NotFound);

            var roomDtos = rooms.Select(r => new RoomDto
            {
                Id = r.Id,
                RoomNumber = r.RoomNumber,
                RoomTypeId = r.RoomTypeId
            }).ToList();

            return ServiceResult<List<RoomDto>>.SuccessResult(roomDtos);
        }

        // Oda oluşturma
        public async Task<ServiceResult<bool>> CreateRoomAsync(RoomCreateRequest request)
        {
            var room = new Room
            {
                Id = Guid.NewGuid(),
                RoomNumber = request.RoomNumber,
                RoomTypeId = request.RoomTypeId,
            };

            await _unitOfWork.Repository<Room>().AddAsync(room);
            await _unitOfWork.CompleteAsync();

            return ServiceResult<bool>.SuccessResult(HttpStatusCode.Created);
        }

        // Oda silme
        public async Task<ServiceResult<bool>> DeleteRoomAsync(Guid roomId)
        {
            var room = await _unitOfWork.Repository<Room>().GetByIdAsync(roomId);

            if (room == null)
                return ServiceResult<bool>.FailureResult("Room not found", HttpStatusCode.NotFound);

            _unitOfWork.Repository<Room>().Delete(room);
            await _unitOfWork.CompleteAsync();

            return ServiceResult<bool>.SuccessResult();
        }
    }
}
