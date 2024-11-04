using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelBookingApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class add_amenity_to_hotels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HotelHotelAmenities_HotelAmenities_AmenityId",
                table: "HotelHotelAmenities");

            migrationBuilder.DropForeignKey(
                name: "FK_HotelHotelAmenities_Hotels_HotelId",
                table: "HotelHotelAmenities");

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

            migrationBuilder.RenameColumn(
                name: "AmenityId",
                table: "HotelHotelAmenities",
                newName: "HotelsId");

            migrationBuilder.RenameColumn(
                name: "HotelId",
                table: "HotelHotelAmenities",
                newName: "AmenitiesId");

            migrationBuilder.RenameIndex(
                name: "IX_HotelHotelAmenities_AmenityId",
                table: "HotelHotelAmenities",
                newName: "IX_HotelHotelAmenities_HotelsId");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5b6995ef-116b-4003-87cb-d08062e478db", null, "HotelAdmin", "HOTELADMIN" },
                    { "805722ff-6be3-44ba-9f63-698a27cce5ab", null, "Admin", "ADMIN" },
                    { "f566278d-6617-4866-a5ba-e4b7514c22b8", null, "Manager", "MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "HotelAmenities",
                columns: new[] { "Id", "IconClass", "Name" },
                values: new object[,]
                {
                    { new Guid("01d73cae-ecdb-4649-a3cc-40da811ac08a"), "bi bi-water", "Swimming Pool" },
                    { new Guid("0741ea92-5b6d-422a-abf1-a990e40a3908"), "bi bi-wifi", "Free Wi-Fi" },
                    { new Guid("5cde769d-cf14-4de9-b787-4ded23c701b4"), "bi bi-briefcase", "Business Center" },
                    { new Guid("6caa3bba-d357-4ce3-ab96-6472bc2eed94"), "bi bi-bar-chart-line", "Fitness Center" },
                    { new Guid("8095847c-a330-4256-9242-420c4c915004"), "bi bi-house-door", "Room Service" },
                    { new Guid("8fc7d789-63bc-4d2e-83c4-5f379c97dc27"), "bi bi-car-front", "Parking" },
                    { new Guid("aced1657-d88f-4b35-892a-6bedda07c690"), "bi bi-thermometer-sun", "Air Conditioning" },
                    { new Guid("af91b591-1699-413b-9995-8d8ecb36b1fc"), "bi bi-megaphone", "Conference Room" },
                    { new Guid("b1bd3a2e-e99e-4176-9109-dd5330b805cd"), "bi bi-airplane-engines", "Airport Shuttle" },
                    { new Guid("b35ec3de-2441-42f3-90ee-242e860f0d0f"), "bi bi-basket", "Laundry Service" },
                    { new Guid("d65cadd3-65b6-4b77-acd5-79e2720a7b9e"), "bi bi-shop", "Restaurant" },
                    { new Guid("eb8184ee-4e89-4fb8-a372-bf2225b05676"), "bi bi-slash-circle", "Non-Smoking Rooms" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_HotelHotelAmenities_HotelAmenities_AmenitiesId",
                table: "HotelHotelAmenities",
                column: "AmenitiesId",
                principalTable: "HotelAmenities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HotelHotelAmenities_Hotels_HotelsId",
                table: "HotelHotelAmenities",
                column: "HotelsId",
                principalTable: "Hotels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HotelHotelAmenities_HotelAmenities_AmenitiesId",
                table: "HotelHotelAmenities");

            migrationBuilder.DropForeignKey(
                name: "FK_HotelHotelAmenities_Hotels_HotelsId",
                table: "HotelHotelAmenities");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b6995ef-116b-4003-87cb-d08062e478db");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "805722ff-6be3-44ba-9f63-698a27cce5ab");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f566278d-6617-4866-a5ba-e4b7514c22b8");

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("01d73cae-ecdb-4649-a3cc-40da811ac08a"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("0741ea92-5b6d-422a-abf1-a990e40a3908"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("5cde769d-cf14-4de9-b787-4ded23c701b4"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("6caa3bba-d357-4ce3-ab96-6472bc2eed94"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("8095847c-a330-4256-9242-420c4c915004"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("8fc7d789-63bc-4d2e-83c4-5f379c97dc27"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("aced1657-d88f-4b35-892a-6bedda07c690"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("af91b591-1699-413b-9995-8d8ecb36b1fc"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("b1bd3a2e-e99e-4176-9109-dd5330b805cd"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("b35ec3de-2441-42f3-90ee-242e860f0d0f"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("d65cadd3-65b6-4b77-acd5-79e2720a7b9e"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("eb8184ee-4e89-4fb8-a372-bf2225b05676"));

            migrationBuilder.RenameColumn(
                name: "HotelsId",
                table: "HotelHotelAmenities",
                newName: "AmenityId");

            migrationBuilder.RenameColumn(
                name: "AmenitiesId",
                table: "HotelHotelAmenities",
                newName: "HotelId");

            migrationBuilder.RenameIndex(
                name: "IX_HotelHotelAmenities_HotelsId",
                table: "HotelHotelAmenities",
                newName: "IX_HotelHotelAmenities_AmenityId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_HotelHotelAmenities_HotelAmenities_AmenityId",
                table: "HotelHotelAmenities",
                column: "AmenityId",
                principalTable: "HotelAmenities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HotelHotelAmenities_Hotels_HotelId",
                table: "HotelHotelAmenities",
                column: "HotelId",
                principalTable: "Hotels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
