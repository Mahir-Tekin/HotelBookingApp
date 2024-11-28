using HotelBookingApp.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using HotelBookingApp.Infrastructure.EntityConfigurations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace HotelBookingApp.Infrastructure.Persistence
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : IdentityDbContext<ApplicationUser,IdentityRole,string>(options)
    {
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<HotelAmenity> HotelAmenities { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Reservation> Reservations { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new HotelConfiguration());
            modelBuilder.ApplyConfiguration(new RoomTypeConfiguration());
            modelBuilder.ApplyConfiguration(new HotelAmenityConfiguration());
            modelBuilder.ApplyConfiguration(new RoomConfiguration());
            modelBuilder.ApplyConfiguration(new ReservationConfiguration());

            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole { Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Name = "HotelAdmin", NormalizedName = "HOTELADMIN" },
                new IdentityRole { Name = "Manager", NormalizedName = "MANAGER" },
                new IdentityRole { Name = "User", NormalizedName = "USER" }
             );
            modelBuilder.Entity<HotelAmenity>().HasData(
                new HotelAmenity { Id = Guid.NewGuid(), Name = "Free Wi-Fi", IconClass = "bi bi-wifi" },
                new HotelAmenity { Id = Guid.NewGuid(), Name = "Parking", IconClass = "bi bi-car-front" },
                new HotelAmenity { Id = Guid.NewGuid(), Name = "Swimming Pool", IconClass = "bi bi-water" },
                new HotelAmenity { Id = Guid.NewGuid(), Name = "Fitness Center", IconClass = "bi bi-bar-chart-line" },
                new HotelAmenity { Id = Guid.NewGuid(), Name = "Restaurant", IconClass = "bi bi-shop" },
                new HotelAmenity { Id = Guid.NewGuid(), Name = "Room Service", IconClass = "bi bi-house-door" },
                new HotelAmenity { Id = Guid.NewGuid(), Name = "Laundry Service", IconClass = "bi bi-basket" },
                new HotelAmenity { Id = Guid.NewGuid(), Name = "Air Conditioning", IconClass = "bi bi-thermometer-sun" },
                new HotelAmenity { Id = Guid.NewGuid(), Name = "Business Center", IconClass = "bi bi-briefcase" },
                new HotelAmenity { Id = Guid.NewGuid(), Name = "Conference Room", IconClass = "bi bi-megaphone" },
                new HotelAmenity { Id = Guid.NewGuid(), Name = "Non-Smoking Rooms", IconClass = "bi bi-slash-circle" },
                new HotelAmenity { Id = Guid.NewGuid(), Name = "Airport Shuttle", IconClass = "bi bi-airplane-engines" }
            );

            modelBuilder.Entity<RoomAmenity>().HasData(
                new RoomAmenity { Id = Guid.NewGuid(), Name = "Television", IconClass = "bi bi-tv" },
                new RoomAmenity { Id = Guid.NewGuid(), Name = "Mini Bar", IconClass = "bi bi-cup-straw" },
                new RoomAmenity { Id = Guid.NewGuid(), Name = "Coffee Maker", IconClass = "bi bi-cup-hot" },
                new RoomAmenity { Id = Guid.NewGuid(), Name = "Hair Dryer", IconClass = "bi bi-wind" },
                new RoomAmenity { Id = Guid.NewGuid(), Name = "Iron and Ironing Board", IconClass = "bi bi-house" },
                new RoomAmenity { Id = Guid.NewGuid(), Name = "Safe Deposit Box", IconClass = "bi bi-safe" },
                new RoomAmenity { Id = Guid.NewGuid(), Name = "Air Conditioning", IconClass = "bi bi-thermometer-sun" },
                new RoomAmenity { Id = Guid.NewGuid(), Name = "Work Desk", IconClass = "bi bi-table" },
                new RoomAmenity { Id = Guid.NewGuid(), Name = "Free Toiletries", IconClass = "bi bi-basket" },
                new RoomAmenity { Id = Guid.NewGuid(), Name = "Room Service", IconClass = "bi bi-bell" },
                new RoomAmenity { Id = Guid.NewGuid(), Name = "Bathrobe and Slippers", IconClass = "bi bi-patch-check" },
                new RoomAmenity { Id = Guid.NewGuid(), Name = "Complimentary Bottled Water", IconClass = "bi bi-droplet" },
                new RoomAmenity { Id = Guid.NewGuid(), Name = "High-Speed Internet", IconClass = "bi bi-wifi" },
                new RoomAmenity { Id = Guid.NewGuid(), Name = "Blackout Curtains", IconClass = "bi bi-slash" },
                new RoomAmenity { Id = Guid.NewGuid(), Name = "Soundproof Windows", IconClass = "bi bi-volume-mute" }
            );



            base.OnModelCreating(modelBuilder);


        }
    }


}
