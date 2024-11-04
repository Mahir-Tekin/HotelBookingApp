using HotelBookingApp.Core.Application.DTO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HotelBookingApp.Core.Application.Interfaces.IServices
{
    public interface IHotelService
    {
        Task<ServiceResult<List<HotelDto>>> GetAllHotelsWithAmenityAsync();
        Task<ServiceResult<HotelDto>> GetHotelByIdAsync(Guid id);
        Task<ServiceResult<bool>> CreateHotelAsync(CreateHotelRequest request);
        Task<ServiceResult<bool>> UpdateHotelAsync(Guid id, UpdateHotelRequest request);
        Task<ServiceResult<bool>> DeleteHotelAsync(Guid id);
        Task<ServiceResult<UpdateHotelRequest>> PrepareUpdateHotelAsync(Guid id);

        // Otel oluşturma işlemi için gerekli olan olanakları sağlayan hazırlık metodu
        Task<ServiceResult<CreateHotelRequest>> PrepareHotelCreationAsync();
    }
}
