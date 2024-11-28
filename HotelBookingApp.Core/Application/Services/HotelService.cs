
using HotelBookingApp.Core.Application.Interfaces.Repositories;
using HotelBookingApp.Core.Application.Interfaces.IServices;
using HotelBookingApp.Core.Application.DTO;
using HotelBookingApp.Core.Domain.Entities;
using System.Net;
using Microsoft.Extensions.FileProviders;
using LinqKit;


namespace HotelBookingApp.Core.Application.Services
{
    public class HotelService(IUnitOfWork unitOfWork, IFileProvider fileProvider, IHotelAmenityService hotelAmenityService) : IHotelService
    {
        private readonly IUnitOfWork _unitOfWork = unitOfWork;
        private readonly IFileProvider _fileProvider = fileProvider;
        private readonly IHotelAmenityService _hotelAmenityService = hotelAmenityService;

        // Tüm otelleri listeleme
        public async Task<ServiceResult<List<HotelDto>>> GetAllHotelsWithAmenityAsync()
        {
            var hotels = await _unitOfWork.Hotels.GetAllHotelsWithAmenityAsync();
            var hotelDtos = hotels.Select(h => new HotelDto
            {
                Id = h.Id,
                Name = h.Name,
                City = h.City,
                Address = h.Address,
                StarRating = h.StarRating,
                RoomCount = h.RoomCount,
                Description = h.Description,
                Picture = h.Picture,
                HotelAmenities = h.Amenities.Select(x => new AmenityDto
                {
                    Id = x.Id,
                    IconClass = x.IconClass,
                    Name = x.Name,
                    IsChecked = true,
                }).ToList()
            }).ToList();

            return ServiceResult<List<HotelDto>>.SuccessResult(hotelDtos);
        }

        public async Task<ServiceResult<List<HotelDto>>> GetFilteredHotelsWithAmenityAsync(HotelFilterRequest filter)
        {
            var predicate = PredicateBuilder.New<Hotel>(true);
            bool isDateFiltered = false;
            // Şehir Filtresi
            if (!string.IsNullOrEmpty(filter.City))
            {
                predicate = predicate.And(h => h.City == filter.City);
            }

            // Kapasite Filtresi
            if (filter.GuestCount.HasValue)
            {
                predicate = predicate.And(h => h.RoomTypes.Any(rt => rt.Capacity >= filter.GuestCount.Value));
            }

            // Tarih Filtresi
            if (filter.CheckInDate.HasValue && filter.CheckOutDate.HasValue)
            {
                var checkInDate = filter.CheckInDate.Value;
                var checkOutDate = filter.CheckOutDate.Value;
                isDateFiltered = true;
                predicate = predicate.And(h => h.RoomTypes.Any(rt =>
                    rt.Rooms.Any(r =>
                        r.Reservations.All(rs =>
                            rs.CheckOutDate <= checkInDate || rs.CheckInDate >= checkOutDate))));
            }

            // Sorguyu Çalıştır
            var hotels = await _unitOfWork.Hotels.GetFilteredHotelsWithAmenityAsync(predicate);
            var hotelDtos = hotels.Select(h => new HotelDto
            {
                Id = h.Id,
                Name = h.Name,
                City = h.City,
                Address = h.Address,
                StarRating = h.StarRating,
                RoomCount = h.RoomCount,
                Description = h.Description,
                Picture = h.Picture,
                StayDuration = isDateFiltered
                    ? (int)(filter.CheckOutDate!.Value - filter.CheckInDate!.Value).TotalDays : null,
                MinPrice = isDateFiltered
                    ? (int)(filter.CheckOutDate!.Value - filter.CheckInDate!.Value).TotalDays *
                      (h.RoomTypes.Where(rt => rt.Rooms.Any(r =>
                          r.Reservations.All(rs =>
                              rs.CheckOutDate < filter.CheckInDate || rs.CheckInDate > filter.CheckOutDate)))
                          .Min(rt => (decimal?)rt.Price) ?? 0): null,
                IsDateFiltered = isDateFiltered, // Tarih kontrolü burada yapılır
                HotelAmenities = h.Amenities.Select(x => new AmenityDto
                {
                    Id = x.Id,
                    IconClass = x.IconClass,
                    Name = x.Name,
                    IsChecked = true,
                }).ToList()
            }).ToList();

            return ServiceResult<List<HotelDto>>.SuccessResult(hotelDtos);
        }

