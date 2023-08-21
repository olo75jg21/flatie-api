using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Flatie.Db.Migrations
{
    /// <inheritdoc />
    public partial class INITIAL2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ExpiresAt",
                table: "Invitation",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Guest",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "End", "Start" },
                values: new object[] { new DateTime(2023, 8, 21, 17, 14, 32, 361, DateTimeKind.Utc).AddTicks(8100), new DateTime(2023, 8, 24, 17, 14, 32, 361, DateTimeKind.Utc).AddTicks(8100), new DateTime(2023, 8, 22, 17, 14, 32, 361, DateTimeKind.Utc).AddTicks(8100) });

            migrationBuilder.UpdateData(
                table: "Guest",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "End", "Start" },
                values: new object[] { new DateTime(2023, 8, 21, 17, 14, 32, 361, DateTimeKind.Utc).AddTicks(8100), new DateTime(2023, 8, 25, 17, 14, 32, 361, DateTimeKind.Utc).AddTicks(8100), new DateTime(2023, 8, 23, 17, 14, 32, 361, DateTimeKind.Utc).AddTicks(8100) });

            migrationBuilder.UpdateData(
                table: "HomeSpace",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 21, 17, 14, 32, 361, DateTimeKind.Utc).AddTicks(7820));

            migrationBuilder.UpdateData(
                table: "HomeSpace",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 21, 17, 14, 32, 361, DateTimeKind.Utc).AddTicks(7820));

            migrationBuilder.UpdateData(
                table: "HomeSpace",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 21, 17, 14, 32, 361, DateTimeKind.Utc).AddTicks(7880));

            migrationBuilder.UpdateData(
                table: "HomeSpaceMemberRole",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 21, 17, 14, 32, 361, DateTimeKind.Utc).AddTicks(8040));

            migrationBuilder.UpdateData(
                table: "HomeSpaceMemberRole",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 21, 17, 14, 32, 361, DateTimeKind.Utc).AddTicks(8040));

            migrationBuilder.UpdateData(
                table: "HomeSpaceMemberRole",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 21, 17, 14, 32, 361, DateTimeKind.Utc).AddTicks(8040));

            migrationBuilder.UpdateData(
                table: "HomeSpaceMembers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "JoinedAt" },
                values: new object[] { new DateTime(2023, 8, 21, 17, 14, 32, 361, DateTimeKind.Utc).AddTicks(8060), new DateTime(2023, 8, 21, 17, 14, 32, 361, DateTimeKind.Utc).AddTicks(8060) });

            migrationBuilder.UpdateData(
                table: "HomeSpaceMembers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "JoinedAt" },
                values: new object[] { new DateTime(2023, 8, 21, 17, 14, 32, 361, DateTimeKind.Utc).AddTicks(8060), new DateTime(2023, 8, 21, 17, 14, 32, 361, DateTimeKind.Utc).AddTicks(8060) });

            migrationBuilder.UpdateData(
                table: "HomeSpaceMembers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "JoinedAt" },
                values: new object[] { new DateTime(2023, 8, 21, 17, 14, 32, 361, DateTimeKind.Utc).AddTicks(8060), new DateTime(2023, 8, 21, 17, 14, 32, 361, DateTimeKind.Utc).AddTicks(8060) });

            migrationBuilder.UpdateData(
                table: "HomeSpaceMembers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "JoinedAt" },
                values: new object[] { new DateTime(2023, 8, 21, 17, 14, 32, 361, DateTimeKind.Utc).AddTicks(8060), new DateTime(2023, 8, 21, 17, 14, 32, 361, DateTimeKind.Utc).AddTicks(8060) });

            migrationBuilder.UpdateData(
                table: "HomeSpacePreference",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 21, 17, 14, 32, 361, DateTimeKind.Utc).AddTicks(8080));

            migrationBuilder.UpdateData(
                table: "HomeSpacePreference",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 21, 17, 14, 32, 361, DateTimeKind.Utc).AddTicks(8080));

            migrationBuilder.UpdateData(
                table: "Notification",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 21, 17, 14, 32, 361, DateTimeKind.Utc).AddTicks(7900));

            migrationBuilder.UpdateData(
                table: "Notification",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 21, 17, 14, 32, 361, DateTimeKind.Utc).AddTicks(7900));

            migrationBuilder.UpdateData(
                table: "NotificationType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 21, 17, 14, 32, 361, DateTimeKind.Utc).AddTicks(8130));

            migrationBuilder.UpdateData(
                table: "NotificationType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 21, 17, 14, 32, 361, DateTimeKind.Utc).AddTicks(8130));

            migrationBuilder.UpdateData(
                table: "QuietHour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "End", "Start" },
                values: new object[] { new DateTime(2023, 8, 21, 17, 14, 32, 361, DateTimeKind.Utc).AddTicks(7960), new DateTime(2023, 8, 21, 19, 14, 32, 361, DateTimeKind.Utc).AddTicks(7960), new DateTime(2023, 8, 21, 17, 14, 32, 361, DateTimeKind.Utc).AddTicks(7960) });

            migrationBuilder.UpdateData(
                table: "QuietHour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "End", "Start" },
                values: new object[] { new DateTime(2023, 8, 21, 17, 14, 32, 361, DateTimeKind.Utc).AddTicks(7970), new DateTime(2023, 8, 23, 19, 14, 32, 361, DateTimeKind.Utc).AddTicks(7970), new DateTime(2023, 8, 23, 17, 14, 32, 361, DateTimeKind.Utc).AddTicks(7970) });

            migrationBuilder.UpdateData(
                table: "QuietHourImportance",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 21, 17, 14, 32, 361, DateTimeKind.Utc).AddTicks(7990));

            migrationBuilder.UpdateData(
                table: "QuietHourImportance",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 21, 17, 14, 32, 361, DateTimeKind.Utc).AddTicks(7990));

            migrationBuilder.UpdateData(
                table: "ShoppingList",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 21, 17, 14, 32, 361, DateTimeKind.Utc).AddTicks(7920));

            migrationBuilder.UpdateData(
                table: "ShoppingList",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 21, 17, 14, 32, 361, DateTimeKind.Utc).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "ShoppingListCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 21, 17, 14, 32, 361, DateTimeKind.Utc).AddTicks(7940));

            migrationBuilder.UpdateData(
                table: "ShoppingListCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 21, 17, 14, 32, 361, DateTimeKind.Utc).AddTicks(7950));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 8, 21, 17, 14, 32, 361, DateTimeKind.Utc).AddTicks(7640), new byte[] { 186, 54, 34, 68, 42, 148, 127, 102, 124, 111, 220, 34, 244, 179, 57, 168, 57, 151, 228, 59, 20, 199, 131, 183, 163, 40, 182, 21, 169, 170, 250, 7, 94, 28, 228, 228, 235, 248, 126, 225, 183, 184, 197, 127, 228, 120, 23, 215, 242, 181, 12, 221, 166, 63, 255, 110, 31, 60, 210, 220, 99, 34, 75, 198 }, new byte[] { 173, 152, 136, 47, 129, 122, 100, 214, 9, 112, 72, 124, 177, 229, 117, 155, 217, 92, 128, 4, 172, 159, 187, 97, 138, 211, 60, 162, 217, 90, 39, 118, 216, 95, 191, 82, 158, 87, 44, 156, 156, 80, 133, 23, 71, 65, 25, 123, 40, 12, 192, 173, 156, 240, 251, 141, 4, 145, 211, 82, 115, 131, 239, 105, 190, 249, 208, 254, 98, 98, 181, 130, 249, 155, 212, 137, 19, 173, 59, 174, 254, 15, 151, 219, 85, 142, 57, 76, 239, 62, 134, 12, 80, 217, 158, 209, 68, 78, 212, 220, 111, 255, 43, 19, 153, 121, 98, 149, 42, 31, 221, 74, 59, 46, 30, 184, 22, 192, 161, 189, 43, 243, 80, 80, 179, 36, 12, 226 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 8, 21, 17, 14, 32, 361, DateTimeKind.Utc).AddTicks(7740), new byte[] { 17, 111, 240, 28, 173, 44, 139, 166, 146, 195, 204, 99, 77, 215, 156, 24, 216, 190, 229, 156, 200, 140, 100, 216, 176, 227, 26, 117, 210, 88, 42, 255, 41, 215, 150, 108, 53, 175, 0, 85, 90, 113, 21, 70, 201, 145, 61, 72, 120, 165, 66, 166, 194, 224, 149, 148, 142, 32, 221, 196, 196, 106, 236, 94 }, new byte[] { 99, 141, 23, 93, 63, 51, 11, 73, 47, 247, 175, 34, 13, 138, 199, 113, 151, 43, 20, 149, 60, 142, 162, 138, 222, 92, 147, 26, 62, 24, 74, 151, 49, 236, 184, 90, 234, 72, 37, 100, 9, 179, 226, 159, 57, 212, 3, 100, 155, 180, 162, 56, 184, 32, 224, 143, 228, 230, 223, 139, 34, 137, 52, 168, 16, 218, 188, 10, 181, 17, 227, 225, 92, 51, 128, 67, 65, 77, 174, 242, 8, 186, 123, 161, 17, 86, 161, 178, 149, 84, 127, 118, 2, 13, 38, 154, 189, 230, 249, 130, 41, 142, 146, 200, 231, 4, 233, 62, 70, 136, 166, 67, 87, 75, 54, 102, 200, 72, 249, 34, 215, 36, 78, 228, 66, 148, 50, 189 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 8, 21, 17, 14, 32, 361, DateTimeKind.Utc).AddTicks(7800), new byte[] { 55, 49, 24, 60, 188, 24, 124, 65, 75, 238, 87, 41, 93, 62, 66, 4, 90, 208, 176, 218, 234, 78, 125, 152, 122, 237, 238, 60, 184, 243, 172, 184, 120, 200, 226, 45, 206, 10, 128, 194, 216, 75, 170, 166, 186, 56, 189, 12, 142, 26, 17, 202, 136, 175, 127, 34, 174, 240, 238, 13, 150, 124, 93, 158 }, new byte[] { 133, 75, 232, 79, 116, 121, 81, 163, 203, 145, 158, 142, 231, 110, 142, 3, 22, 244, 245, 46, 65, 227, 139, 115, 109, 139, 242, 150, 180, 108, 60, 192, 99, 156, 20, 52, 241, 122, 35, 74, 228, 65, 213, 70, 29, 143, 123, 141, 132, 52, 157, 141, 77, 194, 92, 94, 229, 137, 107, 125, 177, 26, 223, 12, 54, 196, 138, 19, 22, 245, 9, 71, 64, 236, 149, 160, 158, 204, 202, 16, 88, 14, 131, 117, 103, 83, 132, 204, 63, 111, 165, 30, 118, 191, 124, 138, 156, 195, 137, 96, 87, 134, 166, 139, 159, 170, 49, 26, 187, 141, 31, 128, 22, 217, 65, 219, 148, 194, 236, 99, 96, 178, 153, 59, 134, 26, 48, 16 } });

            migrationBuilder.UpdateData(
                table: "UserAppRole",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 21, 17, 14, 32, 361, DateTimeKind.Utc).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "UserAppRole",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 21, 17, 14, 32, 361, DateTimeKind.Utc).AddTicks(7130));

            migrationBuilder.UpdateData(
                table: "UserTask",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DueDate" },
                values: new object[] { new DateTime(2023, 8, 21, 17, 14, 32, 361, DateTimeKind.Utc).AddTicks(8010), new DateTime(2023, 8, 28, 17, 14, 32, 361, DateTimeKind.Utc).AddTicks(8010) });

            migrationBuilder.UpdateData(
                table: "UserTask",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DueDate" },
                values: new object[] { new DateTime(2023, 8, 21, 17, 14, 32, 361, DateTimeKind.Utc).AddTicks(8010), new DateTime(2023, 8, 23, 17, 14, 32, 361, DateTimeKind.Utc).AddTicks(8010) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExpiresAt",
                table: "Invitation");

            migrationBuilder.UpdateData(
                table: "Guest",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "End", "Start" },
                values: new object[] { new DateTime(2023, 8, 21, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(2260), new DateTime(2023, 8, 24, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(2260), new DateTime(2023, 8, 22, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(2260) });

            migrationBuilder.UpdateData(
                table: "Guest",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "End", "Start" },
                values: new object[] { new DateTime(2023, 8, 21, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(2260), new DateTime(2023, 8, 25, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(2260), new DateTime(2023, 8, 23, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(2260) });

            migrationBuilder.UpdateData(
                table: "HomeSpace",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 21, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(2050));

            migrationBuilder.UpdateData(
                table: "HomeSpace",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 21, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(2050));

            migrationBuilder.UpdateData(
                table: "HomeSpace",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 21, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(2050));

            migrationBuilder.UpdateData(
                table: "HomeSpaceMemberRole",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 21, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(2210));

            migrationBuilder.UpdateData(
                table: "HomeSpaceMemberRole",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 21, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(2210));

            migrationBuilder.UpdateData(
                table: "HomeSpaceMemberRole",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 21, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(2210));

            migrationBuilder.UpdateData(
                table: "HomeSpaceMembers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "JoinedAt" },
                values: new object[] { new DateTime(2023, 8, 21, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(2220), new DateTime(2023, 8, 21, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(2220) });

            migrationBuilder.UpdateData(
                table: "HomeSpaceMembers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "JoinedAt" },
                values: new object[] { new DateTime(2023, 8, 21, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(2220), new DateTime(2023, 8, 21, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(2220) });

            migrationBuilder.UpdateData(
                table: "HomeSpaceMembers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "JoinedAt" },
                values: new object[] { new DateTime(2023, 8, 21, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(2230), new DateTime(2023, 8, 21, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(2230) });

            migrationBuilder.UpdateData(
                table: "HomeSpaceMembers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "JoinedAt" },
                values: new object[] { new DateTime(2023, 8, 21, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(2230), new DateTime(2023, 8, 21, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(2230) });

            migrationBuilder.UpdateData(
                table: "HomeSpacePreference",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 21, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(2240));

            migrationBuilder.UpdateData(
                table: "HomeSpacePreference",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 21, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(2250));

            migrationBuilder.UpdateData(
                table: "Notification",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 21, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(2080));

            migrationBuilder.UpdateData(
                table: "Notification",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 21, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(2080));

            migrationBuilder.UpdateData(
                table: "NotificationType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 21, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(2280));

            migrationBuilder.UpdateData(
                table: "NotificationType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 21, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(2280));

            migrationBuilder.UpdateData(
                table: "QuietHour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "End", "Start" },
                values: new object[] { new DateTime(2023, 8, 21, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(2130), new DateTime(2023, 8, 21, 19, 13, 29, 140, DateTimeKind.Utc).AddTicks(2130), new DateTime(2023, 8, 21, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(2130) });

            migrationBuilder.UpdateData(
                table: "QuietHour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "End", "Start" },
                values: new object[] { new DateTime(2023, 8, 21, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(2140), new DateTime(2023, 8, 23, 19, 13, 29, 140, DateTimeKind.Utc).AddTicks(2140), new DateTime(2023, 8, 23, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(2140) });

            migrationBuilder.UpdateData(
                table: "QuietHourImportance",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 21, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(2160));

            migrationBuilder.UpdateData(
                table: "QuietHourImportance",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 21, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(2160));

            migrationBuilder.UpdateData(
                table: "ShoppingList",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 21, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(2100));

            migrationBuilder.UpdateData(
                table: "ShoppingList",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 21, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(2100));

            migrationBuilder.UpdateData(
                table: "ShoppingListCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 21, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(2120));

            migrationBuilder.UpdateData(
                table: "ShoppingListCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 21, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(2120));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 8, 21, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(1830), new byte[] { 124, 75, 205, 159, 79, 134, 104, 171, 191, 212, 118, 153, 122, 58, 110, 115, 17, 72, 35, 162, 125, 189, 188, 126, 99, 2, 116, 166, 65, 123, 158, 160, 254, 29, 104, 205, 229, 111, 230, 95, 227, 92, 123, 43, 51, 95, 34, 240, 153, 64, 33, 72, 58, 153, 227, 255, 132, 233, 224, 100, 45, 71, 247, 52 }, new byte[] { 177, 178, 110, 207, 21, 241, 71, 98, 91, 73, 29, 244, 24, 153, 48, 255, 27, 82, 108, 111, 49, 143, 26, 50, 54, 185, 152, 0, 125, 246, 42, 44, 106, 54, 55, 78, 123, 47, 26, 134, 5, 89, 24, 241, 210, 213, 55, 7, 68, 84, 7, 4, 91, 5, 24, 12, 186, 100, 165, 182, 75, 177, 26, 145, 235, 87, 150, 180, 103, 225, 190, 158, 193, 7, 209, 239, 126, 241, 207, 254, 56, 82, 200, 44, 55, 208, 252, 8, 126, 192, 134, 198, 206, 133, 225, 253, 0, 138, 144, 22, 46, 161, 179, 123, 19, 190, 176, 189, 27, 173, 42, 197, 103, 19, 70, 137, 153, 249, 147, 226, 105, 197, 30, 140, 111, 218, 233, 196 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 8, 21, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(1920), new byte[] { 187, 70, 117, 230, 145, 216, 134, 242, 76, 93, 188, 136, 243, 104, 182, 41, 219, 30, 212, 112, 116, 210, 134, 96, 33, 145, 18, 126, 210, 5, 34, 107, 122, 95, 129, 209, 229, 238, 86, 17, 49, 80, 244, 216, 41, 38, 93, 244, 33, 27, 215, 103, 177, 81, 68, 49, 22, 192, 2, 36, 38, 96, 140, 98 }, new byte[] { 123, 176, 28, 183, 180, 79, 140, 93, 113, 206, 125, 100, 232, 67, 199, 166, 135, 115, 180, 11, 86, 228, 181, 65, 67, 200, 223, 49, 118, 115, 140, 205, 196, 243, 114, 172, 223, 219, 2, 73, 143, 179, 59, 250, 41, 136, 195, 1, 133, 239, 194, 217, 179, 137, 206, 10, 168, 100, 106, 222, 228, 193, 230, 251, 253, 207, 205, 172, 92, 132, 104, 201, 12, 172, 193, 161, 216, 11, 30, 203, 95, 179, 38, 78, 121, 255, 104, 78, 243, 7, 24, 94, 12, 119, 213, 149, 173, 211, 245, 84, 85, 229, 160, 242, 55, 42, 249, 240, 11, 217, 18, 174, 55, 39, 135, 21, 165, 166, 136, 192, 150, 73, 192, 51, 180, 222, 190, 171 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 8, 21, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(1970), new byte[] { 69, 9, 243, 209, 106, 240, 196, 246, 30, 40, 166, 57, 66, 86, 198, 61, 80, 83, 6, 154, 111, 110, 184, 147, 116, 224, 198, 87, 15, 102, 224, 50, 167, 109, 189, 123, 200, 210, 150, 207, 167, 89, 166, 233, 208, 233, 141, 6, 41, 253, 213, 95, 137, 157, 231, 35, 13, 146, 201, 233, 146, 75, 76, 87 }, new byte[] { 16, 127, 214, 167, 66, 86, 196, 33, 13, 214, 111, 3, 151, 219, 38, 154, 204, 145, 213, 16, 150, 148, 65, 60, 203, 144, 1, 139, 214, 188, 194, 116, 212, 10, 239, 15, 181, 66, 54, 21, 117, 199, 216, 117, 141, 155, 122, 30, 141, 132, 99, 239, 139, 242, 17, 29, 189, 74, 34, 163, 251, 212, 226, 244, 22, 160, 212, 87, 61, 15, 165, 18, 77, 200, 118, 106, 118, 244, 82, 26, 91, 251, 38, 225, 19, 238, 117, 88, 95, 165, 170, 211, 58, 97, 28, 182, 108, 21, 169, 216, 147, 15, 83, 184, 182, 82, 11, 194, 209, 200, 148, 136, 131, 72, 47, 173, 82, 48, 238, 133, 61, 123, 29, 4, 56, 120, 101, 35 } });

            migrationBuilder.UpdateData(
                table: "UserAppRole",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 21, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(1270));

            migrationBuilder.UpdateData(
                table: "UserAppRole",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 21, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(1270));

            migrationBuilder.UpdateData(
                table: "UserTask",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DueDate" },
                values: new object[] { new DateTime(2023, 8, 21, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(2180), new DateTime(2023, 8, 28, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(2180) });

            migrationBuilder.UpdateData(
                table: "UserTask",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DueDate" },
                values: new object[] { new DateTime(2023, 8, 21, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(2180), new DateTime(2023, 8, 23, 17, 13, 29, 140, DateTimeKind.Utc).AddTicks(2180) });
        }
    }
}
