
using HotelBookingApp.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelBookingApp.Infrastructure.EntityConfigurations
{
    public class RoomConfiguration : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {
            builder.ToTable("Rooms");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.RoomNumber).IsRequired().HasMaxLength(10);

            builder.HasOne(x => x.RoomType).WithMany(t => t.Rooms).HasForeignKey(x => x.RoomTypeId);

            builder.HasMany(r => r.Reservations)
               .WithOne(res => res.Room)
               .HasForeignKey(res => res.RoomId);
        }
    }
}
