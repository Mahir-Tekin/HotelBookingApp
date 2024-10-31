using HotelBookingApp.Core.Application.Dto;
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
        public async Task<IActionResult> GetRoomTypesByHotelId(Guid hotelId)
        {
            var result = await _roomTypeService.GetRoomTypesByHotelIdAsync(hotelId);
            if (!result.Success)
            {
                TempData["ErrorMessage"] = result.ErrorMessage;
                return RedirectToAction("Error"); // Bir hata sayfasına veya uygun bir sayfaya yönlendirme yapabilirsin
            }

            return View("RoomTypes", result.Data); // RoomTypes isimli bir view ile listeleme yapılabilir
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
        public IActionResult Create()
        {
            return View();
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

            return RedirectToAction("Index");
        }

        // Oda türü güncelleme sayfasını görüntüleme (Edit View)
        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var result = await _roomTypeService.GetRoomTypeByIdAsync(id);
            if (!result.Success)
            {
                TempData["ErrorMessage"] = result.ErrorMessage;
                return RedirectToAction("Index");
            }

            var roomTypeData = new RoomTypeUpdateRequest
            {
                Name = result.Data.Name,
                Description = result.Data.Description,
                Capacity = result.Data.Capacity,
                HotelId = result.Data.HotelId
            };

            return View(roomTypeData);
        }

        // Oda türü güncelleme işlemi (Edit Post)
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

        // Oda türü silme onay sayfasını görüntüleme (Delete Confirm View)
        [HttpGet]
        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await _roomTypeService.GetRoomTypeByIdAsync(id);
            if (!result.Success)
            {
                TempData["ErrorMessage"] = result.ErrorMessage;
                return RedirectToAction("Index");
            }

            return View(result.Data);
        }

        // Oda türü silme işlemi (Delete Post)
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var result = await _roomTypeService.DeleteRoomTypeAsync(id);
            if (!result.Success)
            {
                TempData["ErrorMessage"] = result.ErrorMessage;
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }
    }
}
