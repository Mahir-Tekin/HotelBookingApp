using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelBookingApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class add_roles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8fb449a8-107b-4ae4-9beb-3e078b8458bc", null, "HotelAdmin", "HOTELADMIN" },
                    { "c7192d96-28a2-4f5d-a373-1444cd176454", null, "Admin", "ADMIN" },
                    { "d6e75f9e-387f-45e5-b22e-3cd25f0c4b9c", null, "Manager", "MANAGER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8fb449a8-107b-4ae4-9beb-3e078b8458bc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7192d96-28a2-4f5d-a373-1444cd176454");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d6e75f9e-387f-45e5-b22e-3cd25f0c4b9c");
        }
    }
}
