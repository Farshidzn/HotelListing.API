using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelListing.Migrations
{
    public partial class AddedDefaultRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "63a12d8b-4d51-4bd2-a365-78e8e5b76aa9", "e87dfa3e-97f5-4af3-9c77-5e84a053c9ee", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "74971f63-78d3-4f0e-9caf-dfb2123f85e0", "0ad2b7c4-0b9f-4b19-a946-adcce9273fc7", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "63a12d8b-4d51-4bd2-a365-78e8e5b76aa9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "74971f63-78d3-4f0e-9caf-dfb2123f85e0");
        }
    }
}
