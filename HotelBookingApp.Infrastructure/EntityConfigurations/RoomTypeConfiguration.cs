using HotelBookingApp.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelBookingApp.Infrastructure.EntityConfigurations
{
    public class RoomTypeConfiguration : IEntityTypeConfiguration<RoomType>
    {
        public void Configure(EntityTypeBuilder<RoomType> builder)
        {
            // Table name
            builder.ToTable("RoomTypes");

            // Primary Key
            builder.HasKey(rt => rt.Id);

            // Properties
            builder.Property(rt => rt.Name)
                .IsRequired()
                .HasMaxLength(100); // İsim için maksimum uzunluk

            builder.Property(rt => rt.Description)
                .HasMaxLength(500); // Açıklama için maksimum uzunluk

            builder.Property(rt => rt.Capacity)
                .IsRequired(); // Kapasite zorunlu

            // Relationships
            builder.HasOne(rt => rt.Hotel)
                .WithMany(h => h.RoomTypes)
                .HasForeignKey(rt => rt.HotelId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(rt => rt.Amenities)
                .WithMany(h => h.RoomTypes)
                .UsingEntity(j => j
                .ToTable("RoomRoomAmenities"));


        }
    }
}
