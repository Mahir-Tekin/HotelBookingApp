using HotelBookingApp.Core.Application.DTO;
using HotelBookingApp.Core.Application.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;

namespace HotelBookingApp.Web.Controllers
{
    public class RoomAmenityController : Controller
    {
        private readonly IRoomAmenityService _roomAmenityService;

        public RoomAmenityController(IRoomAmenityService roomAmenityService)
        {
            _roomAmenityService = roomAmenityService;
        }

        public async Task<IActionResult> Index()
        {
            var result = await _roomAmenityService.GetAllAsync();
            if (!result.Success)
            {
                return View(result.ErrorMessage);
            }
            return View(result.Data);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(RoomAmenityCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return View(request);
            }
            var result = await _roomAmenityService.CreateAsync(request);
            if (!result.Success)
            {
                TempData["ErrorMessage"] = result.ErrorMessage;
                return View(request);
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var result = await _roomAmenityService.GetByIdAsync(id);
            if (!result.Success)
            {
                TempData["ErrorMessage"] = result.ErrorMessage;
                return RedirectToAction("Index");
            }

            var amenityData = new RoomAmenityUpdateRequest
            {
                Name = result.Data.Name,
                IconClass = result.Data.IconClass
            };

            return View(amenityData);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Guid id, RoomAmenityUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return View(request);
            }

            var result = await _roomAmenityService.UpdateAsync(id, request);

            if (!result.Success)
            {
                TempData["ErrorMessage"] += result.ErrorMessage;
                return View(request);
            }

            TempData["SuccessMessage"] = "Amenity updated successfully.";
            return RedirectToAction("Index");
        }
    }
}
