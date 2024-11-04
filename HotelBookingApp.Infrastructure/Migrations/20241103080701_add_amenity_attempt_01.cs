using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelBookingApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class add_amenity_attempt_01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "685d01f9-afdb-4dcd-bf17-de1ef64ca1ed");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca02849a-24c7-4f0c-8601-4bf69d46a695");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e22da4a7-cb5f-49dc-a0ea-c0f27e071ebb");

            migrationBuilder.CreateTable(
                name: "HotelAmenities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IconClass = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelAmenities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HotelHotelAmenities",
                columns: table => new
                {
                    HotelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AmenityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelHotelAmenities", x => new { x.HotelId, x.AmenityId });
                    table.ForeignKey(
                        name: "FK_HotelHotelAmenities_HotelAmenities_AmenityId",
                        column: x => x.AmenityId,
                        principalTable: "HotelAmenities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HotelHotelAmenities_Hotels_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "28630c02-27e4-4be9-92be-55e6f42f7b9d", null, "Manager", "MANAGER" },
                    { "92bfa0ca-e0c9-406c-baac-ec4802b39cc2", null, "HotelAdmin", "HOTELADMIN" },
                    { "c6c7dac8-f490-408e-a6f4-3a75168a351c", null, "Admin", "ADMIN" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_HotelHotelAmenities_AmenityId",
                table: "HotelHotelAmenities",
                column: "AmenityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HotelHotelAmenities");

            migrationBuilder.DropTable(
                name: "HotelAmenities");

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
                    { "685d01f9-afdb-4dcd-bf17-de1ef64ca1ed", null, "Manager", "MANAGER" },
                    { "ca02849a-24c7-4f0c-8601-4bf69d46a695", null, "Admin", "ADMIN" },
                    { "e22da4a7-cb5f-49dc-a0ea-c0f27e071ebb", null, "HotelAdmin", "HOTELADMIN" }
                });
        }
    }
}
