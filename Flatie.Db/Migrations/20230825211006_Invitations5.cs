using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Flatie.Db.Migrations
{
    /// <inheritdoc />
    public partial class Invitations5 : Migration
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
                    HomeSpaceMemberRoleId = table.Column<int>(type: "integer", nullable: false, defaultValue: 1),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    ExpiresAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
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
                    { 1, new DateTime(2023, 8, 25, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(4816), "Living Room" },
                    { 2, new DateTime(2023, 8, 25, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(4818), "Kitchen" },
                    { 3, new DateTime(2023, 8, 25, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(4820), "Bedroom" }
                });

            migrationBuilder.InsertData(
                table: "HomeSpaceMemberRole",
                columns: new[] { "Id", "CreatedAt", "Role" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 25, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(4958), "Owner" },
                    { 2, new DateTime(2023, 8, 25, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(4960), "Admin" },
                    { 3, new DateTime(2023, 8, 25, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(4961), "Member" }
                });

            migrationBuilder.InsertData(
                table: "NotificationType",
                columns: new[] { "Id", "CreatedAt", "TypeName" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 25, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(5033), "Important" },
                    { 2, new DateTime(2023, 8, 25, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(5034), "Regular" }
                });

            migrationBuilder.InsertData(
                table: "QuietHourImportance",
                columns: new[] { "Id", "CreatedAt", "Rank" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 25, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(4918), 1 },
                    { 2, new DateTime(2023, 8, 25, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(4919), 2 }
                });

            migrationBuilder.InsertData(
                table: "ShoppingListCategory",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 25, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(4877), "Dairy" },
                    { 2, new DateTime(2023, 8, 25, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(4878), "Bakery" }
                });

            migrationBuilder.InsertData(
                table: "UserAppRole",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 25, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(4270), "Admin" },
                    { 2, new DateTime(2023, 8, 25, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(4274), "User" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreatedAt", "PasswordHash", "PasswordSalt", "UserAppRoleId", "Username" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 25, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(4700), new byte[] { 126, 228, 64, 128, 113, 10, 25, 210, 65, 27, 201, 188, 124, 227, 220, 100, 118, 91, 103, 169, 246, 172, 83, 146, 173, 62, 3, 137, 1, 161, 231, 26, 193, 117, 32, 150, 143, 133, 30, 245, 33, 176, 78, 1, 35, 238, 163, 86, 200, 11, 177, 212, 246, 142, 237, 84, 43, 67, 11, 37, 96, 106, 191, 90 }, new byte[] { 97, 56, 110, 228, 104, 208, 143, 222, 11, 117, 81, 221, 149, 207, 145, 166, 52, 219, 170, 162, 41, 233, 111, 192, 27, 98, 154, 159, 108, 2, 98, 74, 138, 2, 183, 228, 37, 166, 137, 17, 111, 75, 217, 214, 151, 129, 89, 220, 4, 97, 224, 112, 254, 123, 251, 55, 158, 118, 97, 71, 25, 10, 196, 249, 17, 124, 174, 67, 106, 104, 121, 86, 38, 114, 241, 5, 184, 158, 213, 146, 25, 6, 161, 221, 49, 97, 185, 223, 45, 83, 186, 218, 169, 174, 141, 165, 1, 92, 178, 197, 51, 7, 167, 148, 32, 197, 193, 159, 57, 101, 232, 51, 47, 165, 116, 78, 98, 2, 217, 175, 245, 130, 115, 35, 120, 135, 246, 35 }, 1, "admin" },
                    { 2, new DateTime(2023, 8, 25, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(4744), new byte[] { 128, 196, 5, 199, 231, 253, 250, 168, 212, 253, 145, 171, 212, 14, 124, 58, 61, 118, 202, 24, 198, 83, 47, 158, 157, 20, 220, 104, 112, 136, 206, 249, 249, 83, 44, 117, 192, 197, 93, 192, 125, 48, 78, 208, 5, 122, 244, 32, 252, 209, 25, 198, 211, 162, 168, 189, 93, 156, 174, 161, 48, 228, 204, 101 }, new byte[] { 127, 199, 82, 157, 58, 135, 146, 188, 169, 100, 13, 118, 153, 199, 128, 1, 15, 92, 61, 1, 34, 252, 20, 129, 213, 202, 94, 13, 63, 83, 36, 169, 77, 231, 217, 240, 161, 12, 163, 4, 235, 189, 135, 153, 191, 232, 58, 227, 220, 117, 97, 150, 178, 246, 142, 19, 25, 129, 44, 196, 28, 154, 99, 96, 254, 132, 202, 236, 224, 29, 121, 242, 227, 210, 188, 161, 43, 16, 179, 50, 158, 194, 236, 135, 187, 2, 9, 158, 245, 219, 127, 231, 252, 164, 35, 70, 88, 163, 86, 20, 79, 176, 34, 132, 196, 180, 122, 103, 186, 189, 96, 214, 129, 224, 4, 162, 172, 74, 32, 185, 55, 154, 228, 185, 223, 211, 32, 170 }, 2, "user1" },
                    { 3, new DateTime(2023, 8, 25, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(4777), new byte[] { 190, 28, 53, 250, 231, 89, 90, 193, 87, 91, 248, 79, 16, 27, 19, 51, 233, 181, 185, 90, 103, 134, 50, 108, 108, 222, 154, 8, 11, 169, 34, 3, 126, 6, 12, 128, 31, 169, 95, 167, 111, 200, 41, 53, 78, 95, 186, 151, 78, 85, 41, 195, 67, 105, 104, 240, 171, 35, 199, 250, 231, 224, 203, 146 }, new byte[] { 158, 0, 252, 154, 136, 254, 213, 30, 212, 90, 216, 202, 33, 245, 108, 143, 194, 164, 192, 113, 181, 157, 147, 22, 209, 44, 19, 17, 77, 11, 114, 58, 143, 99, 250, 18, 172, 73, 149, 213, 98, 125, 177, 160, 229, 34, 78, 135, 187, 161, 180, 77, 25, 132, 6, 208, 117, 90, 141, 166, 225, 91, 29, 129, 99, 56, 195, 153, 54, 161, 243, 165, 36, 104, 51, 95, 128, 46, 204, 216, 7, 68, 166, 31, 44, 77, 61, 15, 155, 82, 96, 177, 13, 133, 41, 232, 220, 95, 223, 150, 64, 143, 105, 119, 181, 4, 57, 243, 229, 201, 49, 4, 69, 210, 106, 243, 75, 32, 186, 203, 249, 194, 1, 198, 96, 23, 68, 235 }, 2, "user2" }
                });

            migrationBuilder.InsertData(
                table: "Guest",
                columns: new[] { "Id", "CreatedAt", "End", "HomeSpaceId", "InvitedByUserId", "Name", "Start" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 25, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(5012), new DateTime(2023, 8, 28, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(5016), 1, 1, "Guest 1", new DateTime(2023, 8, 26, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(5014) },
                    { 2, new DateTime(2023, 8, 25, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(5017), new DateTime(2023, 8, 29, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(5018), 1, 2, "Guest 2", new DateTime(2023, 8, 27, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(5017) }
                });

            migrationBuilder.InsertData(
                table: "HomeSpaceMembers",
                columns: new[] { "Id", "CreatedAt", "HomeSpaceId", "HomeSpaceMemberRoleId", "JoinedAt", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 25, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(4973), 1, 1, new DateTime(2023, 8, 25, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(4974), 1 },
                    { 2, new DateTime(2023, 8, 25, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(4976), 1, 2, new DateTime(2023, 8, 25, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(4977), 2 },
                    { 3, new DateTime(2023, 8, 25, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(4977), 2, 3, new DateTime(2023, 8, 25, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(4978), 1 },
                    { 4, new DateTime(2023, 8, 25, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(4978), 3, 3, new DateTime(2023, 8, 25, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(4979), 3 }
                });

            migrationBuilder.InsertData(
                table: "HomeSpacePreference",
                columns: new[] { "Id", "CreatedAt", "Description", "HomeSpaceId", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 25, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(4993), "Preference 1 description", 1, "Preference 1", 1 },
                    { 2, new DateTime(2023, 8, 25, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(4996), "Preference 2 description", 1, "Preference 2", 2 }
                });

            migrationBuilder.InsertData(
                table: "Notification",
                columns: new[] { "Id", "CreatedAt", "HomeSpaceId", "Message", "NotificationTypeId", "Read", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 25, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(4835), 1, "Notification 1", 1, false, 1 },
                    { 2, new DateTime(2023, 8, 25, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(4838), 1, "Notification 2", 2, true, 2 }
                });

            migrationBuilder.InsertData(
                table: "QuietHour",
                columns: new[] { "Id", "CreatedAt", "End", "HomeSpaceId", "QuietHourImportanceId", "Reason", "Start", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 25, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(4893), new DateTime(2023, 8, 25, 23, 10, 6, 433, DateTimeKind.Utc).AddTicks(4894), 1, 1, "Study time", new DateTime(2023, 8, 25, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(4894), 1 },
                    { 2, new DateTime(2023, 8, 25, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(4902), new DateTime(2023, 8, 27, 23, 10, 6, 433, DateTimeKind.Utc).AddTicks(4903), 1, 2, "Quiet reading", new DateTime(2023, 8, 27, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(4902), 2 }
                });

            migrationBuilder.InsertData(
                table: "ShoppingList",
                columns: new[] { "Id", "Amount", "CategoryId", "CreatedAt", "HomeSpaceId", "ItemName", "PucharsedByUserId", "PurchasePrice", "RequestedByUserId" },
                values: new object[,]
                {
                    { 1, 2, 1, new DateTime(2023, 8, 25, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(4857), 1, "Milk", 1, 5, 2 },
                    { 2, 3, 2, new DateTime(2023, 8, 25, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(4861), 1, "Bread", 2, 3, 1 }
                });

            migrationBuilder.InsertData(
                table: "UserTask",
                columns: new[] { "Id", "Completed", "CreatedAt", "Description", "DueDate", "HomeSpaceId", "RewardPoints", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, false, new DateTime(2023, 8, 25, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(4939), "Finish the project by next week", new DateTime(2023, 9, 1, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(4940), 1, 100, "Complete assignment", 1 },
                    { 2, true, new DateTime(2023, 8, 25, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(4941), "Get milk, eggs, and bread", new DateTime(2023, 8, 27, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(4942), 1, 50, "Buy groceries", 2 }
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
