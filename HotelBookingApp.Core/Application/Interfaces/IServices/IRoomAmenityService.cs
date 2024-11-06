using HotelBookingApp.Core.Application.DTO;

namespace HotelBookingApp.Core.Application.Interfaces.IServices
{
    public interface IRoomAmenityService
    {
        // Tüm olanakları listeleme
        Task<ServiceResult<List<RoomAmenityDto>>> GetAllAsync();

        // Tek bir olanak bilgisi getirme
        Task<ServiceResult<RoomAmenityDto>> GetByIdAsync(Guid id);

        // Yeni bir olanak ekleme
        Task<ServiceResult<bool>> CreateAsync(RoomAmenityCreateRequest request);

        // Olanak güncelleme
        Task<ServiceResult<bool>> UpdateAsync(Guid id, RoomAmenityUpdateRequest request);

        // Olanak silme
        Task<ServiceResult<bool>> DeleteAsync(Guid id);
    }
}
