using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelBookingApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addpicture : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Picture",
                table: "Hotels",
                type: "nvarchar(max)",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Picture",
                table: "Hotels");

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
    }
}
