﻿using HotelBookingApp.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HotelBookingApp.Core.Application.Interfaces.Repositories
{
    public interface IHotelRepository : IRepository<Hotel>
    {
        Task<Hotel?> GetHotelByIdWithAmenityAsync(Guid id);

        Task<List<Hotel>> GetAllHotelsWithAmenityAsync();
    }
}
