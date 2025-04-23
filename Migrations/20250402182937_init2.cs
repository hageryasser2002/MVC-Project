using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MVC_Projec2.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ateliers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ateliers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Decors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Style = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Decors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Halls",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Halls", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MakeUpServices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MakeUpServices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sessions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sessions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Hall_Id = table.Column<int>(type: "int", nullable: true),
                    Session_Id = table.Column<int>(type: "int", nullable: true),
                    Atelier_Id = table.Column<int>(type: "int", nullable: true),
                    MakeupId = table.Column<int>(type: "int", nullable: true),
                    Decor_Id = table.Column<int>(type: "int", nullable: true),
                    user_id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bookings_AspNetUsers_user_id",
                        column: x => x.user_id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bookings_Ateliers_Atelier_Id",
                        column: x => x.Atelier_Id,
                        principalTable: "Ateliers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Bookings_Decors_Decor_Id",
                        column: x => x.Decor_Id,
                        principalTable: "Decors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Bookings_Halls_Hall_Id",
                        column: x => x.Hall_Id,
                        principalTable: "Halls",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Bookings_MakeUpServices_MakeupId",
                        column: x => x.MakeupId,
                        principalTable: "MakeUpServices",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Bookings_Sessions_Session_Id",
                        column: x => x.Session_Id,
                        principalTable: "Sessions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    user_id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Hall_Id = table.Column<int>(type: "int", nullable: true),
                    Session_Id = table.Column<int>(type: "int", nullable: true),
                    Atelier_Id = table.Column<int>(type: "int", nullable: true),
                    MakeupId = table.Column<int>(type: "int", nullable: true),
                    Decor_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_AspNetUsers_user_id",
                        column: x => x.user_id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_Ateliers_Atelier_Id",
                        column: x => x.Atelier_Id,
                        principalTable: "Ateliers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Comments_Decors_Decor_Id",
                        column: x => x.Decor_Id,
                        principalTable: "Decors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Comments_Halls_Hall_Id",
                        column: x => x.Hall_Id,
                        principalTable: "Halls",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Comments_MakeUpServices_MakeupId",
                        column: x => x.MakeupId,
                        principalTable: "MakeUpServices",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Comments_Sessions_Session_Id",
                        column: x => x.Session_Id,
                        principalTable: "Sessions",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", null, "Admin", "ADMIN" },
                    { "2", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1643b6a6-52b2-44a0-9758-004c6a6e717e", 0, "73b7bebe-dcde-4e01-a897-f39ff576d3c8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@example.com", true, null, false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEFiBChZ5LrlEnVMKlDXNDAZQ828nh9HueYvddRrif4AS4jxEs1rl8yrHOz6bDECxag==", "0123456789", true, "ebbea584-c284-48c4-a37a-da96f480c45c", false, "admin@example.com" });

            migrationBuilder.InsertData(
                table: "Ateliers",
                columns: new[] { "Id", "Location", "Name" },
                values: new object[,]
                {
                    { 1, "Downtown", "Elite Atelier" },
                    { 2, "Uptown", "Royal Designs" },
                    { 3, "City Center", "Glamorous Styles" },
                    { 4, "Suburb", "Elegant Creations" }
                });

            migrationBuilder.InsertData(
                table: "Decors",
                columns: new[] { "Id", "Price", "Style" },
                values: new object[,]
                {
                    { 1, 5000, "Classic" },
                    { 2, 7000, "Modern" },
                    { 3, 4500, "Rustic" }
                });

            migrationBuilder.InsertData(
                table: "Halls",
                columns: new[] { "Id", "Capacity", "Name" },
                values: new object[,]
                {
                    { 1, 500, "Grand Hall" },
                    { 2, 300, "Crystal Ballroom" },
                    { 3, 200, "Sunset Venue" }
                });

            migrationBuilder.InsertData(
                table: "MakeUpServices",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Bridal Makeup", 1500 },
                    { 2, "Party Glam", 800 },
                    { 3, "Natural Look", 500 },
                    { 4, "Evening Elegance", 1000 }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "Duration", "Type" },
                values: new object[,]
                {
                    { 1, 2, "Photography" },
                    { 2, 3, "Videography" },
                    { 3, 4, "Engagement Shoot" },
                    { 4, 5, "Pre-Wedding Shoot" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "1643b6a6-52b2-44a0-9758-004c6a6e717e" });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "Atelier_Id", "Created_at", "Decor_Id", "Hall_Id", "MakeupId", "Session_Id", "Status", "user_id" },
                values: new object[,]
                {
                    { 1, 3, new DateTime(2025, 4, 2, 20, 29, 35, 28, DateTimeKind.Local).AddTicks(137), 1, 2, 1, 2, "Confirmed", "1643b6a6-52b2-44a0-9758-004c6a6e717e" },
                    { 2, 1, new DateTime(2025, 4, 2, 0, 0, 0, 0, DateTimeKind.Local), 2, 1, 4, 1, "Pending", "1643b6a6-52b2-44a0-9758-004c6a6e717e" }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Atelier_Id", "Content", "Created_at", "Decor_Id", "Hall_Id", "MakeupId", "Session_Id", "user_id" },
                values: new object[] { 1, 3, "Excellent service!", new DateTime(2025, 4, 2, 20, 29, 35, 28, DateTimeKind.Local).AddTicks(328), 1, 2, 1, 2, "1643b6a6-52b2-44a0-9758-004c6a6e717e" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_Atelier_Id",
                table: "Bookings",
                column: "Atelier_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_Decor_Id",
                table: "Bookings",
                column: "Decor_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_Hall_Id",
                table: "Bookings",
                column: "Hall_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_MakeupId",
                table: "Bookings",
                column: "MakeupId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_Session_Id",
                table: "Bookings",
                column: "Session_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_user_id",
                table: "Bookings",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_Atelier_Id",
                table: "Comments",
                column: "Atelier_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_Decor_Id",
                table: "Comments",
                column: "Decor_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_Hall_Id",
                table: "Comments",
                column: "Hall_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_MakeupId",
                table: "Comments",
                column: "MakeupId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_Session_Id",
                table: "Comments",
                column: "Session_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_user_id",
                table: "Comments",
                column: "user_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Ateliers");

            migrationBuilder.DropTable(
                name: "Decors");

            migrationBuilder.DropTable(
                name: "Halls");

            migrationBuilder.DropTable(
                name: "MakeUpServices");

            migrationBuilder.DropTable(
                name: "Sessions");
        }
    }
}