        // Tek bir otel bilgisi getirme
        public async Task<ServiceResult<HotelDto>> GetHotelByIdAsync(Guid id)
        {
            var hotel = await _unitOfWork.Hotels.GetHotelByIdWithAmenityAndRoomTypesAsync(id);
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
                Description = hotel.Description,
                Picture = hotel.Picture,
                HotelAmenities = hotel.Amenities.Select(x => new AmenityDto
                {
                    Id = x.Id,
                    IconClass = x.IconClass,
                    Name = x.Name,
                    IsChecked = true,
                }).ToList(),
                RoomTypes = hotel.RoomTypes.Select(x => new RoomTypeDto{
                    Id = x.Id,
                    Picture =x.Picture,
                    Capacity = x.Capacity,
                    Description = x.Description,
                    Name = x.Name,
                    HotelId = x.HotelId,
                    roomAmenities = x.Amenities.Select(a => new RoomAmenityDto
                    {
                        IconClass = a.IconClass,
                        Name=a.Name,
                        Id = a.Id,
                    }).ToList(),
                }).ToList(),
            };

            return ServiceResult<HotelDto>.SuccessResult(hotelDto, HttpStatusCode.OK);
        }




        // Yeni otel ekleme
        public async Task<ServiceResult<CreateHotelRequest>> PrepareHotelCreationAsync()
        {
            var amenityResult = await _hotelAmenityService.GetAllAsync();
            if (!amenityResult.Success)
            {
                return ServiceResult<CreateHotelRequest>.FailureResult("Failed to load amenities.", HttpStatusCode.InternalServerError);
            }

            var request = new CreateHotelRequest
            {
                Amenities = amenityResult.Data.Select(a => new AmenityDto
                {
                    Id = a.Id,
                    Name = a.Name,
                    IconClass = a.IconClass, // İkon sınıfını ekliyoruz
                    IsChecked = false
                }).ToList()
            };

            return ServiceResult<CreateHotelRequest>.SuccessResult(request);
        }


        public async Task<ServiceResult<bool>> CreateHotelAsync(CreateHotelRequest request)
        {
            // Yeni otel nesnesi oluştur
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

            // Resim dosyasını kaydet
            if (request.Picture != null && request.Picture.Length > 0)
            {
                var wwwrootFolder = _fileProvider.GetDirectoryContents("wwwroot");
                string randomFileName = $"{Guid.NewGuid()}{Path.GetExtension(request.Picture.FileName)}";
                var picturePath = Path.Combine(wwwrootFolder!.First(x => x.Name == "hotelpictures").PhysicalPath!, randomFileName);

                using var stream = new FileStream(picturePath, FileMode.Create);
                await request.Picture.CopyToAsync(stream);

                hotel.Picture = randomFileName;
            }

            // Seçili olanakları ekle
            var selectedAmenities = request.Amenities
                .Where(a => a.IsChecked)
                .Select(a => new HotelAmenity { Id = a.Id }) // Sadece Id ile referans oluşturuyoruz
                .ToList();

            foreach (var amenity in selectedAmenities)
            {
                _unitOfWork.Attach(amenity); // Var olan bir nesne olarak işaretliyoruz
            }




            hotel.Amenities = selectedAmenities;

            // Oteli veritabanına ekle
            await _unitOfWork.Hotels.AddAsync(hotel);
            await _unitOfWork.CompleteAsync(); 

            return ServiceResult<bool>.SuccessResult(HttpStatusCode.Created);
        }

