using HotelBookingApp.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingApp.Infrastructure.EntityConfigurations
{
    public class RoomAmenityConfiguration : IEntityTypeConfiguration<RoomAmenity>
    {
        public void Configure(EntityTypeBuilder<RoomAmenity> builder)
        {
            // Tablo adı
            builder.ToTable("RoomAmenities");

            // Id alanı için birincil anahtar
            builder.HasKey(h => h.Id);

            // Name alanı için gereklilik ve uzunluk kısıtlaması
            builder.Property(h => h.Name)
                   .IsRequired()
                   .HasMaxLength(100);

            // IconClass alanı için gereklilik ve uzunluk kısıtlaması
            builder.Property(h => h.IconClass)
                   .IsRequired()
                   .HasMaxLength(50);
        }
    }
}
