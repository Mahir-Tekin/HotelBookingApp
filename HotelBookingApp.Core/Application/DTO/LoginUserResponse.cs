using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingApp.Core.Application.DTO
{
    public class LoginUserResponse
    {
        public string UserId { get; set; } = default!;     
        public string Email { get; set; } = default!;      
        public string FullName { get; set; } = default!;
    }
}
