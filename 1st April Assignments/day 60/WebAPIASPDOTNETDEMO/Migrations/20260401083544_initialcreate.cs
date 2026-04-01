using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAPIASPDOTNETDEMO.Migrations
{
    /// <inheritdoc />
    public partial class initialcreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "171193fb-cb5f-4ba3-975e-fb8d472ec95a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d057026-7f74-4dde-b77a-8dc03aa10a54");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b200f684-3da8-4496-adbf-6960f0ea80c6");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1f10be1b-b033-4280-bd2e-2f166a36c744", "2", "User", "User" },
                    { "46cf7514-48ce-4819-b7e2-00ba3ad477f8", "1", "Admin", "Admin" },
                    { "f339a7fe-70b8-4c0f-b342-d209156a2703", "3", "HR", "HR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1f10be1b-b033-4280-bd2e-2f166a36c744");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "46cf7514-48ce-4819-b7e2-00ba3ad477f8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f339a7fe-70b8-4c0f-b342-d209156a2703");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "171193fb-cb5f-4ba3-975e-fb8d472ec95a", "2", "User", "User" },
                    { "3d057026-7f74-4dde-b77a-8dc03aa10a54", "1", "Admin", "Admin" },
                    { "b200f684-3da8-4496-adbf-6960f0ea80c6", "3", "HR", "HR" }
                });
        }
    }
}
