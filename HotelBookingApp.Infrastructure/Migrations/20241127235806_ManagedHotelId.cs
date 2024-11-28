using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelBookingApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ManagedHotelId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<Guid>(
                name: "ManagedHotelId",
                table: "AspNetUsers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "557f2011-83be-44dc-a677-f1f0c9eedadf", null, "Admin", "ADMIN" },
                    { "9cc5d918-f1e2-4cc6-b86c-8858ea59801e", null, "Manager", "MANAGER" },
                    { "bd7b854e-b8d0-4539-b215-9b274bd9d838", null, "HotelAdmin", "HOTELADMIN" },
                    { "d5b9977d-545e-4005-97f8-70259af47a61", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "HotelAmenities",
                columns: new[] { "Id", "IconClass", "Name" },
                values: new object[,]
                {
                    { new Guid("2fa58e98-7821-46d4-8fec-236172715f02"), "bi bi-slash-circle", "Non-Smoking Rooms" },
                    { new Guid("45dd9b54-3f2d-456a-a67f-a3b4d8296480"), "bi bi-thermometer-sun", "Air Conditioning" },
                    { new Guid("4adebb18-3f42-4634-8b29-ff6fd7c88f3e"), "bi bi-basket", "Laundry Service" },
                    { new Guid("6e371b10-36c4-4acc-8574-4a25c146f87a"), "bi bi-house-door", "Room Service" },
                    { new Guid("715dc1c3-93f4-49c9-9ed0-855e7850336f"), "bi bi-bar-chart-line", "Fitness Center" },
                    { new Guid("76ad83e0-2437-4500-a96f-c21df7579c05"), "bi bi-megaphone", "Conference Room" },
                    { new Guid("91eda865-2185-4c67-8b7e-68f4669364ba"), "bi bi-car-front", "Parking" },
                    { new Guid("cd7bd4fb-7f80-4592-bb35-100821654395"), "bi bi-airplane-engines", "Airport Shuttle" },
                    { new Guid("cfef2866-5c13-4606-895f-8c83a5c93ab6"), "bi bi-water", "Swimming Pool" },
                    { new Guid("dfb0a1f4-9f3d-4002-b559-c2b9b1d6be9a"), "bi bi-wifi", "Free Wi-Fi" },
                    { new Guid("fa3fc855-97fa-4b28-ad48-477f49e5c619"), "bi bi-shop", "Restaurant" },
                    { new Guid("fad2901f-1758-43f5-a075-fc57025586d9"), "bi bi-briefcase", "Business Center" }
                });

            migrationBuilder.InsertData(
                table: "RoomAmenity",
                columns: new[] { "Id", "IconClass", "Name" },
                values: new object[,]
                {
                    { new Guid("19117628-ce65-42af-ad13-f2dad35f5afa"), "bi bi-cup-straw", "Mini Bar" },
                    { new Guid("4c245e8b-594e-4c9d-beba-27b997884e25"), "bi bi-basket", "Free Toiletries" },
                    { new Guid("4ed2f25e-d6e6-4143-ac48-4de0fa43e1a7"), "bi bi-tv", "Television" },
                    { new Guid("58b0f2bc-da72-426b-b615-bd2236906259"), "bi bi-cup-hot", "Coffee Maker" },
                    { new Guid("7151c97d-1dd0-4d17-9fa4-1ab5b84d6f0b"), "bi bi-house", "Iron and Ironing Board" },
                    { new Guid("76fa436d-f231-42b3-9cf5-f7cb713dc71d"), "bi bi-thermometer-sun", "Air Conditioning" },
                    { new Guid("8cad0948-da2d-4a2e-84a7-98b6ae7ac289"), "bi bi-patch-check", "Bathrobe and Slippers" },
                    { new Guid("981d1e53-e9fd-4d90-86d7-7bd767fbe66a"), "bi bi-wifi", "High-Speed Internet" },
                    { new Guid("ae0100d0-6b01-4581-aa98-d2c2b652725e"), "bi bi-slash", "Blackout Curtains" },
                    { new Guid("aec92d51-c0b5-46e5-b6fc-b83470e6b94d"), "bi bi-volume-mute", "Soundproof Windows" },
                    { new Guid("b066f80c-b6dd-4bee-a628-6a53e6cf2464"), "bi bi-table", "Work Desk" },
                    { new Guid("be27da4e-2209-4192-beea-4c699adcfe7d"), "bi bi-wind", "Hair Dryer" },
                    { new Guid("dc426314-a039-4d20-889e-1bdbc06d56b2"), "bi bi-bell", "Room Service" },
                    { new Guid("dee6bc60-db62-40b1-baa8-fa316512d1b1"), "bi bi-safe", "Safe Deposit Box" },
                    { new Guid("e848e3ec-63c3-4e0c-8f75-ecc17f486f99"), "bi bi-droplet", "Complimentary Bottled Water" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ManagedHotelId",
                table: "AspNetUsers",
                column: "ManagedHotelId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Hotels_ManagedHotelId",
                table: "AspNetUsers",
                column: "ManagedHotelId",
                principalTable: "Hotels",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Hotels_ManagedHotelId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ManagedHotelId",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "557f2011-83be-44dc-a677-f1f0c9eedadf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9cc5d918-f1e2-4cc6-b86c-8858ea59801e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd7b854e-b8d0-4539-b215-9b274bd9d838");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d5b9977d-545e-4005-97f8-70259af47a61");

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("2fa58e98-7821-46d4-8fec-236172715f02"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("45dd9b54-3f2d-456a-a67f-a3b4d8296480"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("4adebb18-3f42-4634-8b29-ff6fd7c88f3e"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("6e371b10-36c4-4acc-8574-4a25c146f87a"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("715dc1c3-93f4-49c9-9ed0-855e7850336f"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("76ad83e0-2437-4500-a96f-c21df7579c05"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("91eda865-2185-4c67-8b7e-68f4669364ba"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("cd7bd4fb-7f80-4592-bb35-100821654395"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("cfef2866-5c13-4606-895f-8c83a5c93ab6"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("dfb0a1f4-9f3d-4002-b559-c2b9b1d6be9a"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("fa3fc855-97fa-4b28-ad48-477f49e5c619"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("fad2901f-1758-43f5-a075-fc57025586d9"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("19117628-ce65-42af-ad13-f2dad35f5afa"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("4c245e8b-594e-4c9d-beba-27b997884e25"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("4ed2f25e-d6e6-4143-ac48-4de0fa43e1a7"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("58b0f2bc-da72-426b-b615-bd2236906259"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("7151c97d-1dd0-4d17-9fa4-1ab5b84d6f0b"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("76fa436d-f231-42b3-9cf5-f7cb713dc71d"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("8cad0948-da2d-4a2e-84a7-98b6ae7ac289"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("981d1e53-e9fd-4d90-86d7-7bd767fbe66a"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("ae0100d0-6b01-4581-aa98-d2c2b652725e"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("aec92d51-c0b5-46e5-b6fc-b83470e6b94d"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("b066f80c-b6dd-4bee-a628-6a53e6cf2464"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("be27da4e-2209-4192-beea-4c699adcfe7d"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("dc426314-a039-4d20-889e-1bdbc06d56b2"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("dee6bc60-db62-40b1-baa8-fa316512d1b1"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("e848e3ec-63c3-4e0c-8f75-ecc17f486f99"));

            migrationBuilder.DropColumn(
                name: "ManagedHotelId",
                table: "AspNetUsers");

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
    }
}
