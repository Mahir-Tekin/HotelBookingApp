using HotelBookingApp.Core.Application.DTO;
using HotelBookingApp.Core.Application.Interfaces.IServices;
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

        [HttpGet]
        public async Task<IActionResult> Rooms(Guid Id)
        {
            var result = await _roomTypeService.GetRoomTypesByHotelIdAsync(Id);
            if (!result.Success)
            {
                TempData["ErrorMessage"] = result.ErrorMessage;
                return RedirectToAction("Error"); 
            }

            return View(result.Data); 
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
                return RedirectToAction("Index");
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

            return RedirectToAction("Rooms");
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
