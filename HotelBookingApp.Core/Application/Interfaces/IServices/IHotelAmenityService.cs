using HotelBookingApp.Core.Application.DTO;


namespace HotelBookingApp.Core.Application.Interfaces.IServices
{
    public interface IHotelAmenityService
    {
        Task<ServiceResult<List<HotelAmenityDto>>> GetAllAsync();
        Task<ServiceResult<HotelAmenityDto>> GetByIdAsync(Guid id);
        Task<ServiceResult<bool>> CreateAsync(HotelAmenityCreateRequest request);
        Task<ServiceResult<bool>> UpdateAsync(Guid id, HotelAmenityUpdateRequest request);
        Task<ServiceResult<bool>> DeleteAsync(Guid id);
    }
}
