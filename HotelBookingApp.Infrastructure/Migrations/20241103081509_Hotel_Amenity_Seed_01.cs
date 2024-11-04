using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelBookingApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Hotel_Amenity_Seed_01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "28630c02-27e4-4be9-92be-55e6f42f7b9d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "92bfa0ca-e0c9-406c-baac-ec4802b39cc2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c6c7dac8-f490-408e-a6f4-3a75168a351c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6e6b0f88-7db3-472e-9bb0-ffb67a3fca9f", null, "Admin", "ADMIN" },
                    { "8432b0a5-3419-4058-b0f1-7ca1dfcf8ed2", null, "HotelAdmin", "HOTELADMIN" },
                    { "cf8ed9d2-7d4a-4830-b658-68261ee8e767", null, "Manager", "MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "HotelAmenities",
                columns: new[] { "Id", "IconClass", "Name" },
                values: new object[,]
                {
                    { new Guid("32945138-968d-480e-b298-44e01c8fac74"), "bi bi-bar-chart-line", "Fitness Center" },
                    { new Guid("338d30b7-7ec6-4f11-90ee-65a1c99b5d55"), "bi bi-wheelchair", "Wheelchair Accessible" },
                    { new Guid("41f15769-90d8-48b4-8eff-c9db833a6e81"), "bi bi-car-front", "Parking" },
                    { new Guid("4af4d7fc-2da5-4b71-8323-f5eb03f06990"), "bi bi-wifi", "Free Wi-Fi" },
                    { new Guid("545b0937-2eaa-410b-a31d-053e8e471435"), "bi bi-briefcase", "Business Center" },
                    { new Guid("74aad19b-0213-4a39-8ce4-c8cc3fafd6ab"), "bi bi-spa", "Spa" },
                    { new Guid("7efe3677-1017-4399-86cd-dfc3546f7fb9"), "bi bi-thermometer-sun", "Air Conditioning" },
                    { new Guid("8992adf8-f948-4bbd-b043-42b5d45dd5d3"), "bi bi-basket", "Laundry Service" },
                    { new Guid("9697c68e-426d-4e3f-a2f0-9606d46173f9"), "bi bi-house-door", "Room Service" },
                    { new Guid("9aedccc1-6fdd-4a0e-ac93-ee30080b1924"), "bi bi-megaphone", "Conference Room" },
                    { new Guid("ae9ce1c5-fdc7-4609-8cc2-efb5df30ba96"), "bi bi-water", "Swimming Pool" },
                    { new Guid("bb5b1f44-8741-4a16-b107-982564bec9c7"), "bi bi-slash-circle", "Non-Smoking Rooms" },
                    { new Guid("be785c63-6265-4f1e-a16d-684b70a1aa04"), "bi bi-airplane-engines", "Airport Shuttle" },
                    { new Guid("c9e4b409-1e18-45dc-a654-7c2a550b3220"), "bi bi-paw", "Pet Friendly" },
                    { new Guid("d45b1a01-8ba8-49bf-a7bc-efe2e3c13cc7"), "bi bi-elevator", "Elevator" },
                    { new Guid("eff7116e-e998-4ceb-8e00-e1041ff3401e"), "bi bi-cup-straw", "Bar/Lounge" },
                    { new Guid("f7a3c8c3-62bd-4f74-b4b1-d15d7adc6beb"), "bi bi-shop", "Restaurant" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6e6b0f88-7db3-472e-9bb0-ffb67a3fca9f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8432b0a5-3419-4058-b0f1-7ca1dfcf8ed2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf8ed9d2-7d4a-4830-b658-68261ee8e767");

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("32945138-968d-480e-b298-44e01c8fac74"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("338d30b7-7ec6-4f11-90ee-65a1c99b5d55"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("41f15769-90d8-48b4-8eff-c9db833a6e81"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("4af4d7fc-2da5-4b71-8323-f5eb03f06990"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("545b0937-2eaa-410b-a31d-053e8e471435"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("74aad19b-0213-4a39-8ce4-c8cc3fafd6ab"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("7efe3677-1017-4399-86cd-dfc3546f7fb9"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("8992adf8-f948-4bbd-b043-42b5d45dd5d3"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("9697c68e-426d-4e3f-a2f0-9606d46173f9"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("9aedccc1-6fdd-4a0e-ac93-ee30080b1924"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("ae9ce1c5-fdc7-4609-8cc2-efb5df30ba96"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("bb5b1f44-8741-4a16-b107-982564bec9c7"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("be785c63-6265-4f1e-a16d-684b70a1aa04"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("c9e4b409-1e18-45dc-a654-7c2a550b3220"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("d45b1a01-8ba8-49bf-a7bc-efe2e3c13cc7"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("eff7116e-e998-4ceb-8e00-e1041ff3401e"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("f7a3c8c3-62bd-4f74-b4b1-d15d7adc6beb"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "28630c02-27e4-4be9-92be-55e6f42f7b9d", null, "Manager", "MANAGER" },
                    { "92bfa0ca-e0c9-406c-baac-ec4802b39cc2", null, "HotelAdmin", "HOTELADMIN" },
                    { "c6c7dac8-f490-408e-a6f4-3a75168a351c", null, "Admin", "ADMIN" }
                });
        }
    }
}
