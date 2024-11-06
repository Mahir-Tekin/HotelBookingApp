using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelBookingApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Added_Room_Amenityies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<string>(
                name: "Picture",
                table: "RoomTypes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "RoomAmenity",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IconClass = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomAmenity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoomRoomAmenities",
                columns: table => new
                {
                    AmenitiesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoomTypesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomRoomAmenities", x => new { x.AmenitiesId, x.RoomTypesId });
                    table.ForeignKey(
                        name: "FK_RoomRoomAmenities_RoomAmenity_AmenitiesId",
                        column: x => x.AmenitiesId,
                        principalTable: "RoomAmenity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoomRoomAmenities_RoomTypes_RoomTypesId",
                        column: x => x.RoomTypesId,
                        principalTable: "RoomTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "135aee72-c3f1-4fdb-8737-a74971e35751", null, "HotelAdmin", "HOTELADMIN" },
                    { "42db8436-53a6-472c-9226-ca7d1392c025", null, "Admin", "ADMIN" },
                    { "ee745fae-3731-4cc1-a15e-793560bc0f8e", null, "Manager", "MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "HotelAmenities",
                columns: new[] { "Id", "IconClass", "Name" },
                values: new object[,]
                {
                    { new Guid("20755e4b-0ca2-47fb-9ac0-f1c54be98646"), "bi bi-house-door", "Room Service" },
                    { new Guid("52ebb947-ad05-40b2-8a33-f01798ffeb60"), "bi bi-thermometer-sun", "Air Conditioning" },
                    { new Guid("6fc5ab98-bf28-4fe0-8f10-4a5582b5adda"), "bi bi-briefcase", "Business Center" },
                    { new Guid("8047b725-d1a7-4f9a-b72f-76789d16349b"), "bi bi-airplane-engines", "Airport Shuttle" },
                    { new Guid("8980951c-3919-43d8-91b5-46fab173917f"), "bi bi-wifi", "Free Wi-Fi" },
                    { new Guid("a1beb60b-1d41-4b8a-bf5d-583e937d2867"), "bi bi-slash-circle", "Non-Smoking Rooms" },
                    { new Guid("cd6a4764-9814-4658-8ecc-8d98ae73b5cd"), "bi bi-water", "Swimming Pool" },
                    { new Guid("cf0eadb6-79c8-45e8-8afb-db18cec48431"), "bi bi-basket", "Laundry Service" },
                    { new Guid("de0ce3ab-0678-4240-8e38-5f1f140b59d6"), "bi bi-shop", "Restaurant" },
                    { new Guid("f31a60c9-579f-4821-932d-359e27fd100b"), "bi bi-bar-chart-line", "Fitness Center" },
                    { new Guid("f372202b-a7fb-4ab2-a9a8-7817fd225045"), "bi bi-car-front", "Parking" },
                    { new Guid("fce910b9-d4ce-4434-8e1a-d0d399b45a01"), "bi bi-megaphone", "Conference Room" }
                });

            migrationBuilder.InsertData(
                table: "RoomAmenity",
                columns: new[] { "Id", "IconClass", "Name" },
                values: new object[,]
                {
                    { new Guid("05736782-638f-46d3-b1b6-8d5a0778f7bf"), "bi bi-slash", "Blackout Curtains" },
                    { new Guid("0a969e83-6624-4832-8b38-363a3c8e437c"), "bi bi-table", "Work Desk" },
                    { new Guid("0c4edb96-b534-4c0c-a9e4-cca237054d6f"), "bi bi-wifi", "High-Speed Internet" },
                    { new Guid("20f38536-d36a-43ed-a9ee-c836746ec5ef"), "bi bi-thermometer-sun", "Air Conditioning" },
                    { new Guid("30e56da7-50c4-40d8-9632-c5fee69ee92d"), "bi bi-wind", "Hair Dryer" },
                    { new Guid("33fe5392-dd8f-470e-878d-68c26e36db33"), "bi bi-patch-check", "Bathrobe and Slippers" },
                    { new Guid("465429ed-0024-4d59-89de-a25b85d9e6e2"), "bi bi-safe", "Safe Deposit Box" },
                    { new Guid("57e3ad07-6880-42af-8bc1-4c407cd72b84"), "bi bi-basket", "Free Toiletries" },
                    { new Guid("5c2bde13-7e77-4844-830d-f006ca79d52d"), "bi bi-cup-hot", "Coffee Maker" },
                    { new Guid("6cb94d74-ecca-4682-a4ae-739157b20e3c"), "bi bi-bell", "Room Service" },
                    { new Guid("899eb8bf-bf60-4105-a523-c1f267dbf5bf"), "bi bi-cup-straw", "Mini Bar" },
                    { new Guid("aeea7768-ae4e-4178-a5a0-821abeabac35"), "bi bi-droplet", "Complimentary Bottled Water" },
                    { new Guid("be768501-89d0-4d3b-82a1-a6b7fd928789"), "bi bi-house", "Iron and Ironing Board" },
                    { new Guid("e0de1a28-e88b-42af-9971-8a3baa489207"), "bi bi-tv", "Television" },
                    { new Guid("e6c3fb6f-12a6-4a7e-8fc8-60b7440935f0"), "bi bi-volume-mute", "Soundproof Windows" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_RoomRoomAmenities_RoomTypesId",
                table: "RoomRoomAmenities",
                column: "RoomTypesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RoomRoomAmenities");

            migrationBuilder.DropTable(
                name: "RoomAmenity");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "135aee72-c3f1-4fdb-8737-a74971e35751");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "42db8436-53a6-472c-9226-ca7d1392c025");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ee745fae-3731-4cc1-a15e-793560bc0f8e");

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("20755e4b-0ca2-47fb-9ac0-f1c54be98646"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("52ebb947-ad05-40b2-8a33-f01798ffeb60"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("6fc5ab98-bf28-4fe0-8f10-4a5582b5adda"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("8047b725-d1a7-4f9a-b72f-76789d16349b"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("8980951c-3919-43d8-91b5-46fab173917f"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("a1beb60b-1d41-4b8a-bf5d-583e937d2867"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("cd6a4764-9814-4658-8ecc-8d98ae73b5cd"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("cf0eadb6-79c8-45e8-8afb-db18cec48431"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("de0ce3ab-0678-4240-8e38-5f1f140b59d6"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("f31a60c9-579f-4821-932d-359e27fd100b"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("f372202b-a7fb-4ab2-a9a8-7817fd225045"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("fce910b9-d4ce-4434-8e1a-d0d399b45a01"));

            migrationBuilder.DropColumn(
                name: "Picture",
                table: "RoomTypes");

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
        }
    }
}
