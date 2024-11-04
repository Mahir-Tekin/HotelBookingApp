using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingApp.Core.Application.DTO
{
    public record AmenityDto
    {
        public Guid Id { get; set; }             // Olanak ID'si
        public string Name { get; set; } = default!;  // Olanak adı
        public string IconClass { get; set; } = default!; // İkon sınıfı
        public bool IsChecked { get; set; }      // Seçim durumu
    }


}
