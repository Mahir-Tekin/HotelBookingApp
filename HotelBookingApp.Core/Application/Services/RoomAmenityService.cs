
using HotelBookingApp.Core.Application.Interfaces.Repositories;
using HotelBookingApp.Core.Domain.Entities;
using HotelBookingApp.Core.Application.Interfaces.IServices;
using System.Net;
using HotelBookingApp.Core.Application.DTO;

namespace HotelBookingApp.Core.Application.Services
{
    public class RoomAmenityService : IRoomAmenityService
    {
        private readonly IUnitOfWork _unitOfWork;

        public RoomAmenityService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // Tüm olanakları listeleme
        public async Task<ServiceResult<List<RoomAmenityDto>>> GetAllAsync()
        {
            var amenities = await _unitOfWork.Repository<RoomAmenity>().GetAllAsync();
            var amenityDtos = amenities.Select(a => new RoomAmenityDto
            {
                Id = a.Id,
                Name = a.Name,
                IconClass = a.IconClass
            }).ToList();

            return ServiceResult<List<RoomAmenityDto>>.SuccessResult(amenityDtos);
        }

        // Tek bir olanak bilgisi getirme
        public async Task<ServiceResult<RoomAmenityDto>> GetByIdAsync(Guid id)
        {
            var amenity = await _unitOfWork.Repository<RoomAmenity>().GetByIdAsync(id);
            if (amenity == null)
            {
                return ServiceResult<RoomAmenityDto>.FailureResult("Amenity not found", HttpStatusCode.NotFound);
            }

            var amenityDto = new RoomAmenityDto
            {
                Id = amenity.Id,
                Name = amenity.Name,
                IconClass = amenity.IconClass
            };

            return ServiceResult<RoomAmenityDto>.SuccessResult(amenityDto);
        }

        // Yeni bir olanak ekleme
        public async Task<ServiceResult<bool>> CreateAsync(RoomAmenityCreateRequest request)
        {
            var amenity = new RoomAmenity
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                IconClass = request.IconClass
            };

            await _unitOfWork.Repository<RoomAmenity>().AddAsync(amenity);
            await _unitOfWork.CompleteAsync();

            return ServiceResult<bool>.SuccessResult(true, HttpStatusCode.Created);
        }

        // Olanak güncelleme
        public async Task<ServiceResult<bool>> UpdateAsync(Guid id, RoomAmenityUpdateRequest request)
        {
            var amenity = await _unitOfWork.Repository<RoomAmenity>().GetByIdAsync(id);
            if (amenity == null)
            {
                return ServiceResult<bool>.FailureResult("Amenity not found.", HttpStatusCode.NotFound);
            }

            amenity.Name = request.Name;
            amenity.IconClass = request.IconClass;

            _unitOfWork.Repository<RoomAmenity>().Update(amenity);
            await _unitOfWork.CompleteAsync();

            return ServiceResult<bool>.SuccessResult(true);
        }

        // Olanak silme
        public async Task<ServiceResult<bool>> DeleteAsync(Guid id)
        {
            var amenity = await _unitOfWork.Repository<RoomAmenity>().GetByIdAsync(id);
            if (amenity == null)
            {
                return ServiceResult<bool>.FailureResult("Amenity not found.", HttpStatusCode.NotFound);
            }

            _unitOfWork.Repository<RoomAmenity>().Delete(amenity);
            await _unitOfWork.CompleteAsync();

            return ServiceResult<bool>.SuccessResult(true);
        }
    }
}
