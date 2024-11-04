using HotelBookingApp.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;


namespace HotelBookingApp.Infrastructure.EntityConfigurations
{
    public class HotelAmenityConfiguration : IEntityTypeConfiguration<HotelAmenity>
    {
        public void Configure(EntityTypeBuilder<HotelAmenity> builder)
        {
            // Tablo adı
            builder.ToTable("HotelAmenities");

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
