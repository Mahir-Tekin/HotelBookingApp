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


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new HotelConfiguration());
            modelBuilder.ApplyConfiguration(new RoomTypeConfiguration());
            modelBuilder.ApplyConfiguration(new HotelAmenityConfiguration());

            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole { Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Name = "HotelAdmin", NormalizedName = "HOTELADMIN" },
                new IdentityRole { Name = "Manager", NormalizedName = "MANAGER" }
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


            base.OnModelCreating(modelBuilder);


        }
    }


}
