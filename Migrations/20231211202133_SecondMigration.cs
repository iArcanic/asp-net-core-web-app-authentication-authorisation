using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace aspnetcorewebappauthenticationauthorisation.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1ea438b6-6e5e-48a6-9d31-baa48d2ec274", null, "seller", "seller" },
                    { "8fd9f579-f5c0-4e37-88f3-d8bc40ef239f", null, "client", "client" },
                    { "bbed8ed2-3b18-406c-9b87-82614d749ae6", null, "admin", "admin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1ea438b6-6e5e-48a6-9d31-baa48d2ec274");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8fd9f579-f5c0-4e37-88f3-d8bc40ef239f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bbed8ed2-3b18-406c-9b87-82614d749ae6");
        }
    }
}