        public async Task<ServiceResult<UpdateHotelRequest>> PrepareUpdateHotelAsync(Guid id)
        {
            var hotel = await _unitOfWork.Hotels.GetHotelByIdWithAmenityAndRoomTypesAsync(id);
            if (hotel == null)
            {
                return ServiceResult<UpdateHotelRequest>.FailureResult("Hotel not found.", HttpStatusCode.NotFound);
            }

            var response = new UpdateHotelRequest()
            {
                Name = hotel.Name,
                City = hotel.City,
                Address = hotel.Address,
                StarRating = hotel.StarRating,
                RoomCount = hotel.RoomCount,
                Description = hotel.Description,
                CurrentPicture = hotel.Picture,
            };
            var hotelAmenities = hotel.Amenities.Select(x => new AmenityDto
            {
                Id = x.Id,
                Name = x.Name,
                IconClass = x.IconClass,
                IsChecked = false,
            }).ToList();
            var amenityResult = await _hotelAmenityService.GetAllAsync();
            if (!amenityResult.Success)
            {
                return ServiceResult<UpdateHotelRequest>.FailureResult("Failed to load amenities.", HttpStatusCode.InternalServerError);
            }


            var allAmenities = amenityResult.Data.Select(x => new AmenityDto
            {
                Id = x.Id,
                Name = x.Name,
                IconClass = x.IconClass,
                IsChecked = false,
            }).ToList();

            foreach (var amenity in allAmenities)
            {
                if (hotelAmenities.Contains(amenity))
                {
                    amenity.IsChecked = true;
                }
            }

            response.Amenities = allAmenities;

            return ServiceResult<UpdateHotelRequest>.SuccessResult(response);
        }

        // Otel güncelleme
        public async Task<ServiceResult<bool>> UpdateHotelAsync(Guid id, UpdateHotelRequest request)
        {
            var hotel = await _unitOfWork.Hotels.GetHotelByIdWithAmenityAndRoomTypesAsync(id);
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

            // Seçili olanakları ekle
            var selectedAmenities = request.Amenities
                .Where(a => a.IsChecked)
                .Select(a => new HotelAmenity { Id = a.Id }) // Sadece Id ile referans oluşturuyoruz
                .ToList();

            var oldAmenities = hotel.Amenities.Where(oa => !selectedAmenities.Any(a => a.Id == oa.Id)).ToList();

            var newAmenities = selectedAmenities.Where(na => !hotel.Amenities.Any(ha => ha.Id == na.Id)).ToList();

            foreach(var oldAmenity in oldAmenities)
            {
                hotel.Amenities.Remove(oldAmenity);
            }
            foreach (var newAmenity in newAmenities)
            {
                _unitOfWork.Attach(newAmenity);
                hotel.Amenities.Add(newAmenity);
            }

            if (request.Picture != null && request.Picture.Length > 0)
            {
                var wwwrootFolder = _fileProvider.GetDirectoryContents("wwwroot");
                var uploadsFolder = wwwrootFolder.FirstOrDefault(x => x.Name == "hotelpictures")?.PhysicalPath;

                if (uploadsFolder == null)
                {
                    return ServiceResult<bool>.FailureResult("Picture upload folder not found.", HttpStatusCode.InternalServerError);
                }

                // Eski fotoğrafı kontrol et
                if (!string.IsNullOrEmpty(hotel.Picture))
                {
                    var oldPicturePath = Path.Combine(uploadsFolder, hotel.Picture);
                    if (File.Exists(oldPicturePath))
                    {
                        File.Delete(oldPicturePath); // Eski resmi sil
                    }
                }

                // Yeni fotoğrafın adıyla dosya oluştur
                string newFileName = $"{Guid.NewGuid()}{Path.GetExtension(request.Picture.FileName)}";
                var newPicturePath = Path.Combine(uploadsFolder, newFileName);

                // Dosyayı kaydet
                using var stream = new FileStream(newPicturePath, FileMode.Create);
                await request.Picture.CopyToAsync(stream);

                hotel.Picture = newFileName; // Yeni dosya adını güncelle
            }

            // Oteli güncelle
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
