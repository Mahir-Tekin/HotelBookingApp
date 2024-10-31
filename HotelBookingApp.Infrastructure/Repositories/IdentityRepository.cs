
using Microsoft.AspNetCore.Identity;
using HotelBookingApp.Core.Application.Interfaces.Repositories;
using HotelBookingApp.Core.Domain.Entities;

namespace HotelBookingApp.Infrastructure.Repositories
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

        // Kullanıcı kaydı
        public async Task<bool> RegisterUserAsync(ApplicationUser user, string password)
        {
            var result = await _userManager.CreateAsync(user, password);
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
    }
}
