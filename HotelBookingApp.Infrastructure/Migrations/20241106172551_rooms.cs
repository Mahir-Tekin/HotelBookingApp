using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelBookingApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class rooms : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Room_RoomTypes_RoomTypeId",
                table: "Room");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Room",
                table: "Room");

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

            migrationBuilder.RenameTable(
                name: "Room",
                newName: "Rooms");

            migrationBuilder.RenameIndex(
                name: "IX_Room_RoomTypeId",
                table: "Rooms",
                newName: "IX_Rooms_RoomTypeId");

            migrationBuilder.AlterColumn<string>(
                name: "RoomNumber",
                table: "Rooms",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rooms",
                table: "Rooms",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "29fb08be-b7a6-4d49-9c0d-1c917d2882af", null, "Admin", "ADMIN" },
                    { "34925736-eacb-4624-8934-2e8165c5e6ab", null, "Manager", "MANAGER" },
                    { "f603f8b1-8df0-4995-803c-6a3c18bbd4aa", null, "HotelAdmin", "HOTELADMIN" }
                });

            migrationBuilder.InsertData(
                table: "HotelAmenities",
                columns: new[] { "Id", "IconClass", "Name" },
                values: new object[,]
                {
                    { new Guid("019a9a25-3f37-4252-94ad-b1e326048f27"), "bi bi-car-front", "Parking" },
                    { new Guid("29cb77b9-3b8b-47d4-b34c-ebcfac0d6abb"), "bi bi-thermometer-sun", "Air Conditioning" },
                    { new Guid("2fda898d-3133-4143-a1e1-a5813ef8e06f"), "bi bi-megaphone", "Conference Room" },
                    { new Guid("483f8ffa-a77e-4c86-8afc-cb54a19ce656"), "bi bi-briefcase", "Business Center" },
                    { new Guid("4e56230d-1eb9-467d-90e2-19eb9f3e4354"), "bi bi-bar-chart-line", "Fitness Center" },
                    { new Guid("77e09615-3b06-4b9e-bfda-42f9954b645c"), "bi bi-wifi", "Free Wi-Fi" },
                    { new Guid("7e61c33c-3032-4c86-99d2-af4b5bdbecda"), "bi bi-water", "Swimming Pool" },
                    { new Guid("9c8d381e-7c71-4cf8-b4c4-bf8df2188b8b"), "bi bi-shop", "Restaurant" },
                    { new Guid("ac565131-0ae2-412d-a5f8-41fd09aef005"), "bi bi-basket", "Laundry Service" },
                    { new Guid("c7a0de2d-1764-4267-be98-db9bf698f1e0"), "bi bi-house-door", "Room Service" },
                    { new Guid("dc04d245-4abb-4e42-821f-7ac1a25d6dd9"), "bi bi-slash-circle", "Non-Smoking Rooms" },
                    { new Guid("e684f0c8-fec6-40df-872d-cd5203851912"), "bi bi-airplane-engines", "Airport Shuttle" }
                });

            migrationBuilder.InsertData(
                table: "RoomAmenity",
                columns: new[] { "Id", "IconClass", "Name" },
                values: new object[,]
                {
                    { new Guid("13128d3f-fb75-4443-8e5c-f3d7a13ce09a"), "bi bi-thermometer-sun", "Air Conditioning" },
                    { new Guid("2c6333a5-15f5-4798-a43c-3cdcbaff78ed"), "bi bi-basket", "Free Toiletries" },
                    { new Guid("327b9b36-6fc9-49c6-bad7-ef9825bd8bbc"), "bi bi-wifi", "High-Speed Internet" },
                    { new Guid("3a8c0bdb-fba3-467e-80e9-8dccb80cba32"), "bi bi-safe", "Safe Deposit Box" },
                    { new Guid("4e439e05-b909-429b-b172-597682088a76"), "bi bi-slash", "Blackout Curtains" },
                    { new Guid("64a58c77-cd2c-468b-a46a-772bd5625c10"), "bi bi-cup-straw", "Mini Bar" },
                    { new Guid("66faacfd-6506-4c51-a3d3-64cf0dadbe10"), "bi bi-table", "Work Desk" },
                    { new Guid("79a4fb23-90ed-4169-ad3e-b51f223984e8"), "bi bi-patch-check", "Bathrobe and Slippers" },
                    { new Guid("7e965fb4-da18-491f-bb3a-650dd0691df4"), "bi bi-wind", "Hair Dryer" },
                    { new Guid("7f204c90-b29d-4394-a87b-646d75018090"), "bi bi-house", "Iron and Ironing Board" },
                    { new Guid("90547c77-1d61-43ae-a9cd-dcf997efe720"), "bi bi-tv", "Television" },
                    { new Guid("9927fbe6-929a-4df4-a4f9-e66181a0a304"), "bi bi-volume-mute", "Soundproof Windows" },
                    { new Guid("d27d9453-343c-42a8-83ec-e05beb6a7834"), "bi bi-bell", "Room Service" },
                    { new Guid("f58fad08-6372-409f-b24f-c16682e15e68"), "bi bi-droplet", "Complimentary Bottled Water" },
                    { new Guid("f7576a20-69d2-4d18-b106-eebbade1a1ab"), "bi bi-cup-hot", "Coffee Maker" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_RoomTypes_RoomTypeId",
                table: "Rooms",
                column: "RoomTypeId",
                principalTable: "RoomTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_RoomTypes_RoomTypeId",
                table: "Rooms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rooms",
                table: "Rooms");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "29fb08be-b7a6-4d49-9c0d-1c917d2882af");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "34925736-eacb-4624-8934-2e8165c5e6ab");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f603f8b1-8df0-4995-803c-6a3c18bbd4aa");

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("019a9a25-3f37-4252-94ad-b1e326048f27"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("29cb77b9-3b8b-47d4-b34c-ebcfac0d6abb"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("2fda898d-3133-4143-a1e1-a5813ef8e06f"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("483f8ffa-a77e-4c86-8afc-cb54a19ce656"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("4e56230d-1eb9-467d-90e2-19eb9f3e4354"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("77e09615-3b06-4b9e-bfda-42f9954b645c"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("7e61c33c-3032-4c86-99d2-af4b5bdbecda"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("9c8d381e-7c71-4cf8-b4c4-bf8df2188b8b"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("ac565131-0ae2-412d-a5f8-41fd09aef005"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("c7a0de2d-1764-4267-be98-db9bf698f1e0"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("dc04d245-4abb-4e42-821f-7ac1a25d6dd9"));

            migrationBuilder.DeleteData(
                table: "HotelAmenities",
                keyColumn: "Id",
                keyValue: new Guid("e684f0c8-fec6-40df-872d-cd5203851912"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("13128d3f-fb75-4443-8e5c-f3d7a13ce09a"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("2c6333a5-15f5-4798-a43c-3cdcbaff78ed"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("327b9b36-6fc9-49c6-bad7-ef9825bd8bbc"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("3a8c0bdb-fba3-467e-80e9-8dccb80cba32"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("4e439e05-b909-429b-b172-597682088a76"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("64a58c77-cd2c-468b-a46a-772bd5625c10"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("66faacfd-6506-4c51-a3d3-64cf0dadbe10"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("79a4fb23-90ed-4169-ad3e-b51f223984e8"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("7e965fb4-da18-491f-bb3a-650dd0691df4"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("7f204c90-b29d-4394-a87b-646d75018090"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("90547c77-1d61-43ae-a9cd-dcf997efe720"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("9927fbe6-929a-4df4-a4f9-e66181a0a304"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("d27d9453-343c-42a8-83ec-e05beb6a7834"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("f58fad08-6372-409f-b24f-c16682e15e68"));

            migrationBuilder.DeleteData(
                table: "RoomAmenity",
                keyColumn: "Id",
                keyValue: new Guid("f7576a20-69d2-4d18-b106-eebbade1a1ab"));

            migrationBuilder.RenameTable(
                name: "Rooms",
                newName: "Room");

            migrationBuilder.RenameIndex(
                name: "IX_Rooms_RoomTypeId",
                table: "Room",
                newName: "IX_Room_RoomTypeId");

            migrationBuilder.AlterColumn<string>(
                name: "RoomNumber",
                table: "Room",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Room",
                table: "Room",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Room_RoomTypes_RoomTypeId",
                table: "Room",
                column: "RoomTypeId",
                principalTable: "RoomTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
