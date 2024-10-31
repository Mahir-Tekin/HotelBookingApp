using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using HotelBookingApp.Core.Application.Dto;
using HotelBookingApp.Core.Application.Interfaces.IServices;
using HotelBookingApp.Core.Application.Interfaces.Repositories;
using HotelBookingApp.Core.Domain.Entities;

namespace HotelBookingApp.Core.Application.Services
{
    public class RoomTypeService : IRoomTypeService
    {
        private readonly IUnitOfWork _unitOfWork;

        public RoomTypeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ServiceResult<List<RoomTypeDto>>> GetRoomTypesByHotelIdAsync(Guid hotelId)
        {
            var roomTypes = await _unitOfWork.RoomTypes.GetRoomTypesByHotelIdAsync(hotelId);
            if (!roomTypes.Any())
            {
                return ServiceResult<List<RoomTypeDto>>.FailureResult("No room types found for the specified hotel.", HttpStatusCode.NotFound);
            }

            var roomTypeDtos = roomTypes.Select(rt => new RoomTypeDto
            {
                Id = rt.Id,
                Name = rt.Name,
                Description = rt.Description,
                Capacity = rt.Capacity,
                HotelId = rt.HotelId
            }).ToList();

            return ServiceResult<List<RoomTypeDto>>.SuccessResult(roomTypeDtos);
        }



        // Tek bir oda türü bilgisi getirme
        public async Task<ServiceResult<RoomTypeDto>> GetRoomTypeByIdAsync(Guid id)
        {
            var roomType = await _unitOfWork.RoomTypes.GetByIdAsync(id);
            if (roomType == null)
            {
                return ServiceResult<RoomTypeDto>.FailureResult("Room type not found", HttpStatusCode.NotFound);
            }

            var roomTypeDto = new RoomTypeDto
            {
                Id = roomType.Id,
                Name = roomType.Name,
                Description = roomType.Description,
                Capacity = roomType.Capacity,
                HotelId = roomType.HotelId
            };

            return ServiceResult<RoomTypeDto>.SuccessResult(roomTypeDto);
        }

        // Yeni oda türü ekleme
        public async Task<ServiceResult<bool>> CreateRoomTypeAsync(RoomTypeCreateRequest request)
        {
            var roomType = new RoomType
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                Description = request.Description,
                Capacity = request.Capacity,
                HotelId = request.HotelId
            };

            await _unitOfWork.RoomTypes.AddAsync(roomType);
            await _unitOfWork.CompleteAsync();
            return ServiceResult<bool>.SuccessResult(HttpStatusCode.Created);
        }

        // Oda türü güncelleme
        public async Task<ServiceResult<bool>> UpdateRoomTypeAsync(Guid id, RoomTypeUpdateRequest request)
        {
            var roomType = await _unitOfWork.RoomTypes.GetByIdAsync(id);
            if (roomType == null)
            {
                return ServiceResult<bool>.FailureResult("Room type not found.", HttpStatusCode.NotFound);
            }

            roomType.Name = request.Name;
            roomType.Description = request.Description;
            roomType.Capacity = request.Capacity;
            roomType.HotelId = request.HotelId;

            _unitOfWork.RoomTypes.Update(roomType);
            await _unitOfWork.CompleteAsync();
            return ServiceResult<bool>.SuccessResult();
        }

        // Oda türü silme
        public async Task<ServiceResult<bool>> DeleteRoomTypeAsync(Guid id)
        {
            var roomType = await _unitOfWork.RoomTypes.GetByIdAsync(id);
            if (roomType == null)
            {
                return ServiceResult<bool>.FailureResult("Room type not found.", HttpStatusCode.NotFound);
            }

            _unitOfWork.RoomTypes.Delete(roomType);
            await _unitOfWork.CompleteAsync();
            return ServiceResult<bool>.SuccessResult();
        }
    }
}
