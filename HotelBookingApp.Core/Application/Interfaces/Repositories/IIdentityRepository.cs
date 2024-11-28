
using HotelBookingApp.Core.Domain.Entities;
using System.Security.Claims;

namespace HotelBookingApp.Core.Application.Interfaces.Repositories
{
    public interface IIdentityRepository
    {
        Task<bool> RegisterUserAsync(ApplicationUser user, string password); 
        Task<ApplicationUser?> LoginUserAsync(string email, string password); 
        Task LogoutUserAsync(); 
        Task<ApplicationUser?> GetUserByEmailAsync(string email);
        bool IsSignedIn(ClaimsPrincipal user);
        Task<List<ApplicationUser>> GetHotelAdminsByHotelIdAsync(Guid hotel);
        Task<bool> RemoveHotelAdminAsync(string ManagerEMail);
        Task<bool> AddHotelAdminAsync(Guid hotel, string ManagerEMail);
        Task<bool> IsManager(string managerMail, Guid hotel);
    }
}
