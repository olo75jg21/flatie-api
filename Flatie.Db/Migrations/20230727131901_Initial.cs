using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Flatie.Db.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Role",
                table: "HomeSpaceMembers");

            migrationBuilder.AddColumn<int>(
                name: "HomeSpaceMemberRoleId",
                table: "HomeSpaceMembers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.UpdateData(
                table: "Guest",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "End", "Start" },
                values: new object[] { new DateTime(2023, 7, 27, 13, 19, 1, 506, DateTimeKind.Utc).AddTicks(3333), new DateTime(2023, 7, 30, 13, 19, 1, 506, DateTimeKind.Utc).AddTicks(3336), new DateTime(2023, 7, 28, 13, 19, 1, 506, DateTimeKind.Utc).AddTicks(3336) });

            migrationBuilder.UpdateData(
                table: "Guest",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "End", "Start" },
                values: new object[] { new DateTime(2023, 7, 27, 13, 19, 1, 506, DateTimeKind.Utc).AddTicks(3337), new DateTime(2023, 7, 31, 13, 19, 1, 506, DateTimeKind.Utc).AddTicks(3338), new DateTime(2023, 7, 29, 13, 19, 1, 506, DateTimeKind.Utc).AddTicks(3337) });

            migrationBuilder.UpdateData(
                table: "HomeSpace",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 27, 13, 19, 1, 506, DateTimeKind.Utc).AddTicks(3121));

            migrationBuilder.UpdateData(
                table: "HomeSpace",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 27, 13, 19, 1, 506, DateTimeKind.Utc).AddTicks(3125));

            migrationBuilder.UpdateData(
                table: "HomeSpace",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 27, 13, 19, 1, 506, DateTimeKind.Utc).AddTicks(3126));

            migrationBuilder.InsertData(
                table: "HomeSpaceMemberRole",
                columns: new[] { "Id", "CreatedAt", "Role" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 27, 13, 19, 1, 506, DateTimeKind.Utc).AddTicks(3259), "Owner" },
                    { 2, new DateTime(2023, 7, 27, 13, 19, 1, 506, DateTimeKind.Utc).AddTicks(3261), "Admin" },
                    { 3, new DateTime(2023, 7, 27, 13, 19, 1, 506, DateTimeKind.Utc).AddTicks(3261), "Member" }
                });

            migrationBuilder.UpdateData(
                table: "HomeSpaceMembers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "HomeSpaceMemberRoleId", "JoinedAt" },
                values: new object[] { new DateTime(2023, 7, 27, 13, 19, 1, 506, DateTimeKind.Utc).AddTicks(3276), 1, new DateTime(2023, 7, 27, 13, 19, 1, 506, DateTimeKind.Utc).AddTicks(3277) });

            migrationBuilder.UpdateData(
                table: "HomeSpaceMembers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "HomeSpaceMemberRoleId", "JoinedAt" },
                values: new object[] { new DateTime(2023, 7, 27, 13, 19, 1, 506, DateTimeKind.Utc).AddTicks(3279), 2, new DateTime(2023, 7, 27, 13, 19, 1, 506, DateTimeKind.Utc).AddTicks(3279) });

            migrationBuilder.UpdateData(
                table: "HomeSpaceMembers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "HomeSpaceMemberRoleId", "JoinedAt" },
                values: new object[] { new DateTime(2023, 7, 27, 13, 19, 1, 506, DateTimeKind.Utc).AddTicks(3280), 3, new DateTime(2023, 7, 27, 13, 19, 1, 506, DateTimeKind.Utc).AddTicks(3280) });

            migrationBuilder.UpdateData(
                table: "HomeSpaceMembers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "HomeSpaceMemberRoleId", "JoinedAt" },
                values: new object[] { new DateTime(2023, 7, 27, 13, 19, 1, 506, DateTimeKind.Utc).AddTicks(3281), 3, new DateTime(2023, 7, 27, 13, 19, 1, 506, DateTimeKind.Utc).AddTicks(3281) });

            migrationBuilder.UpdateData(
                table: "HomeSpacePreference",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 27, 13, 19, 1, 506, DateTimeKind.Utc).AddTicks(3299));

            migrationBuilder.UpdateData(
                table: "HomeSpacePreference",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 27, 13, 19, 1, 506, DateTimeKind.Utc).AddTicks(3300));

            migrationBuilder.UpdateData(
                table: "Notification",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 27, 13, 19, 1, 506, DateTimeKind.Utc).AddTicks(3140));

            migrationBuilder.UpdateData(
                table: "Notification",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 27, 13, 19, 1, 506, DateTimeKind.Utc).AddTicks(3143));

            migrationBuilder.UpdateData(
                table: "NotificationType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 27, 13, 19, 1, 506, DateTimeKind.Utc).AddTicks(3356));

            migrationBuilder.UpdateData(
                table: "NotificationType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 27, 13, 19, 1, 506, DateTimeKind.Utc).AddTicks(3357));

            migrationBuilder.UpdateData(
                table: "QuietHour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "End", "Start" },
                values: new object[] { new DateTime(2023, 7, 27, 13, 19, 1, 506, DateTimeKind.Utc).AddTicks(3192), new DateTime(2023, 7, 27, 15, 19, 1, 506, DateTimeKind.Utc).AddTicks(3193), new DateTime(2023, 7, 27, 13, 19, 1, 506, DateTimeKind.Utc).AddTicks(3193) });

            migrationBuilder.UpdateData(
                table: "QuietHour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "End", "Start" },
                values: new object[] { new DateTime(2023, 7, 27, 13, 19, 1, 506, DateTimeKind.Utc).AddTicks(3199), new DateTime(2023, 7, 29, 15, 19, 1, 506, DateTimeKind.Utc).AddTicks(3201), new DateTime(2023, 7, 29, 13, 19, 1, 506, DateTimeKind.Utc).AddTicks(3200) });

            migrationBuilder.UpdateData(
                table: "QuietHourImportance",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 27, 13, 19, 1, 506, DateTimeKind.Utc).AddTicks(3217));

            migrationBuilder.UpdateData(
                table: "QuietHourImportance",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 27, 13, 19, 1, 506, DateTimeKind.Utc).AddTicks(3218));

            migrationBuilder.UpdateData(
                table: "ShoppingList",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 27, 13, 19, 1, 506, DateTimeKind.Utc).AddTicks(3156));

            migrationBuilder.UpdateData(
                table: "ShoppingList",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 27, 13, 19, 1, 506, DateTimeKind.Utc).AddTicks(3160));

            migrationBuilder.UpdateData(
                table: "ShoppingListCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 27, 13, 19, 1, 506, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "ShoppingListCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 27, 13, 19, 1, 506, DateTimeKind.Utc).AddTicks(3180));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 27, 13, 19, 1, 506, DateTimeKind.Utc).AddTicks(3096));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 27, 13, 19, 1, 506, DateTimeKind.Utc).AddTicks(3100));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 27, 13, 19, 1, 506, DateTimeKind.Utc).AddTicks(3102));

            migrationBuilder.UpdateData(
                table: "UserAppRole",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 27, 13, 19, 1, 506, DateTimeKind.Utc).AddTicks(2996));

            migrationBuilder.UpdateData(
                table: "UserAppRole",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 27, 13, 19, 1, 506, DateTimeKind.Utc).AddTicks(2999));

            migrationBuilder.UpdateData(
                table: "UserTask",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DueDate" },
                values: new object[] { new DateTime(2023, 7, 27, 13, 19, 1, 506, DateTimeKind.Utc).AddTicks(3233), new DateTime(2023, 8, 3, 13, 19, 1, 506, DateTimeKind.Utc).AddTicks(3236) });

            migrationBuilder.UpdateData(
                table: "UserTask",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DueDate" },
                values: new object[] { new DateTime(2023, 7, 27, 13, 19, 1, 506, DateTimeKind.Utc).AddTicks(3239), new DateTime(2023, 7, 29, 13, 19, 1, 506, DateTimeKind.Utc).AddTicks(3239) });

            migrationBuilder.CreateIndex(
                name: "IX_HomeSpaceMembers_HomeSpaceMemberRoleId",
                table: "HomeSpaceMembers",
                column: "HomeSpaceMemberRoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_HomeSpaceMembers_HomeSpaceMemberRole_HomeSpaceMemberRoleId",
                table: "HomeSpaceMembers",
                column: "HomeSpaceMemberRoleId",
                principalTable: "HomeSpaceMemberRole",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HomeSpaceMembers_HomeSpaceMemberRole_HomeSpaceMemberRoleId",
                table: "HomeSpaceMembers");

            migrationBuilder.DropTable(
                name: "HomeSpaceMemberRole");

            migrationBuilder.DropIndex(
                name: "IX_HomeSpaceMembers_HomeSpaceMemberRoleId",
                table: "HomeSpaceMembers");

            migrationBuilder.DropColumn(
                name: "HomeSpaceMemberRoleId",
                table: "HomeSpaceMembers");

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "HomeSpaceMembers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Guest",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "End", "Start" },
                values: new object[] { new DateTime(2023, 7, 26, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(8288), new DateTime(2023, 7, 29, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(8291), new DateTime(2023, 7, 27, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(8290) });

            migrationBuilder.UpdateData(
                table: "Guest",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "End", "Start" },
                values: new object[] { new DateTime(2023, 7, 26, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(8293), new DateTime(2023, 7, 30, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(8294), new DateTime(2023, 7, 28, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(8293) });

            migrationBuilder.UpdateData(
                table: "HomeSpace",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 26, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(8092));

            migrationBuilder.UpdateData(
                table: "HomeSpace",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 26, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(8094));

            migrationBuilder.UpdateData(
                table: "HomeSpace",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 26, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(8096));

            migrationBuilder.UpdateData(
                table: "HomeSpaceMembers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "JoinedAt", "Role" },
                values: new object[] { new DateTime(2023, 7, 26, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(8245), new DateTime(2023, 7, 26, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(8246), "Owner" });

            migrationBuilder.UpdateData(
                table: "HomeSpaceMembers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "JoinedAt", "Role" },
                values: new object[] { new DateTime(2023, 7, 26, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(8249), new DateTime(2023, 7, 26, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(8249), "Member" });

            migrationBuilder.UpdateData(
                table: "HomeSpaceMembers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "JoinedAt", "Role" },
                values: new object[] { new DateTime(2023, 7, 26, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(8250), new DateTime(2023, 7, 26, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(8250), "Member" });

            migrationBuilder.UpdateData(
                table: "HomeSpaceMembers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "JoinedAt", "Role" },
                values: new object[] { new DateTime(2023, 7, 26, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(8251), new DateTime(2023, 7, 26, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(8252), "Member" });

            migrationBuilder.UpdateData(
                table: "HomeSpacePreference",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 26, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(8269));

            migrationBuilder.UpdateData(
                table: "HomeSpacePreference",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 26, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(8273));

            migrationBuilder.UpdateData(
                table: "Notification",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 26, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(8135));

            migrationBuilder.UpdateData(
                table: "Notification",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 26, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(8138));

            migrationBuilder.UpdateData(
                table: "NotificationType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 26, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "NotificationType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 26, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(8311));

            migrationBuilder.UpdateData(
                table: "QuietHour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "End", "Start" },
                values: new object[] { new DateTime(2023, 7, 26, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(8186), new DateTime(2023, 7, 26, 20, 52, 55, 951, DateTimeKind.Utc).AddTicks(8189), new DateTime(2023, 7, 26, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(8188) });

            migrationBuilder.UpdateData(
                table: "QuietHour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "End", "Start" },
                values: new object[] { new DateTime(2023, 7, 26, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(8196), new DateTime(2023, 7, 28, 20, 52, 55, 951, DateTimeKind.Utc).AddTicks(8198), new DateTime(2023, 7, 28, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(8197) });

            migrationBuilder.UpdateData(
                table: "QuietHourImportance",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 26, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(8213));

            migrationBuilder.UpdateData(
                table: "QuietHourImportance",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 26, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(8214));

            migrationBuilder.UpdateData(
                table: "ShoppingList",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 26, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(8151));

            migrationBuilder.UpdateData(
                table: "ShoppingList",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 26, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(8155));

            migrationBuilder.UpdateData(
                table: "ShoppingListCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 26, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(8170));

            migrationBuilder.UpdateData(
                table: "ShoppingListCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 26, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(8172));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 26, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(8069));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 26, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(8072));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 26, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(8073));

            migrationBuilder.UpdateData(
                table: "UserAppRole",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 26, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(7972));

            migrationBuilder.UpdateData(
                table: "UserAppRole",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 26, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(7975));

            migrationBuilder.UpdateData(
                table: "UserTask",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DueDate" },
                values: new object[] { new DateTime(2023, 7, 26, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(8227), new DateTime(2023, 8, 2, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(8228) });

            migrationBuilder.UpdateData(
                table: "UserTask",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DueDate" },
                values: new object[] { new DateTime(2023, 7, 26, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(8229), new DateTime(2023, 7, 28, 18, 52, 55, 951, DateTimeKind.Utc).AddTicks(8230) });
        }
    }
}
