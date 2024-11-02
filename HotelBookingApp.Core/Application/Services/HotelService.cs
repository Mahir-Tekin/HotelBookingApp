using HotelBookingApp.Core.Application;
using HotelBookingApp.Core.Application.Interfaces.Repositories;
using HotelBookingApp.Core.Application.Interfaces.IServices;
using HotelBookingApp.Core.Application.DTO;
using HotelBookingApp.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.Extensions.FileProviders;

namespace HotelBookingApp.Core.Application.Services
{
    public class HotelService : IHotelService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IFileProvider _fileProvider;

        public HotelService(IUnitOfWork unitOfWork,IFileProvider fileProvider)
        {
            _unitOfWork = unitOfWork;
            _fileProvider = fileProvider;
        }

        // Tüm otelleri listeleme
        public async Task<ServiceResult<List<HotelDto>>> GetAllHotelsAsync()
        {
            var hotels = await _unitOfWork.Hotels.GetAllAsync();
            var hotelDtos = hotels.Select(h => new HotelDto
            {
                Id = h.Id,
                Name = h.Name,
                City = h.City,
                Address = h.Address,
                StarRating = h.StarRating,
                RoomCount = h.RoomCount,
                Description = h.Description
            }).ToList();

            return ServiceResult<List<HotelDto>>.SuccessResult(hotelDtos);
        }

        // Tek bir otel bilgisi getirme
        public async Task<ServiceResult<HotelDto>> GetHotelByIdAsync(Guid id)
        {
            var hotel = await _unitOfWork.Hotels.GetByIdAsync(id);
            if (hotel == null)
            {
                return ServiceResult<HotelDto>.FailureResult("Hotel not found", HttpStatusCode.NotFound);
            }

            var hotelDto = new HotelDto
            {
                Id = hotel.Id,
                Name = hotel.Name,
                City = hotel.City,
                Address = hotel.Address,
                StarRating = hotel.StarRating,
                RoomCount = hotel.RoomCount,
                Description = hotel.Description
            };

            return ServiceResult<HotelDto>.SuccessResult(hotelDto, HttpStatusCode.OK);
        }

        // Yeni otel ekleme
        public async Task<ServiceResult<bool>> CreateHotelAsync(CreateHotelRequest request)
        {

            var hotel = new Hotel
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                City = request.City,
                Address = request.Address,
                StarRating = request.StarRating,
                RoomCount = request.RoomCount,
                Description = request.Description
            };
            if (request.Picture != null && request.Picture.Length > 0)
            {
                var wwwrootFolder = _fileProvider.GetDirectoryContents("wwwroot");
                string randomFileName = $"{Guid.NewGuid().ToString()}{Path.GetExtension(request.Picture.FileName)}";
                var picturePath = Path.Combine(wwwrootFolder!.First(x => x.Name == "hotelpictures").PhysicalPath!, randomFileName);
                using var stream = new FileStream(picturePath, FileMode.Create);
                await request.Picture.CopyToAsync(stream);
                hotel.Picture = randomFileName;
            }

            await _unitOfWork.Hotels.AddAsync(hotel); // Asenkron Ekleme
            await _unitOfWork.CompleteAsync(); // İşlemi kaydet
            return ServiceResult<bool>.SuccessResult(HttpStatusCode.Created);
        }

        // Otel güncelleme
        public async Task<ServiceResult<bool>> UpdateHotelAsync(Guid id, UpdateHotelRequest request)
        {
            var hotel = await _unitOfWork.Hotels.GetByIdAsync(id);
            if (hotel == null)
            {
                return ServiceResult<bool>.FailureResult("Hotel not found.", HttpStatusCode.NotFound);
            }

            // Güncelleme yapılacak alanları kontrol et
            if (!string.IsNullOrEmpty(request.Name)) hotel.Name = request.Name;
            if (!string.IsNullOrEmpty(request.City)) hotel.City = request.City;
            if (!string.IsNullOrEmpty(request.Address)) hotel.Address = request.Address;
            if (request.StarRating.HasValue) hotel.StarRating = request.StarRating.Value;
            if (request.RoomCount.HasValue) hotel.RoomCount = request.RoomCount;
            if (!string.IsNullOrEmpty(request.Description)) hotel.Description = request.Description;

            _unitOfWork.Hotels.Update(hotel);
            await _unitOfWork.CompleteAsync();
            return ServiceResult<bool>.SuccessResult();
        }

        // Otel silme
        public async Task<ServiceResult<bool>> DeleteHotelAsync(Guid id)
        {
            var hotel = await _unitOfWork.Hotels.GetByIdAsync(id);
            if (hotel == null)
            {
                return ServiceResult<bool>.FailureResult("Hotel not found.", HttpStatusCode.NotFound);
            }

            _unitOfWork.Hotels.Delete(hotel);
            await _unitOfWork.CompleteAsync();
            return ServiceResult<bool>.SuccessResult();
        }
    }
}
