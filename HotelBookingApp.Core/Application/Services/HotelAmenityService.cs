using HotelBookingApp.Core.Application.DTO;
using HotelBookingApp.Core.Application.Interfaces.IServices;
using HotelBookingApp.Core.Application.Interfaces.Repositories;
using HotelBookingApp.Core.Domain.Entities;
using System.Net;

namespace HotelBookingApp.Core.Application.Services
{
    public class HotelAmenityService : IHotelAmenityService
    {
        private readonly IUnitOfWork _unitOfWork;

        public HotelAmenityService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // Tüm olanakları listeleme
        public async Task<ServiceResult<List<HotelAmenityDto>>> GetAllAsync()
        {
            var amenities = await _unitOfWork.Repository<HotelAmenity>().GetAllAsync();
            var amenityDtos = amenities.Select(a => new HotelAmenityDto
            {
                Id = a.Id,
                Name = a.Name,
                IconClass = a.IconClass
            }).ToList();

            return ServiceResult<List<HotelAmenityDto>>.SuccessResult(amenityDtos);
        }

        // Tek bir olanak bilgisi getirme
        public async Task<ServiceResult<HotelAmenityDto>> GetByIdAsync(Guid id)
        {
            var amenity = await _unitOfWork.Repository<HotelAmenity>().GetByIdAsync(id);
            if (amenity == null)
            {
                return ServiceResult<HotelAmenityDto>.FailureResult("Amenity not found", HttpStatusCode.NotFound);
            }

            var amenityDto = new HotelAmenityDto
            {
                Id = amenity.Id,
                Name = amenity.Name,
                IconClass = amenity.IconClass
            };

            return ServiceResult<HotelAmenityDto>.SuccessResult(amenityDto);
        }

        // Yeni bir olanak ekleme
        public async Task<ServiceResult<bool>> CreateAsync(HotelAmenityCreateRequest request)
        {
            var amenity = new HotelAmenity
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                IconClass = request.IconClass
            };

            await _unitOfWork.Repository<HotelAmenity>().AddAsync(amenity);
            await _unitOfWork.CompleteAsync();

            return ServiceResult<bool>.SuccessResult(true, HttpStatusCode.Created);
        }

        // Olanak güncelleme
        public async Task<ServiceResult<bool>> UpdateAsync(Guid id, HotelAmenityUpdateRequest request)
        {
            var amenity = await _unitOfWork.Repository<HotelAmenity>().GetByIdAsync(id);
            if (amenity == null)
            {
                return ServiceResult<bool>.FailureResult("Amenity not found.", HttpStatusCode.NotFound);
            }

            amenity.Name = request.Name;
            amenity.IconClass = request.IconClass;

            _unitOfWork.Repository<HotelAmenity>().Update(amenity);
            await _unitOfWork.CompleteAsync();

            return ServiceResult<bool>.SuccessResult(true);
        }

        // Olanak silme
        public async Task<ServiceResult<bool>> DeleteAsync(Guid id)
        {
            var amenity = await _unitOfWork.Repository<HotelAmenity>().GetByIdAsync(id);
            if (amenity == null)
            {
                return ServiceResult<bool>.FailureResult("Amenity not found.", HttpStatusCode.NotFound);
            }

            _unitOfWork.Repository<HotelAmenity>().Delete(amenity);
            await _unitOfWork.CompleteAsync();

            return ServiceResult<bool>.SuccessResult(true);
        }
    }
}
