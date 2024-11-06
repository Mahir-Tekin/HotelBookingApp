using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelBookingApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class hotel_hotelroomtypr_relationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("05736782-638f-46d3-b1b6-8d5a0778f7bf"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("0a969e83-6624-4832-8b38-363a3c8e437c"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("0c4edb96-b534-4c0c-a9e4-cca237054d6f"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("20f38536-d36a-43ed-a9ee-c836746ec5ef"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("30e56da7-50c4-40d8-9632-c5fee69ee92d"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("33fe5392-dd8f-470e-878d-68c26e36db33"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("465429ed-0024-4d59-89de-a25b85d9e6e2"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("57e3ad07-6880-42af-8bc1-4c407cd72b84"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("5c2bde13-7e77-4844-830d-f006ca79d52d"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("6cb94d74-ecca-4682-a4ae-739157b20e3c"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("899eb8bf-bf60-4105-a523-c1f267dbf5bf"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("aeea7768-ae4e-4178-a5a0-821abeabac35"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("be768501-89d0-4d3b-82a1-a6b7fd928789"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("e0de1a28-e88b-42af-9971-8a3baa489207"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("e6c3fb6f-12a6-4a7e-8fc8-60b7440935f0"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1a9e5bdc-6ad9-4a5c-b617-b6263a98994c", null, "Manager", "MANAGER" },
                    { "422ed047-78d8-4844-a9f5-cca51181a7fa", null, "HotelAdmin", "HOTELADMIN" },
                    { "ed29a5bc-a0fd-424e-a5ac-ad984ccc3ade", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "HotelAmenities",
                columns: new[] { "Id", "IconClass", "Name" },
                values: new object[,]
                {
                    { new Guid("149233e8-f536-475b-b4cd-d5cc917d8489"), "bi bi-thermometer-sun", "Air Conditioning" },
                    { new Guid("4a3f60c1-24d8-4492-b3f9-7dd72723cf44"), "bi bi-car-front", "Parking" },
                    { new Guid("6a203e9c-734a-4555-a81a-bef8af81bf80"), "bi bi-shop", "Restaurant" },
                    { new Guid("72b3cba6-6f29-4b6a-ae6f-13eb43787e10"), "bi bi-bar-chart-line", "Fitness Center" },
                    { new Guid("7336d6a5-b586-46cd-b22a-42ea20d6c361"), "bi bi-airplane-engines", "Airport Shuttle" },
                    { new Guid("7e3f2641-9a56-4136-8afd-6fd3baadf403"), "bi bi-wifi", "Free Wi-Fi" },
                    { new Guid("82ad6a50-49a0-4429-8957-715e95bbbd49"), "bi bi-water", "Swimming Pool" },
                    { new Guid("9c66c16f-b93f-4c8f-b62e-7fbf6045b174"), "bi bi-house-door", "Room Service" },
                    { new Guid("9cb1d3f1-cf90-4287-8699-ece23fd3c549"), "bi bi-megaphone", "Conference Room" },
                    { new Guid("d35e4f7c-397e-4be3-baa9-d0e42424686b"), "bi bi-slash-circle", "Non-Smoking Rooms" },
                    { new Guid("dc7fa567-45ea-4d23-bcee-f69049bd36a8"), "bi bi-basket", "Laundry Service" },
                    { new Guid("f128b5f5-2d55-4256-a0a8-fd17b2eb00df"), "bi bi-briefcase", "Business Center" }
                });

            migrationBuilder.InsertData(
                table: "RoomAmenity",
                columns: new[] { "Id", "IconClass", "Name" },
                values: new object[,]
                {
                    { new Guid("03af9493-e001-4c6b-94e8-19c9001b91df"), "bi bi-droplet", "Complimentary Bottled Water" },
                    { new Guid("03bfb111-0165-4177-80ac-1d8157341282"), "bi bi-table", "Work Desk" },
                    { new Guid("27579980-648c-4348-a999-c658e9ca95bc"), "bi bi-tv", "Television" },
                    { new Guid("3a330ab1-fd09-4a02-80ed-8bc3659154da"), "bi bi-basket", "Free Toiletries" },
                    { new Guid("3e75b9ce-094b-455d-9a8b-d4d8ee4275a8"), "bi bi-wind", "Hair Dryer" },
                    { new Guid("5994484d-32ac-4ac2-a179-cd93fb04c011"), "bi bi-cup-straw", "Mini Bar" },
                    { new Guid("7e623073-df55-407f-8d16-40cb63f27fb2"), "bi bi-house", "Iron and Ironing Board" },
                    { new Guid("85f71c3c-7d18-41c4-a80d-755dbfe0dc32"), "bi bi-safe", "Safe Deposit Box" },
                    { new Guid("a210df25-0550-4d14-b571-3d17ce576163"), "bi bi-wifi", "High-Speed Internet" },
                    { new Guid("b4f1fcb5-16f5-4437-8764-0ce418aea73e"), "bi bi-volume-mute", "Soundproof Windows" },
                    { new Guid("b9f69a6a-df43-4ee3-b650-4a8ebf643601"), "bi bi-thermometer-sun", "Air Conditioning" },
                    { new Guid("dbfa96fc-a157-4b75-9082-b593dfac1c1e"), "bi bi-slash", "Blackout Curtains" },
                    { new Guid("e1dc3683-0b35-4047-82ce-540b3ed51aee"), "bi bi-patch-check", "Bathrobe and Slippers" },
                    { new Guid("f9963bd7-b0a5-4b08-a6fe-c7216545c40b"), "bi bi-cup-hot", "Coffee Maker" },
                    { new Guid("fd529972-2e60-4096-987e-ed4460cb5ef1"), "bi bi-bell", "Room Service" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1a9e5bdc-6ad9-4a5c-b617-b6263a98994c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "422ed047-78d8-4844-a9f5-cca51181a7fa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ed29a5bc-a0fd-424e-a5ac-ad984ccc3ade");

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("149233e8-f536-475b-b4cd-d5cc917d8489"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("4a3f60c1-24d8-4492-b3f9-7dd72723cf44"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("6a203e9c-734a-4555-a81a-bef8af81bf80"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("72b3cba6-6f29-4b6a-ae6f-13eb43787e10"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("7336d6a5-b586-46cd-b22a-42ea20d6c361"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("7e3f2641-9a56-4136-8afd-6fd3baadf403"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("82ad6a50-49a0-4429-8957-715e95bbbd49"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("9c66c16f-b93f-4c8f-b62e-7fbf6045b174"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("9cb1d3f1-cf90-4287-8699-ece23fd3c549"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("d35e4f7c-397e-4be3-baa9-d0e42424686b"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("dc7fa567-45ea-4d23-bcee-f69049bd36a8"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("f128b5f5-2d55-4256-a0a8-fd17b2eb00df"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("03af9493-e001-4c6b-94e8-19c9001b91df"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("03bfb111-0165-4177-80ac-1d8157341282"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("27579980-648c-4348-a999-c658e9ca95bc"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("3a330ab1-fd09-4a02-80ed-8bc3659154da"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("3e75b9ce-094b-455d-9a8b-d4d8ee4275a8"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("5994484d-32ac-4ac2-a179-cd93fb04c011"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("7e623073-df55-407f-8d16-40cb63f27fb2"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("85f71c3c-7d18-41c4-a80d-755dbfe0dc32"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("a210df25-0550-4d14-b571-3d17ce576163"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("b4f1fcb5-16f5-4437-8764-0ce418aea73e"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("b9f69a6a-df43-4ee3-b650-4a8ebf643601"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("dbfa96fc-a157-4b75-9082-b593dfac1c1e"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("e1dc3683-0b35-4047-82ce-540b3ed51aee"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("f9963bd7-b0a5-4b08-a6fe-c7216545c40b"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("fd529972-2e60-4096-987e-ed4460cb5ef1"));

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
        }
    }
}
