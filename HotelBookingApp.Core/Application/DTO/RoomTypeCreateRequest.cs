﻿using System;

namespace HotelBookingApp.Core.Application.Dto
{
    public class RoomTypeCreateRequest
    {
        public string Name { get; set; } = default!; 
        public string? Description { get; set; } 
        public int Capacity { get; set; } 

        public Guid HotelId { get; set; } 
    }
}
