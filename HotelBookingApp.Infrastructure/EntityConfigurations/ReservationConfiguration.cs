

using HotelBookingApp.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelBookingApp.Infrastructure.EntityConfigurations
{
    public class ReservationConfiguration : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {
            // Primary Key
            builder.HasKey(r => r.Id);

            // Foreign Key for ApplicationUser
            builder.HasOne(r => r.User)
                   .WithMany(u => u.Reservations) 
                   .HasForeignKey(r => r.ApplicationUserId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.Property(r => r.ReservationNumber).ValueGeneratedOnAdd();

            // PaidPrice Configuration
            builder.Property(r => r.PaidPrice)
                   .HasColumnType("decimal(18,2)") 
                   .IsRequired();

            // PaidDate Configuration
            builder.Property(r => r.PaidDate)
                   .IsRequired();

            // CheckInDate Configuration
            builder.Property(r => r.CheckInDate)
                   .IsRequired();

            // CheckOutDate Configuration
            builder.Property(r => r.CheckOutDate)
                   .IsRequired();

            builder.Property(r => r.Status)
                .IsRequired();
        }
    }
}
