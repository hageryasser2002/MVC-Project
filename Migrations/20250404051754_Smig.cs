using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_Projec2.Migrations
{
    /// <inheritdoc />
    public partial class Smig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "81377c2b-d844-490e-bfda-714b196d2cf6" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "81377c2b-d844-490e-bfda-714b196d2cf6");

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "Ateliers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "ImageURL",
                table: "Ateliers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "39e6bcdc-4692-4516-a214-c1af2d1e9da5", 0, "1acda782-be9b-4d95-bafe-56f9c35b9bec", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@example.com", true, null, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEC71SQYC8+ESUQSMeW/oXXNukP6b1z94velvFX1i2zgEpXF4NDjt0fB4hGuN9uKPsA==", "0123456789", true, "1f89edee-3a87-4f3b-a4d8-bbeec2e7709b", false, "admin@example.com" });

            migrationBuilder.UpdateData(
                table: "Ateliers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageURL",
                value: null);

            migrationBuilder.UpdateData(
                table: "Ateliers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageURL",
                value: null);

            migrationBuilder.UpdateData(
                table: "Ateliers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageURL",
                value: null);

            migrationBuilder.UpdateData(
                table: "Ateliers",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageURL",
                value: null);

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_at", "user_id" },
                values: new object[] { new DateTime(2025, 4, 4, 7, 17, 42, 582, DateTimeKind.Local).AddTicks(2315), "39e6bcdc-4692-4516-a214-c1af2d1e9da5" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                column: "user_id",
                value: "39e6bcdc-4692-4516-a214-c1af2d1e9da5");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_at", "user_id" },
                values: new object[] { new DateTime(2025, 4, 4, 7, 17, 42, 582, DateTimeKind.Local).AddTicks(2416), "39e6bcdc-4692-4516-a214-c1af2d1e9da5" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "39e6bcdc-4692-4516-a214-c1af2d1e9da5" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "39e6bcdc-4692-4516-a214-c1af2d1e9da5" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39e6bcdc-4692-4516-a214-c1af2d1e9da5");

            migrationBuilder.DropColumn(
                name: "ImageURL",
                table: "Ateliers");

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "Ateliers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "81377c2b-d844-490e-bfda-714b196d2cf6", 0, "6458177b-0491-45a6-a668-259185732e9f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@example.com", true, null, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEBciAKHsfwTUb2zjlZAvr9BR37WRHfRnA2/ISi+N/F0nwNlu8Kd78zq1HLMXHviehA==", "0123456789", true, "056512c3-331d-4962-bbb0-94e61b0a8080", false, "admin@example.com" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_at", "user_id" },
                values: new object[] { new DateTime(2025, 4, 4, 7, 6, 4, 633, DateTimeKind.Local).AddTicks(1078), "81377c2b-d844-490e-bfda-714b196d2cf6" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                column: "user_id",
                value: "81377c2b-d844-490e-bfda-714b196d2cf6");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_at", "user_id" },
                values: new object[] { new DateTime(2025, 4, 4, 7, 6, 4, 633, DateTimeKind.Local).AddTicks(1186), "81377c2b-d844-490e-bfda-714b196d2cf6" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "81377c2b-d844-490e-bfda-714b196d2cf6" });
        }
    }
}
