using System.Security.Claims;
using System.Threading.Tasks;
using HotelBookingApp.Core.Application.DTO;
using HotelBookingApp.Core.Domain.Entities;

namespace HotelBookingApp.Core.Application.Interfaces.IServices
{
    public interface IIdentityService
    {
        Task<ServiceResult<bool>> RegisterUserAsync(RegisterUserRequest request); // Kullanıcı kaydı
        Task<ServiceResult<LoginUserResponse>> LoginUserAsync(LoginUserRequest request); // Kullanıcı giriş işlemi
        Task<ServiceResult<bool>> LogoutUserAsync(); // Kullanıcı çıkış işlemi
        bool IsSignedIn(ClaimsPrincipal user);
        Task<ServiceResult<List<ApplicationUser>>> HotelAdminsAsync(Guid hotel);
        Task<ServiceResult<bool>> RemoveHotelAdminAsync(string ManagerEMail);
        Task<ServiceResult<bool>> AddHotelAdminAsync(Guid hotel, string ManagerEmail);
    }
}
