using System.Threading.Tasks;
using HotelBookingApp.Core.Application.DTO;
using HotelBookingApp.Core.Application.Interfaces.IServices;
using HotelBookingApp.Core.Application.Interfaces.Repositories;
using HotelBookingApp.Core.Domain.Entities;
using System.Net;

namespace HotelBookingApp.Core.Application.Services
{
    public class IdentityService : IIdentityService
    {
        private readonly IIdentityRepository _identityRepository;

        public IdentityService(IIdentityRepository identityRepository)
        {
            _identityRepository = identityRepository;
        }

        // Kullanıcı kaydı
        public async Task<ServiceResult<bool>> RegisterUserAsync(RegisterUserRequest request)
        {
            var user = new ApplicationUser
            {
                UserName = request.Email, // Kullanıcı adı olarak e-posta adresini kullanıyoruz
                Email = request.Email,
                FirstName = request.FirstName,
                LastName = request.LastName
            };

            var result = await _identityRepository.RegisterUserAsync(user, request.Password);

            return result
                ? ServiceResult<bool>.SuccessResult(true, HttpStatusCode.Created)
                : ServiceResult<bool>.FailureResult("User registration failed.", HttpStatusCode.BadRequest);
        }

        // Kullanıcı giriş işlemi
        public async Task<ServiceResult<LoginUserResponse>> LoginUserAsync(LoginUserRequest request)
        {
            var user = await _identityRepository.LoginUserAsync(request.Email, request.Password);

            if (user == null)
            {
                return ServiceResult<LoginUserResponse>.FailureResult("Invalid login attempt.", HttpStatusCode.Unauthorized);
            }

            var response = new LoginUserResponse
            {
                UserId = user.Id,
                Email = user.Email,
                FullName = $"{user.FirstName} {user.LastName}"
            };

            return ServiceResult<LoginUserResponse>.SuccessResult(response);
        }

        // Çıkış işlemi
        public async Task<ServiceResult<bool>> LogoutUserAsync()
        {
            await _identityRepository.LogoutUserAsync();
            return ServiceResult<bool>.SuccessResult(true);
        }
    }
}
