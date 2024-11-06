using Azure.Core;
using HotelBookingApp.Core.Application.DTO;
using HotelBookingApp.Core.Application.Interfaces.IServices;
using HotelBookingApp.Core.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HotelBookingApp.Web.Controllers
{
    public class RoomController : Controller
    {
        IRoomService _roomService;
        public RoomController(IRoomService roomService)
        {
            _roomService = roomService;
        }

        [HttpGet("{roomTypeId}/rooms")]
        public async Task<IActionResult> GetRoomsByTypeId(Guid roomTypeId)
        {
            var result = await _roomService.GetRoomsByRoomTypeId(roomTypeId);
            if (!result.Success)
            {
                TempData["ErrorMessage"] = result.ErrorMessage;
                return View();
            }
            return View(result.Data);
        }

        [HttpGet("{roomTypeId}/rooms/create")]
        public IActionResult CreateRoom(Guid roomTypeId)
        {
            var response = new RoomCreateRequest()
            {
                RoomTypeId = roomTypeId
            };
            return View(response);
        }
        [HttpPost("{roomTypeId}/rooms/create")]
        public async Task<IActionResult> CreateRoom(RoomCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return View(request);
            }

            var result = await _roomService.CreateRoomAsync(request);
            if (!result.Success)
            {
                TempData["ErrorMessage"] = result.ErrorMessage;
                return View(request);
            }

            return RedirectToAction("GetRoomsByTypeId", "Room", new { roomTypeId = request.RoomTypeId });
        }


    }
}
