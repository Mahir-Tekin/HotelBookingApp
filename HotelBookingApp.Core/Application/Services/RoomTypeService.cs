using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using HotelBookingApp.Core.Application.DTO;
using HotelBookingApp.Core.Application.Interfaces.IServices;
using HotelBookingApp.Core.Application.Interfaces.Repositories;
using HotelBookingApp.Core.Domain.Entities;
using Microsoft.Extensions.FileProviders;

namespace HotelBookingApp.Core.Application.Services
{
    public class RoomTypeService : IRoomTypeService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRoomAmenityService _roomAmenityService;
        private readonly IFileProvider _fileProvider;
        public RoomTypeService(IUnitOfWork unitOfWork, IRoomAmenityService roomAmenityService, IFileProvider fileProvider)
        {
            _unitOfWork = unitOfWork;
            _roomAmenityService = roomAmenityService;
            _fileProvider = fileProvider;
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
                HotelId = rt.HotelId,
                Picture = rt.Picture,
                roomAmenities = rt.Amenities.Select(x => new RoomAmenityDto
                {
                    Name = x.Name,
                    IconClass = x.IconClass,
                    Id = x.Id,
                }).ToList(),
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
        public async Task<ServiceResult<RoomTypeCreateRequest>> PrepareRoomTypeCreationAsync(Guid HotelId)
        {
            var amenitiesResult = await _roomAmenityService.GetAllAsync();
            if (!amenitiesResult.Success)
            {
                return ServiceResult<RoomTypeCreateRequest>.FailureResult("Failed to load amenities.", HttpStatusCode.InternalServerError);
            }
            RoomTypeCreateRequest request = new RoomTypeCreateRequest()
            {
                HotelId = HotelId,
                Amenities = amenitiesResult.Data.Select(x => new AmenityDto
                {
                    IconClass = x.IconClass,
                    Id = x.Id,
                    Name = x.Name,
                    IsChecked = false,
                }).ToList()
            };

            return ServiceResult<RoomTypeCreateRequest>.SuccessResult(request);
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

            if (request.Picture != null && request.Picture.Length > 0)
            {
                var wwwrootFolder = _fileProvider.GetDirectoryContents("wwwroot");
                string randomFileName = $"{Guid.NewGuid()}{Path.GetExtension(request.Picture.FileName)}";
                var picturePath = Path.Combine(wwwrootFolder!.First(x => x.Name == "roompictures").PhysicalPath!, randomFileName);

                using var stream = new FileStream(picturePath, FileMode.Create);
                await request.Picture.CopyToAsync(stream);

                roomType.Picture = randomFileName;
            }

            var selectedAmenities = request.Amenities
                .Where(a => a.IsChecked)
                .Select(a => new RoomAmenity { Id = a.Id }) // Sadece Id ile referans oluşturuyoruz
                .ToList();

            foreach (var amenity in selectedAmenities)
            {
                _unitOfWork.Attach(amenity); // Var olan bir nesne olarak işaretliyoruz
            }
            roomType.Amenities = selectedAmenities;

            await _unitOfWork.RoomTypes.AddAsync(roomType);
            await _unitOfWork.CompleteAsync();
            return ServiceResult<bool>.SuccessResult(HttpStatusCode.Created);
        }

        public async Task<ServiceResult<RoomTypeUpdateRequest>> PrepareUpdateRoomTypeAsync(Guid id)
        {
            // Oda türünü ID'ye göre getir
            var roomType = await _unitOfWork.RoomTypes.GetByIdAsync(id);
            if (roomType == null)
            {
                return ServiceResult<RoomTypeUpdateRequest>.FailureResult("Room type not found.", HttpStatusCode.NotFound);
            }

            // Mevcut oda tipi bilgilerini içeren güncelleme isteği oluştur
            var response = new RoomTypeUpdateRequest
            {
                Id = roomType.Id,
                Name = roomType.Name,
                Description = roomType.Description,
                Capacity = roomType.Capacity,
                HotelId = roomType.HotelId,
                Picture = roomType.Picture
            };

            // Oda türünün mevcut olanaklarını seçili olarak ayarlama
            var selectedAmenities = roomType.Amenities.Select(a => new AmenityDto
            {
                Id = a.Id,
                Name = a.Name,
                IconClass = a.IconClass,
                IsChecked = true // Mevcut olanaklar seçili olarak işaretleniyor
            }).ToList();

            // Tüm olanakları al ve güncelleme isteğinde kullan
            var allAmenitiesResult = await _roomAmenityService.GetAllAsync();
            if (!allAmenitiesResult.Success)
            {
                return ServiceResult<RoomTypeUpdateRequest>.FailureResult("Failed to load amenities.", HttpStatusCode.InternalServerError);
            }

            // Tüm olanakların listesini oluştur ve mevcut olanakları işaretli hale getir
            var allAmenities = allAmenitiesResult.Data.Select(a => new AmenityDto
            {
                Id = a.Id,
                Name = a.Name,
                IconClass = a.IconClass,
                IsChecked = selectedAmenities.Any(sa => sa.Id == a.Id)
            }).ToList();

            response.Amenities = allAmenities;

            return ServiceResult<RoomTypeUpdateRequest>.SuccessResult(response);
        }



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

            if (request.newPicture != null && request.newPicture.Length > 0)
            {
                var rootFile = _fileProvider.GetDirectoryContents("wwwroot");
                var uploadsFolder = rootFile.FirstOrDefault(x => x.Name == "hotelpictures")?.PhysicalPath;

                if (uploadsFolder == null)
                {
                    return ServiceResult<bool>.FailureResult("Picture upload folder not found.", HttpStatusCode.InternalServerError);
                }

                if (!string.IsNullOrEmpty(roomType.Picture))
                {
                    var oldPicturePath = Path.Combine(uploadsFolder, roomType.Picture);
                    if (File.Exists(oldPicturePath))
                    {
                        File.Delete(oldPicturePath);
                    }
                }

                // Yeni fotoğrafın adıyla dosya oluştur
                string newFileName = $"{Guid.NewGuid()}{Path.GetExtension(request.newPicture.FileName)}";
                var newPicturePath = Path.Combine(uploadsFolder, newFileName);

                // Dosyayı kaydet
                using var stream = new FileStream(newPicturePath, FileMode.Create);
                await request.newPicture.CopyToAsync(stream);

                roomType.Picture = newFileName; // Yeni dosya adını güncelle
            }


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
