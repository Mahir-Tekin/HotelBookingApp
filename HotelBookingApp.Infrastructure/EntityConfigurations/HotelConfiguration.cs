using HotelBookingApp.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelBookingApp.Infrastructure.EntityConfigurations
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.ToTable("Hotels");

            builder.HasKey(h => h.Id);

            builder.Property(h => h.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(h => h.City)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(h => h.Address)
                .HasMaxLength(200);

            builder.Property(h => h.StarRating)
                .IsRequired()
                .HasDefaultValue(1);

            builder.Property(h => h.RoomCount)
                .IsRequired(false)
                .HasDefaultValue(0);

            builder.Property(h => h.Description)
                .HasMaxLength(500);

            // Many-to-many relationship between Hotel and HotelAmenity
            builder
                .HasMany(h => h.Amenities)
                .WithMany(a => a.Hotels)
                .UsingEntity(j => j.ToTable("HotelHotelAmenities")); // Ara tablo ismi
        }
    }
}
