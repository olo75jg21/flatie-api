using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Flatie.Db.Migrations
{
    /// <inheritdoc />
    public partial class Seeders : Migration
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
                    Password = table.Column<string>(type: "text", nullable: false),
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
                    Role = table.Column<string>(type: "text", nullable: false),
                    JoinedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    HomeSpaceId = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeSpaceMembers", x => x.Id);
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
                    { 1, new DateTime(2023, 7, 26, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(8092), "Living Room" },
                    { 2, new DateTime(2023, 7, 26, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(8094), "Kitchen" },
                    { 3, new DateTime(2023, 7, 26, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(8096), "Bedroom" }
                });

            migrationBuilder.InsertData(
                table: "NotificationType",
                columns: new[] { "Id", "CreatedAt", "TypeName" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 26, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(8310), "Important" },
                    { 2, new DateTime(2023, 7, 26, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(8311), "Regular" }
                });

            migrationBuilder.InsertData(
                table: "QuietHourImportance",
                columns: new[] { "Id", "CreatedAt", "Rank" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 26, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(8213), 1 },
                    { 2, new DateTime(2023, 7, 26, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(8214), 2 }
                });

            migrationBuilder.InsertData(
                table: "ShoppingListCategory",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 26, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(8170), "Dairy" },
                    { 2, new DateTime(2023, 7, 26, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(8172), "Bakery" }
                });

            migrationBuilder.InsertData(
                table: "UserAppRole",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 26, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(7972), "Admin" },
                    { 2, new DateTime(2023, 7, 26, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(7975), "User" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreatedAt", "Password", "UserAppRoleId", "Username" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 26, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(8069), "adminpassword", 1, "admin" },
                    { 2, new DateTime(2023, 7, 26, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(8072), "user1password", 2, "user1" },
                    { 3, new DateTime(2023, 7, 26, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(8073), "user2password", 2, "user2" }
                });

            migrationBuilder.InsertData(
                table: "Guest",
                columns: new[] { "Id", "CreatedAt", "End", "HomeSpaceId", "InvitedByUserId", "Name", "Start" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 26, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(8288), new DateTime(2023, 7, 29, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(8291), 1, 1, "Guest 1", new DateTime(2023, 7, 27, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(8290) },
                    { 2, new DateTime(2023, 7, 26, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(8293), new DateTime(2023, 7, 30, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(8294), 1, 2, "Guest 2", new DateTime(2023, 7, 28, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(8293) }
                });

            migrationBuilder.InsertData(
                table: "HomeSpaceMembers",
                columns: new[] { "Id", "CreatedAt", "HomeSpaceId", "JoinedAt", "Role", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 26, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(8245), 1, new DateTime(2023, 7, 26, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(8246), "Owner", 1 },
                    { 2, new DateTime(2023, 7, 26, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(8249), 1, new DateTime(2023, 7, 26, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(8249), "Member", 2 },
                    { 3, new DateTime(2023, 7, 26, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(8250), 2, new DateTime(2023, 7, 26, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(8250), "Member", 1 },
                    { 4, new DateTime(2023, 7, 26, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(8251), 3, new DateTime(2023, 7, 26, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(8252), "Member", 3 }
                });

            migrationBuilder.InsertData(
                table: "HomeSpacePreference",
                columns: new[] { "Id", "CreatedAt", "Description", "HomeSpaceId", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 26, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(8269), "Preference 1 description", 1, "Preference 1", 1 },
                    { 2, new DateTime(2023, 7, 26, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(8273), "Preference 2 description", 1, "Preference 2", 2 }
                });

            migrationBuilder.InsertData(
                table: "Notification",
                columns: new[] { "Id", "CreatedAt", "HomeSpaceId", "Message", "NotificationTypeId", "Read", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 26, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(8135), 1, "Notification 1", 1, false, 1 },
                    { 2, new DateTime(2023, 7, 26, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(8138), 1, "Notification 2", 2, true, 2 }
                });

            migrationBuilder.InsertData(
                table: "QuietHour",
                columns: new[] { "Id", "CreatedAt", "End", "HomeSpaceId", "QuietHourImportanceId", "Reason", "Start", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 26, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(8186), new DateTime(2023, 7, 26, 20, 52, 55, 951, DateTimeKind.Utc).AddTicks(8189), 1, 1, "Study time", new DateTime(2023, 7, 26, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(8188), 1 },
                    { 2, new DateTime(2023, 7, 26, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(8196), new DateTime(2023, 7, 28, 20, 52, 55, 951, DateTimeKind.Utc).AddTicks(8198), 1, 2, "Quiet reading", new DateTime(2023, 7, 28, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(8197), 2 }
                });

            migrationBuilder.InsertData(
                table: "ShoppingList",
                columns: new[] { "Id", "Amount", "CategoryId", "CreatedAt", "HomeSpaceId", "ItemName", "PucharsedByUserId", "PurchasePrice", "RequestedByUserId" },
                values: new object[,]
                {
                    { 1, 2, 1, new DateTime(2023, 7, 26, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(8151), 1, "Milk", 1, 5, 2 },
                    { 2, 3, 2, new DateTime(2023, 7, 26, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(8155), 1, "Bread", 2, 3, 1 }
                });

            migrationBuilder.InsertData(
                table: "UserTask",
                columns: new[] { "Id", "Completed", "CreatedAt", "Description", "DueDate", "HomeSpaceId", "RewardPoints", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, false, new DateTime(2023, 7, 26, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(8227), "Finish the project by next week", new DateTime(2023, 8, 2, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(8228), 1, 100, "Complete assignment", 1 },
                    { 2, true, new DateTime(2023, 7, 26, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(8229), "Get milk, eggs, and bread", new DateTime(2023, 7, 28, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(8230), 1, 50, "Buy groceries", 2 }
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
                name: "Notification");

            migrationBuilder.DropTable(
                name: "QuietHour");

            migrationBuilder.DropTable(
                name: "ShoppingList");

            migrationBuilder.DropTable(
                name: "UserTask");

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
