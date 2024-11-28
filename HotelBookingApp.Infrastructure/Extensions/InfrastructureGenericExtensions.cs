using HotelBookingApp.Core.Application.Interfaces.IServices;
using HotelBookingApp.Core.Application.Interfaces.Repositories;
using HotelBookingApp.Core.Application.Services;
using HotelBookingApp.Core.Domain.Entities;
using HotelBookingApp.Infrastructure.Persistence;
using HotelBookingApp.Infrastructure.Repositories;
using HotelBookingApp.Infrastructure.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HotelBookingApp.Infrastructure.Extensions
{
    public static class InfrastructureGenericExtensions
    {
        public static IServiceCollection AddApplicationDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            // Connection string yapılandırmasını al
            var connectionStrings = configuration.GetSection(ConnectionStringsOption.Key).Get<ConnectionStringsOption>();

            // DbContext ekle
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(connectionStrings!.SqlServer, sqlServerOptionsAction =>
                {
                    sqlServerOptionsAction.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName);
                }));

            // Identity yapılandırmasını ekle


            // Dependency Injection yapılandırmaları
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IHotelAmenityService, HotelAmenityService>();
            services.AddScoped<IHotelRepository, HotelRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IHotelService, HotelService>();
            services.AddScoped<IRoomTypeRepository, RoomTypeRepository>();
            services.AddScoped<IRoomTypeService, RoomTypeService>();
            services.AddScoped<IIdentityRepository, IdentityRepository>();
            services.AddScoped<IIdentityService, IdentityService>();
            services.AddScoped<IRoomAmenityService, RoomAmenityService>();
            services.AddScoped<IRoomService, RoomService>();
            services.AddScoped<IRoomRepository,RoomRepository>();
            services.AddScoped<IReservationRepository, ReservationRepository>();
            services.AddScoped<IReservationService, ReservationService>();


            return services;
        }
    }
}
