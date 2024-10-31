using System.Threading.Tasks;
using HotelBookingApp.Core.Application.DTO;

namespace HotelBookingApp.Core.Application.Interfaces.IServices
{
    public interface IIdentityService
    {
        Task<ServiceResult<bool>> RegisterUserAsync(RegisterUserRequest request); // Kullanıcı kaydı
        Task<ServiceResult<LoginUserResponse>> LoginUserAsync(LoginUserRequest request); // Kullanıcı giriş işlemi
        Task<ServiceResult<bool>> LogoutUserAsync(); // Kullanıcı çıkış işlemi
    }
}
