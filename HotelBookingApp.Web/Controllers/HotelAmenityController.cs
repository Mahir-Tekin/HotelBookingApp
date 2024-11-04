using HotelBookingApp.Core.Application.DTO;
using HotelBookingApp.Core.Application.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace HotelBookingApp.Web.Controllers
{
    public class HotelAmenityController : Controller
    {
        private readonly IHotelAmenityService _hotelAmenityService;

        public HotelAmenityController(IHotelAmenityService hotelAmenityService)
        {
            _hotelAmenityService = hotelAmenityService;
        }

        // Tüm olanakları listeleme
        public async Task<IActionResult> Index()
        {
            var result = await _hotelAmenityService.GetAllAsync();
            if (!result.Success)
            {
                TempData["ErrorMessage"] = result.ErrorMessage;
                return View("Error");
            }

            return View(result.Data);
        }

        // Olanak detaylarını görüntüleme
        public async Task<IActionResult> Details(Guid id)
        {
            var result = await _hotelAmenityService.GetByIdAsync(id);
            if (!result.Success)
            {
                TempData["ErrorMessage"] = result.ErrorMessage;
                return RedirectToAction("Index");
            }

            return View(result.Data);
        }

        // Yeni olanak oluşturma sayfası
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // Yeni olanak oluşturma işlemi
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(HotelAmenityCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return View(request);
            }

            var result = await _hotelAmenityService.CreateAsync(request);
            if (!result.Success)
            {
                TempData["ErrorMessage"] = result.ErrorMessage;
                return View(request);
            }

            return RedirectToAction("Index");
        }

        // Olanak güncelleme sayfasını görüntüleme
        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var result = await _hotelAmenityService.GetByIdAsync(id);
            if (!result.Success)
            {
                TempData["ErrorMessage"] = result.ErrorMessage;
                return RedirectToAction("Index");
            }

            var amenityData = new HotelAmenityUpdateRequest
            {
                Name = result.Data.Name,
                IconClass = result.Data.IconClass
            };

            return View(amenityData);
        }

        // Olanak güncelleme işlemi
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, HotelAmenityUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return View(request);
            }

            var result = await _hotelAmenityService.UpdateAsync(id, request);
            if (!result.Success)
            {
                TempData["ErrorMessage"] = result.ErrorMessage;
                return View(request);
            }

            TempData["SuccessMessage"] = "Amenity updated successfully.";
            return RedirectToAction("Index");
        }

        // Olanak silme işlemi
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var result = await _hotelAmenityService.DeleteAsync(id);
            if (!result.Success)
            {
                TempData["ErrorMessage"] = result.ErrorMessage;
                return RedirectToAction("Index");
            }

            TempData["SuccessMessage"] = "Amenity deleted successfully.";
            return RedirectToAction("Index");
        }
    }
}
