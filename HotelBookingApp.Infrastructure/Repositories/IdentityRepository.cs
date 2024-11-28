
using Microsoft.AspNetCore.Identity;
using HotelBookingApp.Core.Application.Interfaces.Repositories;
using HotelBookingApp.Core.Domain.Entities;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;

namespace HotelBookingApp.Infrastructure.Repository
{
    public class IdentityRepository : IIdentityRepository
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public IdentityRepository(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public bool IsSignedIn(ClaimsPrincipal user) {

            return _signInManager.IsSignedIn(user);
        }

        // Kullanıcı kaydı
        public async Task<bool> RegisterUserAsync(ApplicationUser user, string password)
        {
            var result = await _userManager.CreateAsync(user, password);
            if (!result.Succeeded)
            {
                return false;
            }
            var roleResult = await _userManager.AddToRoleAsync(user, "User");
            return result.Succeeded;
        }

        // Kullanıcı giriş işlemi
        public async Task<ApplicationUser?> LoginUserAsync(string email, string password)
        {
            var result = await _signInManager.PasswordSignInAsync(email, password, isPersistent: false, lockoutOnFailure: false);
            if (!result.Succeeded) return null;

            return await _userManager.FindByEmailAsync(email);
        }

        // Çıkış işlemi
        public async Task LogoutUserAsync()
        {
            await _signInManager.SignOutAsync();
        }

        // Kullanıcıyı e-posta adresine göre bulma
        public async Task<ApplicationUser?> GetUserByEmailAsync(string email)
        {
            return await _userManager.FindByEmailAsync(email);
        }

        public async Task<List<ApplicationUser>> GetHotelAdminsByHotelIdAsync(Guid hotel)
        {
            return await _userManager.Users.Where(x => x.ManagedHotelId == hotel).AsNoTracking().ToListAsync();

        }
        public async Task<bool> AddHotelAdminAsync(Guid hotel,string ManagerEMail)
        {
            var user = await _userManager.FindByEmailAsync(ManagerEMail);
            if (user == null) return false;
            if( await _userManager.IsInRoleAsync(user, "HotelAdmin"))
            {
                return false;
            }
            user.ManagedHotelId = hotel;
            var result = await _userManager.AddToRoleAsync(user, "HotelAdmin");
            return result.Succeeded;
        }

        public async Task<bool> RemoveHotelAdminAsync(string ManagerEMail)
        {
            var user = await GetUserByEmailAsync(ManagerEMail); if (user == null) return false;
            if (!(await _userManager.IsInRoleAsync(user, "HotelAdmin")))
            {
                return false;
            }
            user.ManagedHotelId = null;
            var result = await _userManager.RemoveFromRoleAsync(user, "HotelAdmin");
            return result.Succeeded;
        }
        public async Task<bool> IsManager(string managerMail,Guid hotel)
        {
            var manager =await GetUserByEmailAsync(managerMail);
            if (manager == null) return false;
            if (!(await _userManager.IsInRoleAsync(manager, "HotelAdmin")))
            {
                return false;
            }
            bool result = manager.ManagedHotelId == hotel;
            return result;
        }
    }
}
