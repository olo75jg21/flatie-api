using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Flatie.Db.Migrations
{
    /// <inheritdoc />
    public partial class INITIAL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HomeSpace",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeSpace", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HomeSpaceMemberRole",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Role = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeSpaceMemberRole", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NotificationType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TypeName = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotificationType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QuietHourImportance",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Rank = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuietHourImportance", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingListCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingListCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserAppRole",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAppRole", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Username = table.Column<string>(type: "text", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "bytea", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "bytea", nullable: false),
                    UserAppRoleId = table.Column<int>(type: "integer", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_UserAppRole_UserAppRoleId",
                        column: x => x.UserAppRoleId,
                        principalTable: "UserAppRole",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Guest",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    HomeSpaceId = table.Column<int>(type: "integer", nullable: false),
                    InvitedByUserId = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Start = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    End = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guest", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Guest_HomeSpace_HomeSpaceId",
                        column: x => x.HomeSpaceId,
                        principalTable: "HomeSpace",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Guest_User_InvitedByUserId",
                        column: x => x.InvitedByUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HomeSpaceMembers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    JoinedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    HomeSpaceId = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    HomeSpaceMemberRoleId = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeSpaceMembers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HomeSpaceMembers_HomeSpaceMemberRole_HomeSpaceMemberRoleId",
                        column: x => x.HomeSpaceMemberRoleId,
                        principalTable: "HomeSpaceMemberRole",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HomeSpaceMembers_HomeSpace_HomeSpaceId",
                        column: x => x.HomeSpaceId,
                        principalTable: "HomeSpace",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HomeSpaceMembers_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HomeSpacePreference",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    HomeSpaceId = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeSpacePreference", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HomeSpacePreference_HomeSpace_HomeSpaceId",
                        column: x => x.HomeSpaceId,
                        principalTable: "HomeSpace",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HomeSpacePreference_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Invitation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SenderUserId = table.Column<int>(type: "integer", nullable: false),
                    RecipientUserId = table.Column<int>(type: "integer", nullable: false),
                    HomeSpaceId = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invitation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Invitation_HomeSpace_HomeSpaceId",
                        column: x => x.HomeSpaceId,
                        principalTable: "HomeSpace",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Invitation_User_RecipientUserId",
                        column: x => x.RecipientUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Invitation_User_SenderUserId",
                        column: x => x.SenderUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Notification",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Message = table.Column<string>(type: "text", nullable: false),
                    Read = table.Column<bool>(type: "boolean", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: true),
                    HomeSpaceId = table.Column<int>(type: "integer", nullable: true),
                    NotificationTypeId = table.Column<int>(type: "integer", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notification", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notification_HomeSpace_HomeSpaceId",
                        column: x => x.HomeSpaceId,
                        principalTable: "HomeSpace",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Notification_NotificationType_NotificationTypeId",
                        column: x => x.NotificationTypeId,
                        principalTable: "NotificationType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Notification_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "QuietHour",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Reason = table.Column<string>(type: "text", nullable: false),
                    Start = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    End = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: true),
                    HomeSpaceId = table.Column<int>(type: "integer", nullable: true),
                    QuietHourImportanceId = table.Column<int>(type: "integer", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuietHour", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuietHour_HomeSpace_HomeSpaceId",
                        column: x => x.HomeSpaceId,
                        principalTable: "HomeSpace",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_QuietHour_QuietHourImportance_QuietHourImportanceId",
                        column: x => x.QuietHourImportanceId,
                        principalTable: "QuietHourImportance",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_QuietHour_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ShoppingList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ItemName = table.Column<string>(type: "text", nullable: false),
                    Amount = table.Column<int>(type: "integer", nullable: false),
                    PurchasePrice = table.Column<int>(type: "integer", nullable: false),
                    CategoryId = table.Column<int>(type: "integer", nullable: true),
                    HomeSpaceId = table.Column<int>(type: "integer", nullable: true),
                    RequestedByUserId = table.Column<int>(type: "integer", nullable: true),
                    PucharsedByUserId = table.Column<int>(type: "integer", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShoppingList_HomeSpace_HomeSpaceId",
                        column: x => x.HomeSpaceId,
                        principalTable: "HomeSpace",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ShoppingList_ShoppingListCategory_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "ShoppingListCategory",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ShoppingList_User_PucharsedByUserId",
                        column: x => x.PucharsedByUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ShoppingList_User_RequestedByUserId",
                        column: x => x.RequestedByUserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserTask",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Completed = table.Column<bool>(type: "boolean", nullable: false),
                    DueDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    RewardPoints = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: true),
                    HomeSpaceId = table.Column<int>(type: "integer", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTask", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserTask_HomeSpace_HomeSpaceId",
                        column: x => x.HomeSpaceId,
                        principalTable: "HomeSpace",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserTask_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "HomeSpace",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 21, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(2050), "Living Room" },
                    { 2, new DateTime(2023, 8, 21, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(2050), "Kitchen" },
                    { 3, new DateTime(2023, 8, 21, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(2050), "Bedroom" }
                });

            migrationBuilder.InsertData(
                table: "HomeSpaceMemberRole",
                columns: new[] { "Id", "CreatedAt", "Role" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 21, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(2210), "Owner" },
                    { 2, new DateTime(2023, 8, 21, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(2210), "Admin" },
                    { 3, new DateTime(2023, 8, 21, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(2210), "Member" }
                });

            migrationBuilder.InsertData(
                table: "NotificationType",
                columns: new[] { "Id", "CreatedAt", "TypeName" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 21, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(2280), "Important" },
                    { 2, new DateTime(2023, 8, 21, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(2280), "Regular" }
                });

            migrationBuilder.InsertData(
                table: "QuietHourImportance",
                columns: new[] { "Id", "CreatedAt", "Rank" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 21, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(2160), 1 },
                    { 2, new DateTime(2023, 8, 21, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(2160), 2 }
                });

            migrationBuilder.InsertData(
                table: "ShoppingListCategory",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 21, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(2120), "Dairy" },
                    { 2, new DateTime(2023, 8, 21, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(2120), "Bakery" }
                });

            migrationBuilder.InsertData(
                table: "UserAppRole",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 21, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(1270), "Admin" },
                    { 2, new DateTime(2023, 8, 21, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(1270), "User" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreatedAt", "PasswordHash", "PasswordSalt", "UserAppRoleId", "Username" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 21, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(1830), new byte[] { 124, 75, 205, 159, 79, 134, 104, 171, 191, 212, 118, 153, 122, 58, 110, 115, 17, 72, 35, 162, 125, 189, 188, 126, 99, 2, 116, 166, 65, 123, 158, 160, 254, 29, 104, 205, 229, 111, 230, 95, 227, 92, 123, 43, 51, 95, 34, 240, 153, 64, 33, 72, 58, 153, 227, 255, 132, 233, 224, 100, 45, 71, 247, 52 }, new byte[] { 177, 178, 110, 207, 21, 241, 71, 98, 91, 73, 29, 244, 24, 153, 48, 255, 27, 82, 108, 111, 49, 143, 26, 50, 54, 185, 152, 0, 125, 246, 42, 44, 106, 54, 55, 78, 123, 47, 26, 134, 5, 89, 24, 241, 210, 213, 55, 7, 68, 84, 7, 4, 91, 5, 24, 12, 186, 100, 165, 182, 75, 177, 26, 145, 235, 87, 150, 180, 103, 225, 190, 158, 193, 7, 209, 239, 126, 241, 207, 254, 56, 82, 200, 44, 55, 208, 252, 8, 126, 192, 134, 198, 206, 133, 225, 253, 0, 138, 144, 22, 46, 161, 179, 123, 19, 190, 176, 189, 27, 173, 42, 197, 103, 19, 70, 137, 153, 249, 147, 226, 105, 197, 30, 140, 111, 218, 233, 196 }, 1, "admin" },
                    { 2, new DateTime(2023, 8, 21, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(1920), new byte[] { 187, 70, 117, 230, 145, 216, 134, 242, 76, 93, 188, 136, 243, 104, 182, 41, 219, 30, 212, 112, 116, 210, 134, 96, 33, 145, 18, 126, 210, 5, 34, 107, 122, 95, 129, 209, 229, 238, 86, 17, 49, 80, 244, 216, 41, 38, 93, 244, 33, 27, 215, 103, 177, 81, 68, 49, 22, 192, 2, 36, 38, 96, 140, 98 }, new byte[] { 123, 176, 28, 183, 180, 79, 140, 93, 113, 206, 125, 100, 232, 67, 199, 166, 135, 115, 180, 11, 86, 228, 181, 65, 67, 200, 223, 49, 118, 115, 140, 205, 196, 243, 114, 172, 223, 219, 2, 73, 143, 179, 59, 250, 41, 136, 195, 1, 133, 239, 194, 217, 179, 137, 206, 10, 168, 100, 106, 222, 228, 193, 230, 251, 253, 207, 205, 172, 92, 132, 104, 201, 12, 172, 193, 161, 216, 11, 30, 203, 95, 179, 38, 78, 121, 255, 104, 78, 243, 7, 24, 94, 12, 119, 213, 149, 173, 211, 245, 84, 85, 229, 160, 242, 55, 42, 249, 240, 11, 217, 18, 174, 55, 39, 135, 21, 165, 166, 136, 192, 150, 73, 192, 51, 180, 222, 190, 171 }, 2, "user1" },
                    { 3, new DateTime(2023, 8, 21, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(1970), new byte[] { 69, 9, 243, 209, 106, 240, 196, 246, 30, 40, 166, 57, 66, 86, 198, 61, 80, 83, 6, 154, 111, 110, 184, 147, 116, 224, 198, 87, 15, 102, 224, 50, 167, 109, 189, 123, 200, 210, 150, 207, 167, 89, 166, 233, 208, 233, 141, 6, 41, 253, 213, 95, 137, 157, 231, 35, 13, 146, 201, 233, 146, 75, 76, 87 }, new byte[] { 16, 127, 214, 167, 66, 86, 196, 33, 13, 214, 111, 3, 151, 219, 38, 154, 204, 145, 213, 16, 150, 148, 65, 60, 203, 144, 1, 139, 214, 188, 194, 116, 212, 10, 239, 15, 181, 66, 54, 21, 117, 199, 216, 117, 141, 155, 122, 30, 141, 132, 99, 239, 139, 242, 17, 29, 189, 74, 34, 163, 251, 212, 226, 244, 22, 160, 212, 87, 61, 15, 165, 18, 77, 200, 118, 106, 118, 244, 82, 26, 91, 251, 38, 225, 19, 238, 117, 88, 95, 165, 170, 211, 58, 97, 28, 182, 108, 21, 169, 216, 147, 15, 83, 184, 182, 82, 11, 194, 209, 200, 148, 136, 131, 72, 47, 173, 82, 48, 238, 133, 61, 123, 29, 4, 56, 120, 101, 35 }, 2, "user2" }
                });

            migrationBuilder.InsertData(
                table: "Guest",
                columns: new[] { "Id", "CreatedAt", "End", "HomeSpaceId", "InvitedByUserId", "Name", "Start" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 21, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(2260), new DateTime(2023, 8, 24, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(2260), 1, 1, "Guest 1", new DateTime(2023, 8, 22, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(2260) },
                    { 2, new DateTime(2023, 8, 21, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(2260), new DateTime(2023, 8, 25, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(2260), 1, 2, "Guest 2", new DateTime(2023, 8, 23, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(2260) }
                });

            migrationBuilder.InsertData(
                table: "HomeSpaceMembers",
                columns: new[] { "Id", "CreatedAt", "HomeSpaceId", "HomeSpaceMemberRoleId", "JoinedAt", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 21, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(2220), 1, 1, new DateTime(2023, 8, 21, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(2220), 1 },
                    { 2, new DateTime(2023, 8, 21, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(2220), 1, 2, new DateTime(2023, 8, 21, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(2220), 2 },
                    { 3, new DateTime(2023, 8, 21, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(2230), 2, 3, new DateTime(2023, 8, 21, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(2230), 1 },
                    { 4, new DateTime(2023, 8, 21, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(2230), 3, 3, new DateTime(2023, 8, 21, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(2230), 3 }
                });

            migrationBuilder.InsertData(
                table: "HomeSpacePreference",
                columns: new[] { "Id", "CreatedAt", "Description", "HomeSpaceId", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 21, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(2240), "Preference 1 description", 1, "Preference 1", 1 },
                    { 2, new DateTime(2023, 8, 21, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(2250), "Preference 2 description", 1, "Preference 2", 2 }
                });

            migrationBuilder.InsertData(
                table: "Notification",
                columns: new[] { "Id", "CreatedAt", "HomeSpaceId", "Message", "NotificationTypeId", "Read", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 21, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(2080), 1, "Notification 1", 1, false, 1 },
                    { 2, new DateTime(2023, 8, 21, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(2080), 1, "Notification 2", 2, true, 2 }
                });

            migrationBuilder.InsertData(
                table: "QuietHour",
                columns: new[] { "Id", "CreatedAt", "End", "HomeSpaceId", "QuietHourImportanceId", "Reason", "Start", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 21, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(2130), new DateTime(2023, 8, 21, 19, 13, 29, 140, DateTimeKind.Utc).AddTicks(2130), 1, 1, "Study time", new DateTime(2023, 8, 21, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(2130), 1 },
                    { 2, new DateTime(2023, 8, 21, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(2140), new DateTime(2023, 8, 23, 19, 13, 29, 140, DateTimeKind.Utc).AddTicks(2140), 1, 2, "Quiet reading", new DateTime(2023, 8, 23, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(2140), 2 }
                });

            migrationBuilder.InsertData(
                table: "ShoppingList",
                columns: new[] { "Id", "Amount", "CategoryId", "CreatedAt", "HomeSpaceId", "ItemName", "PucharsedByUserId", "PurchasePrice", "RequestedByUserId" },
                values: new object[,]
                {
                    { 1, 2, 1, new DateTime(2023, 8, 21, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(2100), 1, "Milk", 1, 5, 2 },
                    { 2, 3, 2, new DateTime(2023, 8, 21, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(2100), 1, "Bread", 2, 3, 1 }
                });

            migrationBuilder.InsertData(
                table: "UserTask",
                columns: new[] { "Id", "Completed", "CreatedAt", "Description", "DueDate", "HomeSpaceId", "RewardPoints", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, false, new DateTime(2023, 8, 21, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(2180), "Finish the project by next week", new DateTime(2023, 8, 28, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(2180), 1, 100, "Complete assignment", 1 },
                    { 2, true, new DateTime(2023, 8, 21, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(2180), "Get milk, eggs, and bread", new DateTime(2023, 8, 23, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(2180), 1, 50, "Buy groceries", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Guest_HomeSpaceId",
                table: "Guest",
                column: "HomeSpaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Guest_InvitedByUserId",
                table: "Guest",
                column: "InvitedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_HomeSpaceMembers_HomeSpaceId",
                table: "HomeSpaceMembers",
                column: "HomeSpaceId");

            migrationBuilder.CreateIndex(
                name: "IX_HomeSpaceMembers_HomeSpaceMemberRoleId",
                table: "HomeSpaceMembers",
                column: "HomeSpaceMemberRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_HomeSpaceMembers_UserId",
                table: "HomeSpaceMembers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_HomeSpacePreference_HomeSpaceId",
                table: "HomeSpacePreference",
                column: "HomeSpaceId");

            migrationBuilder.CreateIndex(
                name: "IX_HomeSpacePreference_UserId",
                table: "HomeSpacePreference",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Invitation_HomeSpaceId",
                table: "Invitation",
                column: "HomeSpaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Invitation_RecipientUserId",
                table: "Invitation",
                column: "RecipientUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Invitation_SenderUserId",
                table: "Invitation",
                column: "SenderUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Notification_HomeSpaceId",
                table: "Notification",
                column: "HomeSpaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Notification_NotificationTypeId",
                table: "Notification",
                column: "NotificationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Notification_UserId",
                table: "Notification",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_QuietHour_HomeSpaceId",
                table: "QuietHour",
                column: "HomeSpaceId");

            migrationBuilder.CreateIndex(
                name: "IX_QuietHour_QuietHourImportanceId",
                table: "QuietHour",
                column: "QuietHourImportanceId");

            migrationBuilder.CreateIndex(
                name: "IX_QuietHour_UserId",
                table: "QuietHour",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingList_CategoryId",
                table: "ShoppingList",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingList_HomeSpaceId",
                table: "ShoppingList",
                column: "HomeSpaceId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingList_PucharsedByUserId",
                table: "ShoppingList",
                column: "PucharsedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingList_RequestedByUserId",
                table: "ShoppingList",
                column: "RequestedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_User_UserAppRoleId",
                table: "User",
                column: "UserAppRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserTask_HomeSpaceId",
                table: "UserTask",
                column: "HomeSpaceId");

            migrationBuilder.CreateIndex(
                name: "IX_UserTask_UserId",
                table: "UserTask",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Guest");

            migrationBuilder.DropTable(
                name: "HomeSpaceMembers");

            migrationBuilder.DropTable(
                name: "HomeSpacePreference");

            migrationBuilder.DropTable(
                name: "Invitation");

            migrationBuilder.DropTable(
                name: "Notification");

            migrationBuilder.DropTable(
                name: "QuietHour");

            migrationBuilder.DropTable(
                name: "ShoppingList");

            migrationBuilder.DropTable(
                name: "UserTask");

            migrationBuilder.DropTable(
                name: "HomeSpaceMemberRole");

            migrationBuilder.DropTable(
                name: "NotificationType");

            migrationBuilder.DropTable(
                name: "QuietHourImportance");

            migrationBuilder.DropTable(
                name: "ShoppingListCategory");

            migrationBuilder.DropTable(
                name: "HomeSpace");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "UserAppRole");
        }
    }
}
