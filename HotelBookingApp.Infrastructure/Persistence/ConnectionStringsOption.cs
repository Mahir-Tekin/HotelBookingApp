﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingApp.Infrastructure.Persistence
{
    public class ConnectionStringsOption
    {
        public const string Key = "ConnectionStrings";

        public string SqlServer { get; set; } = default!;
    }
}
