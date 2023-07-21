using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Flatie.Db.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
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
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Username = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false),
                    Role = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
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
                    start = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    end = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
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
                    Type = table.Column<string>(type: "text", nullable: false),
                    read = table.Column<bool>(type: "boolean", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: true),
                    HomeSpaceId = table.Column<int>(type: "integer", nullable: true),
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
                    Importance = table.Column<string>(type: "text", nullable: false),
                    Start = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    End = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    HomeSpaceId = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuietHour", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuietHour_HomeSpace_HomeSpaceId",
                        column: x => x.HomeSpaceId,
                        principalTable: "HomeSpace",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QuietHour_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ItemName = table.Column<string>(type: "text", nullable: false),
                    Category = table.Column<string>(type: "text", nullable: false),
                    Amount = table.Column<int>(type: "integer", nullable: false),
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
                name: "IX_Notification_UserId",
                table: "Notification",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_QuietHour_HomeSpaceId",
                table: "QuietHour",
                column: "HomeSpaceId");

            migrationBuilder.CreateIndex(
                name: "IX_QuietHour_UserId",
                table: "QuietHour",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingList_HomeSpaceId",
                table: "ShoppingList",
                column: "HomeSpaceId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingList_RequestedByUserId",
                table: "ShoppingList",
                column: "RequestedByUserId");

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
                name: "HomeSpace");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
