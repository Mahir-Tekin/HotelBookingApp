﻿using HotelBookingApp.Core.Application.Interfaces.IServices;
using HotelBookingApp.Core.Application.DTO;
using Microsoft.AspNetCore.Mvc;


namespace HotelBookingApp.Web.Controllers
{
    public class HotelController : Controller
    {
        private readonly IHotelService _hotelService;

        public HotelController(IHotelService hotelService)
        {
            _hotelService = hotelService;
        }

        // Tüm otelleri listeleme (Index View)
        
        public async Task<IActionResult> Index()
        {
            var result = await _hotelService.GetAllHotelsWithAmenityAsync();
            if (!result.Success)
            {
                TempData["ErrorMessage"] = result.ErrorMessage;
                return View(result);
            }
            return View(result.Data);
        }

        // Tek bir otel detayını gösterme (Details View)
        public async Task<IActionResult> Details(Guid id)
        {
            var result = await _hotelService.GetHotelByIdAsync(id);
            if (!result.Success)
            {
                TempData["ErrorMessage"] = result.ErrorMessage;
                return RedirectToAction("Index");
            }

            return View(result.Data);
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
                TempData["ErrorMessage"] = ModelState.ErrorCount;
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

        

        [HttpPost]
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
    }
}
