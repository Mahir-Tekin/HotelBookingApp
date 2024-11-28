using HotelBookingApp.Core.Application.Interfaces.IServices;
using HotelBookingApp.Core.Application.DTO;
using Microsoft.AspNetCore.Mvc;
using HotelBookingApp.Web.Models;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;


namespace HotelBookingApp.Web.Controllers
{
    public class HotelController : Controller
    {
        private readonly IHotelService _hotelService;
        private readonly IIdentityService _identityService;

        public HotelController(IHotelService hotelService, IIdentityService identityService)
        {
            _hotelService = hotelService;
            _identityService = identityService;
        }

        // Tüm otelleri listeleme (Index View)

        public IActionResult Index([FromQuery] HotelFilterRequest filter)
        {
            
            var hotelIndexVM = new HotelIndexVM
            {
                Filter = filter,
            };

            return View(hotelIndexVM);
        }

        [HttpPost]
        public async Task<IActionResult> GetFilteredHotels([FromBody] HotelFilterRequest filter)
        {
            if (!ModelState.IsValid)
            {
                // Do Something if it's not valid. 
            }
            var hotels =await _hotelService.GetFilteredHotelsWithAmenityAsync(filter);
            if (!hotels.Success)
            {
                // if it's not success, do something.
            }
            var model = new HotelIndexVM
            {
                Hotels = hotels.Data,
                Filter = filter
            };
            return PartialView("_HotelListPartial", model);
        }

        // Tek bir otel detayını gösterme (Details View)
        public async Task<IActionResult> Details(Guid id, [FromQuery] RoomTypeFilterRequest filter)
        {
            var result = await _hotelService.GetHotelByIdAsync(id);
            if (!result.Success)
            {
                TempData["ErrorMessage"] = result.ErrorMessage;
                return RedirectToAction("Index");
            }
            var response = new HotelDetailsVM
            {
                Filter = filter,
                Hotel = result.Data,

            };
            return View(response);
        }

        // Yeni otel oluşturma sayfasını görüntüleme (Create View)
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var prepareResult = await _hotelService.PrepareHotelCreationAsync();
            if (!prepareResult.Success)
            {
                TempData["ErrorMessage"] = prepareResult.ErrorMessage;
                return RedirectToAction("Index");
            }

            return View(prepareResult.Data);
        }

        // Yeni otel oluşturma işlemi (Create Post)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateHotelRequest request)
        {
            if (!ModelState.IsValid)
            {
                return View(request);
            }

            var result = await _hotelService.CreateHotelAsync(request);
            if (!result.Success)
            {
                TempData["ErrorMessage"] = result.ErrorMessage;
                return View(request);
            }

            return RedirectToAction("Index");
        }

        // Otel güncelleme sayfasını görüntüleme (Edit View)
        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var result = await _hotelService.PrepareUpdateHotelAsync(id);
            if (!result.Success)
            {
                TempData["ErrorMessage"] = result.ErrorMessage;
                return RedirectToAction("Index");
            }


            return View(result.Data);
        }

        // Otel güncelleme işlemi (Edit Post)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, UpdateHotelRequest request)
        {
            if (!ModelState.IsValid)
            {
                return View(request);
            }

            var result = await _hotelService.UpdateHotelAsync(id, request);
            if (!result.Success)
            {
                TempData["ErrorMessage"] = result.ErrorMessage;
                return View(request);
            }

            return RedirectToAction("Index");
        }

        

        [HttpGet]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var result = await _hotelService.DeleteHotelAsync(id);
            if (!result.Success)
            {
                TempData["ErrorMessage"] = result.ErrorMessage;
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> HotelAdmins(Guid hotel)
        {
            var users = await _identityService.HotelAdminsAsync(hotel);
            var response = new HotelAdminsVM
            {
                users = users.Data,
                Hotel = hotel
            };

            return View(response);
        }
        [HttpPost]
        public async Task<IActionResult> AddHotelAdmin(Guid hotel, string managerEMail)
        {
            var result = await _identityService.AddHotelAdminAsync(hotel, managerEMail);
            if (result.Success)
            {
                TempData["SuccessMessage"] = "Admin başarıyla eklendi.";
            }
            else
            {
                TempData["ErrorMessage"] = result.ErrorMessage;
            }

            return RedirectToAction("HotelAdmins", new { hotel });
        }
        public async Task<IActionResult> RemoveHotelAdmin(Guid hotel, string managerEMail)
        {
            var result = await _identityService.RemoveHotelAdminAsync(managerEMail);
            if (result.Success)
            {
                TempData["SuccessMessage"] = "Yetki başarıyla kaldırıldı.";
            }
            else
            {
                TempData["ErrorMessage"] = result.ErrorMessage;
            }

            return RedirectToAction("HotelAdmins", new { hotel });
        }

    }
}
