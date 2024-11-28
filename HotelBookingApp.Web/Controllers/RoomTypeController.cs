using HotelBookingApp.Core.Application.DTO;
using HotelBookingApp.Core.Application.Interfaces.IServices;
using HotelBookingApp.Web.Models;
using Microsoft.AspNetCore.Mvc;


namespace HotelBookingApp.Web.Controllers
{
    public class RoomTypeController : Controller
    {
        private readonly IRoomTypeService _roomTypeService;

        public RoomTypeController(IRoomTypeService roomTypeService)
        {
            _roomTypeService = roomTypeService;
        }

        [HttpPost]
        public async Task<IActionResult> HotelRooms(Guid Id, [FromBody] RoomTypeFilterRequest? filter)
        {
            if (filter == null)
            {
                filter = new RoomTypeFilterRequest();
            }

            var result = await _roomTypeService.GetRoomTypesByHotelIdAsync(Id, filter);
            if (!result.Success)
            {
                return StatusCode(400, result.ErrorMessage); // Hata mesajını döndür
            }
            var response = new RoomTypeListVM
            {
                Filter = filter,
                RoomTypeList = result.Data
            };
            return PartialView("_RoomTypeListPartial", response); // PartialView döndür
        }

        // Tek bir oda türünün detaylarını görüntüleme (Details View)
        public async Task<IActionResult> Details(Guid id)
        {
            var result = await _roomTypeService.GetRoomTypeByIdAsync(id);
            if (!result.Success)
            {
                TempData["ErrorMessage"] = result.ErrorMessage;
                return RedirectToAction("Index");
            }

            return View(result.Data);
        }

        // Yeni oda türü oluşturma sayfasını görüntüleme (Create View)
        [HttpGet]
        public async Task<IActionResult> Create(Guid id)
        {
            var response = await _roomTypeService.PrepareRoomTypeCreationAsync(id);
            if (!response.Success)
            {
                TempData["ErrorMessage"] = response.ErrorMessage;
                return RedirectToAction("Hotel","Details",new {id = id});
            }
            return View(response.Data);
        }

        // Yeni oda türü oluşturma işlemi (Create Post)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(RoomTypeCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return View(request);
            }

            var result = await _roomTypeService.CreateRoomTypeAsync(request);
            if (!result.Success)
            {
                TempData["ErrorMessage"] = result.ErrorMessage;
                return View(request);
            }

            return RedirectToAction("Hotel", "Details", new { id = request.HotelId });
        }

        // Oda türü güncelleme sayfasını görüntüleme (Edit View)

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var result = await _roomTypeService.PrepareUpdateRoomTypeAsync(id);
            if (!result.Success)
            {
                TempData["ErrorMessage"] = result?.ErrorMessage;
                return View();
            }

            return View(result.Data);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, RoomTypeUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return View(request);
            }

            var result = await _roomTypeService.UpdateRoomTypeAsync(id, request);
            if (!result.Success)
            {
                TempData["ErrorMessage"] = result.ErrorMessage;
                return View(request);
            }

            return RedirectToAction("Index");
        }




        // Oda türü silme işlemi (Delete Post)
        [HttpGet, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var result = await _roomTypeService.DeleteRoomTypeAsync(id);
            if (!result.Success)
            {
                TempData["ErrorMessage"] = result.ErrorMessage;
                return RedirectToAction("Index");
            }

            return RedirectToAction("rooms");
        }
    }
}
