
using HotelBookingApp.Core.Domain.Entities;

namespace HotelBookingApp.Core.Application.Interfaces.Repositories
{
    public interface IIdentityRepository
    {
        Task<bool> RegisterUserAsync(ApplicationUser user, string password); 
        Task<ApplicationUser?> LoginUserAsync(string email, string password); 
        Task LogoutUserAsync(); 
        Task<ApplicationUser?> GetUserByEmailAsync(string email); 
    }
}
