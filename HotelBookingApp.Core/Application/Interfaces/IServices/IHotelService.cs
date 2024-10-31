using HotelBookingApp.Core.Application.DTO;


namespace HotelBookingApp.Core.Application.Interfaces.IServices
{
    public interface IHotelService
    {
        Task<ServiceResult<List<HotelDto>>> GetAllHotelsAsync();

        // Tek bir otel bilgisi getirme
        Task<ServiceResult<HotelDto>> GetHotelByIdAsync(Guid id);

        // Yeni otel ekleme
        Task<ServiceResult<bool>> CreateHotelAsync(CreateHotelRequest request);

        // Otel güncelleme
        Task<ServiceResult<bool>> UpdateHotelAsync(Guid id, UpdateHotelRequest request);

        // Otel silme
        Task<ServiceResult<bool>> DeleteHotelAsync(Guid id);
    }
}
