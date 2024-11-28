using HotelBookingApp.Core.Application.DTO;
using HotelBookingApp.Core.Application.Interfaces.IServices;
using HotelBookingApp.Core.Application.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using static HotelBookingApp.Core.Application.Enums.CoreLayerEnums;

namespace HotelBookingApp.Web.Controllers
{
    public class ReservationController : Controller
    {
        private readonly IReservationService _reservationService;
        private readonly IIdentityService _identityService;

        public ReservationController(IReservationService reservationService, IIdentityService identityService) 
        {
            _reservationService = reservationService;
            _identityService = identityService;
        }
        [HttpPost]
        public async Task<IActionResult> CreateReservation([FromBody] CreateReservationRequest request)
        {
            // Kullanıcının oturum açıp açmadığını kontrol et
            if (!_identityService.IsSignedIn(User))
            {
                return Unauthorized(); // 401 Unauthorized döndür
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (userId == null) { return BadRequest(ModelState); }
            var response = await _reservationService.CreateReservation(userId,request);

            // Gelecekte döndürülecek partial view
            return PartialView("_ReservationPartialView", response.Data);
        }

        [Authorize]
        public async Task<IActionResult> GetUserReservations()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (userId == null) { return View(); }
            var response = await _reservationService.GetReservationsByUSerIdAsync(userId);

            return View(response.Data);
        }

        [Authorize]
        public async Task<IActionResult> GetHotelReservations(Guid Hotel, string? status = null, int? reservationNumber = null)
        {
            var email = User.FindFirstValue(ClaimTypes.Email);
            if (email == null) { return View(); }

            ViewBag.HotelId = Hotel; // Hotel bilgisi View'a aktarılıyor.
            var result = await _reservationService.GetHotelReservations(email, Hotel, status, reservationNumber);
            return View(result.Data);
        }

        [Authorize]
        public async Task<IActionResult> ChangeReservationStatus(Guid hotel,Guid reservationId,ReservationStatus status)
        {
            var email = User.FindFirstValue(ClaimTypes.Email);
            if (email == null) { return View(); }
            var response =await _reservationService.ChangeReservationStatusAsync(reservationId, status);
            return RedirectToAction("GetHotelReservations",new {hotel});
        }
    }
}
