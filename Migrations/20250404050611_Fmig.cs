using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_Projec2.Migrations
{
    /// <inheritdoc />
    public partial class Fmig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "1643b6a6-52b2-44a0-9758-004c6a6e717e" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1643b6a6-52b2-44a0-9758-004c6a6e717e");

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
                columns: new[] { "Created_at", "user_id" },
                values: new object[] { new DateTime(2025, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), "81377c2b-d844-490e-bfda-714b196d2cf6" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "81377c2b-d844-490e-bfda-714b196d2cf6" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "81377c2b-d844-490e-bfda-714b196d2cf6");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1643b6a6-52b2-44a0-9758-004c6a6e717e", 0, "73b7bebe-dcde-4e01-a897-f39ff576d3c8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@example.com", true, null, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEFiBChZ5LrlEnVMKlDXNDAZQ828nh9HueYvddRrif4AS4jxEs1rl8yrHOz6bDECxag==", "0123456789", true, "ebbea584-c284-48c4-a37a-da96f480c45c", false, "admin@example.com" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_at", "user_id" },
                values: new object[] { new DateTime(2025, 4, 2, 20, 29, 35, 28, DateTimeKind.Local).AddTicks(137), "1643b6a6-52b2-44a0-9758-004c6a6e717e" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_at", "user_id" },
                values: new object[] { new DateTime(2025, 4, 2, 0, 0, 0, 0, DateTimeKind.Local), "1643b6a6-52b2-44a0-9758-004c6a6e717e" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_at", "user_id" },
                values: new object[] { new DateTime(2025, 4, 2, 20, 29, 35, 28, DateTimeKind.Local).AddTicks(328), "1643b6a6-52b2-44a0-9758-004c6a6e717e" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "1643b6a6-52b2-44a0-9758-004c6a6e717e" });
        }
    }
}
