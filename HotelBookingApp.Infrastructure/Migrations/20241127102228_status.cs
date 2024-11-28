using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelBookingApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class status : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "50023d8b-3dfe-4d91-a6e3-a65e7b42def7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "519f622b-6c25-44c2-907f-38bf8a507fe3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6cc48c9f-eaa9-4a32-815a-29a6f8e88bbc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "77a42f3c-fb61-416c-83e6-4ee5b375c27a");

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("00f18096-1b8c-4efe-bbd0-cbb97d53d884"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("28b8121a-a9ab-45fd-98b0-dbb3b13db04e"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("33cabc61-973a-4ed8-9960-2364a311499f"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("5281d60e-6906-451b-a123-103385407fb5"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("6379a130-d14b-4b5b-a45e-e3eae49a0aea"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("7d9d2c90-c8fc-4043-811f-3e0c9c7d47e7"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("9af2df14-a1ae-4a66-9e64-99b4173cb09e"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("b04a7ffc-762b-4771-ba33-50e7132d673c"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("b7a89adf-3260-467b-8bb0-c60a3d2cac56"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("c48b2911-e76d-4839-829b-0999456d4a18"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("d2482bc4-ba21-44dc-aeb8-c24401b753d2"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("fe11779f-1eee-4cbc-937d-d3114fee0ad9"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("049c9bf4-638d-48d5-a383-a595d6919773"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("04b871c6-9efa-48b7-b0bc-3ba6c7103ce0"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("203eaa0d-e63c-4265-9b48-467bc8cdd66f"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("20b5382b-3bb1-4347-b8bc-28a961953832"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("2e0d91ca-fcfd-49f3-9280-2543639cc6a1"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("3b7338b9-828c-42e8-91fb-5f40171aed7f"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("3e5f209e-07d5-4445-9aea-dc3d2bda072a"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("3fcdffda-1611-4078-ae0b-5f9a38a2b94b"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("4114f912-5b85-4cea-b43e-8ee46d2fb4c4"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("5f7ab81d-b6a9-4c8e-b007-877f20e1a642"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("60d95184-3799-4eb8-8abc-780f874a2446"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("72f8f6f6-54f5-439f-838b-5136c5049528"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("8ccbbf15-dcff-43a6-8242-2dc9575d7a42"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("91ab5afe-bf18-43d0-b197-199d554c5934"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("9c1f4e38-1e23-4be8-8e25-73608c1d64a0"));

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Reservations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "69fc0b33-5ec5-4743-a617-2a123a6cec9f", null, "User", "USER" },
                    { "6b60b0de-6f1d-488a-9d18-9e3df6f9f60b", null, "Manager", "MANAGER" },
                    { "885c1f75-7d44-4daa-ab27-1aa4cdb3813a", null, "HotelAdmin", "HOTELADMIN" },
                    { "c4fec931-decd-4917-ba8e-8ce1e4a7b2a8", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "HotelAmenities",
                columns: new[] { "Id", "IconClass", "Name" },
                values: new object[,]
                {
                    { new Guid("157108e4-232c-4a7d-bad6-69d1a2319fcb"), "bi bi-shop", "Restaurant" },
                    { new Guid("2da9d714-6b7c-4d33-9c4a-8894683fa5d6"), "bi bi-slash-circle", "Non-Smoking Rooms" },
                    { new Guid("349c39f8-8fd9-4fa8-849f-f855baa5ae3c"), "bi bi-car-front", "Parking" },
                    { new Guid("421c0adb-25ac-4eed-aa2b-723ba85eb479"), "bi bi-megaphone", "Conference Room" },
                    { new Guid("6abfe0ff-230a-4f5b-b132-329ce8862cf5"), "bi bi-house-door", "Room Service" },
                    { new Guid("9034ee12-0f38-4315-ae24-e370c88e19c1"), "bi bi-airplane-engines", "Airport Shuttle" },
                    { new Guid("9acde39d-bab2-4826-9881-78f21b4672ff"), "bi bi-water", "Swimming Pool" },
                    { new Guid("a10ed42b-f4df-4676-85fc-4f7e4970344d"), "bi bi-bar-chart-line", "Fitness Center" },
                    { new Guid("c7fdc54d-31f9-4d90-a3bf-e87abfb9d473"), "bi bi-thermometer-sun", "Air Conditioning" },
                    { new Guid("cf06254a-5eef-4220-957a-aa7013d93db3"), "bi bi-basket", "Laundry Service" },
                    { new Guid("d2bfd9e5-a272-462f-9ad9-2bb376cb1efa"), "bi bi-wifi", "Free Wi-Fi" },
                    { new Guid("f9c0728a-a871-4eb4-a7f6-d4e4d37da715"), "bi bi-briefcase", "Business Center" }
                });

            migrationBuilder.InsertData(
                table: "RoomAmenity",
                columns: new[] { "Id", "IconClass", "Name" },
                values: new object[,]
                {
                    { new Guid("03e1f345-53f8-4bc6-9e3b-fa0ad862ccba"), "bi bi-bell", "Room Service" },
                    { new Guid("0931743d-66f0-4d0b-be76-45933adce9d5"), "bi bi-cup-straw", "Mini Bar" },
                    { new Guid("125abd79-60b2-4dd5-97a0-93ca4d05b9f9"), "bi bi-basket", "Free Toiletries" },
                    { new Guid("1b32f603-8372-4aa1-9a01-35a2cf23ac9b"), "bi bi-safe", "Safe Deposit Box" },
                    { new Guid("1d12767d-7bed-4ead-9492-fa9b279614eb"), "bi bi-wifi", "High-Speed Internet" },
                    { new Guid("239038d2-fc22-433c-abf6-61fc6d9c9e15"), "bi bi-house", "Iron and Ironing Board" },
                    { new Guid("827553d9-30db-4c2a-8300-6e1df06444a6"), "bi bi-tv", "Television" },
                    { new Guid("bc515858-e92c-4c6e-82c5-de0560d0fba5"), "bi bi-table", "Work Desk" },
                    { new Guid("c18c6a79-7ee2-40b2-b788-647dd89d08ee"), "bi bi-patch-check", "Bathrobe and Slippers" },
                    { new Guid("c2fe2583-a297-4f31-a8f0-bdc8124f0654"), "bi bi-cup-hot", "Coffee Maker" },
                    { new Guid("c34001f1-dfb9-4117-a1e2-769ddc656273"), "bi bi-thermometer-sun", "Air Conditioning" },
                    { new Guid("c71698c9-bd3e-4cb2-9998-1bdfe51a7984"), "bi bi-volume-mute", "Soundproof Windows" },
                    { new Guid("d775ae2e-92b1-4c5e-88f7-1207c9ff1389"), "bi bi-slash", "Blackout Curtains" },
                    { new Guid("e8711a39-2927-4546-a129-34edfe8e3b4b"), "bi bi-wind", "Hair Dryer" },
                    { new Guid("f926e53f-b283-4121-a42a-45a4984878e6"), "bi bi-droplet", "Complimentary Bottled Water" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "69fc0b33-5ec5-4743-a617-2a123a6cec9f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6b60b0de-6f1d-488a-9d18-9e3df6f9f60b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "885c1f75-7d44-4daa-ab27-1aa4cdb3813a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c4fec931-decd-4917-ba8e-8ce1e4a7b2a8");

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("157108e4-232c-4a7d-bad6-69d1a2319fcb"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("2da9d714-6b7c-4d33-9c4a-8894683fa5d6"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("349c39f8-8fd9-4fa8-849f-f855baa5ae3c"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("421c0adb-25ac-4eed-aa2b-723ba85eb479"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("6abfe0ff-230a-4f5b-b132-329ce8862cf5"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("9034ee12-0f38-4315-ae24-e370c88e19c1"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("9acde39d-bab2-4826-9881-78f21b4672ff"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("a10ed42b-f4df-4676-85fc-4f7e4970344d"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("c7fdc54d-31f9-4d90-a3bf-e87abfb9d473"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("cf06254a-5eef-4220-957a-aa7013d93db3"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("d2bfd9e5-a272-462f-9ad9-2bb376cb1efa"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("f9c0728a-a871-4eb4-a7f6-d4e4d37da715"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("03e1f345-53f8-4bc6-9e3b-fa0ad862ccba"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("0931743d-66f0-4d0b-be76-45933adce9d5"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("125abd79-60b2-4dd5-97a0-93ca4d05b9f9"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("1b32f603-8372-4aa1-9a01-35a2cf23ac9b"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("1d12767d-7bed-4ead-9492-fa9b279614eb"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("239038d2-fc22-433c-abf6-61fc6d9c9e15"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("827553d9-30db-4c2a-8300-6e1df06444a6"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("bc515858-e92c-4c6e-82c5-de0560d0fba5"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("c18c6a79-7ee2-40b2-b788-647dd89d08ee"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("c2fe2583-a297-4f31-a8f0-bdc8124f0654"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("c34001f1-dfb9-4117-a1e2-769ddc656273"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("c71698c9-bd3e-4cb2-9998-1bdfe51a7984"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("d775ae2e-92b1-4c5e-88f7-1207c9ff1389"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("e8711a39-2927-4546-a129-34edfe8e3b4b"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("f926e53f-b283-4121-a42a-45a4984878e6"));

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Reservations");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "50023d8b-3dfe-4d91-a6e3-a65e7b42def7", null, "HotelAdmin", "HOTELADMIN" },
                    { "519f622b-6c25-44c2-907f-38bf8a507fe3", null, "Manager", "MANAGER" },
                    { "6cc48c9f-eaa9-4a32-815a-29a6f8e88bbc", null, "User", "USER" },
                    { "77a42f3c-fb61-416c-83e6-4ee5b375c27a", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "HotelAmenities",
                columns: new[] { "Id", "IconClass", "Name" },
                values: new object[,]
                {
                    { new Guid("00f18096-1b8c-4efe-bbd0-cbb97d53d884"), "bi bi-car-front", "Parking" },
                    { new Guid("28b8121a-a9ab-45fd-98b0-dbb3b13db04e"), "bi bi-megaphone", "Conference Room" },
                    { new Guid("33cabc61-973a-4ed8-9960-2364a311499f"), "bi bi-slash-circle", "Non-Smoking Rooms" },
                    { new Guid("5281d60e-6906-451b-a123-103385407fb5"), "bi bi-thermometer-sun", "Air Conditioning" },
                    { new Guid("6379a130-d14b-4b5b-a45e-e3eae49a0aea"), "bi bi-basket", "Laundry Service" },
                    { new Guid("7d9d2c90-c8fc-4043-811f-3e0c9c7d47e7"), "bi bi-airplane-engines", "Airport Shuttle" },
                    { new Guid("9af2df14-a1ae-4a66-9e64-99b4173cb09e"), "bi bi-shop", "Restaurant" },
                    { new Guid("b04a7ffc-762b-4771-ba33-50e7132d673c"), "bi bi-bar-chart-line", "Fitness Center" },
                    { new Guid("b7a89adf-3260-467b-8bb0-c60a3d2cac56"), "bi bi-wifi", "Free Wi-Fi" },
                    { new Guid("c48b2911-e76d-4839-829b-0999456d4a18"), "bi bi-briefcase", "Business Center" },
                    { new Guid("d2482bc4-ba21-44dc-aeb8-c24401b753d2"), "bi bi-water", "Swimming Pool" },
                    { new Guid("fe11779f-1eee-4cbc-937d-d3114fee0ad9"), "bi bi-house-door", "Room Service" }
                });

            migrationBuilder.InsertData(
                table: "RoomAmenity",
                columns: new[] { "Id", "IconClass", "Name" },
                values: new object[,]
                {
                    { new Guid("049c9bf4-638d-48d5-a383-a595d6919773"), "bi bi-tv", "Television" },
                    { new Guid("04b871c6-9efa-48b7-b0bc-3ba6c7103ce0"), "bi bi-bell", "Room Service" },
                    { new Guid("203eaa0d-e63c-4265-9b48-467bc8cdd66f"), "bi bi-volume-mute", "Soundproof Windows" },
                    { new Guid("20b5382b-3bb1-4347-b8bc-28a961953832"), "bi bi-thermometer-sun", "Air Conditioning" },
                    { new Guid("2e0d91ca-fcfd-49f3-9280-2543639cc6a1"), "bi bi-table", "Work Desk" },
                    { new Guid("3b7338b9-828c-42e8-91fb-5f40171aed7f"), "bi bi-wifi", "High-Speed Internet" },
                    { new Guid("3e5f209e-07d5-4445-9aea-dc3d2bda072a"), "bi bi-slash", "Blackout Curtains" },
                    { new Guid("3fcdffda-1611-4078-ae0b-5f9a38a2b94b"), "bi bi-wind", "Hair Dryer" },
                    { new Guid("4114f912-5b85-4cea-b43e-8ee46d2fb4c4"), "bi bi-patch-check", "Bathrobe and Slippers" },
                    { new Guid("5f7ab81d-b6a9-4c8e-b007-877f20e1a642"), "bi bi-safe", "Safe Deposit Box" },
                    { new Guid("60d95184-3799-4eb8-8abc-780f874a2446"), "bi bi-house", "Iron and Ironing Board" },
                    { new Guid("72f8f6f6-54f5-439f-838b-5136c5049528"), "bi bi-droplet", "Complimentary Bottled Water" },
                    { new Guid("8ccbbf15-dcff-43a6-8242-2dc9575d7a42"), "bi bi-cup-straw", "Mini Bar" },
                    { new Guid("91ab5afe-bf18-43d0-b197-199d554c5934"), "bi bi-basket", "Free Toiletries" },
                    { new Guid("9c1f4e38-1e23-4be8-8e25-73608c1d64a0"), "bi bi-cup-hot", "Coffee Maker" }
                });
        }
    }
}
