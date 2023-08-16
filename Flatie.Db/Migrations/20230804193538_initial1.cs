using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Flatie.Db.Migrations
{
    /// <inheritdoc />
    public partial class initial1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Guest",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "End", "Start" },
                values: new object[] { new DateTime(2023, 8, 4, 19, 35, 37, 789, DateTimeKind.Utc).AddTicks(9480), new DateTime(2023, 8, 7, 19, 35, 37, 789, DateTimeKind.Utc).AddTicks(9480), new DateTime(2023, 8, 5, 19, 35, 37, 789, DateTimeKind.Utc).AddTicks(9480) });

            migrationBuilder.UpdateData(
                table: "Guest",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "End", "Start" },
                values: new object[] { new DateTime(2023, 8, 4, 19, 35, 37, 789, DateTimeKind.Utc).AddTicks(9480), new DateTime(2023, 8, 8, 19, 35, 37, 789, DateTimeKind.Utc).AddTicks(9480), new DateTime(2023, 8, 6, 19, 35, 37, 789, DateTimeKind.Utc).AddTicks(9480) });

            migrationBuilder.UpdateData(
                table: "HomeSpace",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 4, 19, 35, 37, 789, DateTimeKind.Utc).AddTicks(9170));

            migrationBuilder.UpdateData(
                table: "HomeSpace",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 4, 19, 35, 37, 789, DateTimeKind.Utc).AddTicks(9170));

            migrationBuilder.UpdateData(
                table: "HomeSpace",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 4, 19, 35, 37, 789, DateTimeKind.Utc).AddTicks(9170));

            migrationBuilder.UpdateData(
                table: "HomeSpaceMemberRole",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 4, 19, 35, 37, 789, DateTimeKind.Utc).AddTicks(9420));

            migrationBuilder.UpdateData(
                table: "HomeSpaceMemberRole",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 4, 19, 35, 37, 789, DateTimeKind.Utc).AddTicks(9420));

            migrationBuilder.UpdateData(
                table: "HomeSpaceMemberRole",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 4, 19, 35, 37, 789, DateTimeKind.Utc).AddTicks(9420));

            migrationBuilder.UpdateData(
                table: "HomeSpaceMembers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "JoinedAt" },
                values: new object[] { new DateTime(2023, 8, 4, 19, 35, 37, 789, DateTimeKind.Utc).AddTicks(9430), new DateTime(2023, 8, 4, 19, 35, 37, 789, DateTimeKind.Utc).AddTicks(9430) });

            migrationBuilder.UpdateData(
                table: "HomeSpaceMembers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "JoinedAt" },
                values: new object[] { new DateTime(2023, 8, 4, 19, 35, 37, 789, DateTimeKind.Utc).AddTicks(9440), new DateTime(2023, 8, 4, 19, 35, 37, 789, DateTimeKind.Utc).AddTicks(9440) });

            migrationBuilder.UpdateData(
                table: "HomeSpaceMembers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "JoinedAt" },
                values: new object[] { new DateTime(2023, 8, 4, 19, 35, 37, 789, DateTimeKind.Utc).AddTicks(9440), new DateTime(2023, 8, 4, 19, 35, 37, 789, DateTimeKind.Utc).AddTicks(9440) });

            migrationBuilder.UpdateData(
                table: "HomeSpaceMembers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "JoinedAt" },
                values: new object[] { new DateTime(2023, 8, 4, 19, 35, 37, 789, DateTimeKind.Utc).AddTicks(9440), new DateTime(2023, 8, 4, 19, 35, 37, 789, DateTimeKind.Utc).AddTicks(9440) });

            migrationBuilder.UpdateData(
                table: "HomeSpacePreference",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 4, 19, 35, 37, 789, DateTimeKind.Utc).AddTicks(9460));

            migrationBuilder.UpdateData(
                table: "HomeSpacePreference",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 4, 19, 35, 37, 789, DateTimeKind.Utc).AddTicks(9460));

            migrationBuilder.UpdateData(
                table: "Notification",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 4, 19, 35, 37, 789, DateTimeKind.Utc).AddTicks(9190));

            migrationBuilder.UpdateData(
                table: "Notification",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 4, 19, 35, 37, 789, DateTimeKind.Utc).AddTicks(9190));

            migrationBuilder.UpdateData(
                table: "NotificationType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 4, 19, 35, 37, 789, DateTimeKind.Utc).AddTicks(9500));

            migrationBuilder.UpdateData(
                table: "NotificationType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 4, 19, 35, 37, 789, DateTimeKind.Utc).AddTicks(9500));

            migrationBuilder.UpdateData(
                table: "QuietHour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "End", "Start" },
                values: new object[] { new DateTime(2023, 8, 4, 19, 35, 37, 789, DateTimeKind.Utc).AddTicks(9260), new DateTime(2023, 8, 4, 21, 35, 37, 789, DateTimeKind.Utc).AddTicks(9260), new DateTime(2023, 8, 4, 19, 35, 37, 789, DateTimeKind.Utc).AddTicks(9260) });

            migrationBuilder.UpdateData(
                table: "QuietHour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "End", "Start" },
                values: new object[] { new DateTime(2023, 8, 4, 19, 35, 37, 789, DateTimeKind.Utc).AddTicks(9260), new DateTime(2023, 8, 6, 21, 35, 37, 789, DateTimeKind.Utc).AddTicks(9270), new DateTime(2023, 8, 6, 19, 35, 37, 789, DateTimeKind.Utc).AddTicks(9270) });

            migrationBuilder.UpdateData(
                table: "QuietHourImportance",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 4, 19, 35, 37, 789, DateTimeKind.Utc).AddTicks(9280));

            migrationBuilder.UpdateData(
                table: "QuietHourImportance",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 4, 19, 35, 37, 789, DateTimeKind.Utc).AddTicks(9290));

            migrationBuilder.UpdateData(
                table: "ShoppingList",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 4, 19, 35, 37, 789, DateTimeKind.Utc).AddTicks(9210));

            migrationBuilder.UpdateData(
                table: "ShoppingList",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 4, 19, 35, 37, 789, DateTimeKind.Utc).AddTicks(9210));

            migrationBuilder.UpdateData(
                table: "ShoppingListCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 4, 19, 35, 37, 789, DateTimeKind.Utc).AddTicks(9240));

            migrationBuilder.UpdateData(
                table: "ShoppingListCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 4, 19, 35, 37, 789, DateTimeKind.Utc).AddTicks(9240));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 8, 4, 19, 35, 37, 789, DateTimeKind.Utc).AddTicks(8990), new byte[] { 25, 60, 182, 231, 249, 158, 90, 42, 19, 182, 182, 128, 87, 249, 137, 64, 174, 230, 250, 165, 135, 107, 16, 184, 146, 244, 158, 249, 232, 78, 184, 43, 177, 208, 105, 199, 189, 35, 152, 219, 194, 91, 50, 14, 155, 188, 27, 217, 91, 83, 26, 200, 144, 77, 166, 181, 73, 71, 91, 253, 163, 209, 76, 75 }, new byte[] { 165, 162, 195, 198, 14, 137, 54, 227, 43, 107, 161, 236, 204, 62, 110, 177, 11, 175, 87, 55, 188, 70, 101, 127, 32, 53, 202, 235, 143, 227, 23, 24, 131, 70, 108, 88, 118, 161, 201, 223, 15, 73, 6, 193, 59, 104, 195, 75, 158, 13, 58, 204, 52, 80, 148, 112, 128, 249, 147, 140, 195, 253, 179, 157, 74, 31, 0, 180, 27, 90, 101, 10, 21, 50, 193, 108, 252, 237, 156, 152, 240, 208, 185, 32, 87, 212, 10, 212, 199, 191, 26, 236, 86, 164, 77, 54, 228, 140, 60, 226, 58, 144, 222, 121, 171, 132, 135, 185, 0, 19, 14, 136, 122, 193, 191, 214, 116, 176, 167, 7, 154, 79, 158, 42, 245, 25, 43, 247 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 8, 4, 19, 35, 37, 789, DateTimeKind.Utc).AddTicks(9090), new byte[] { 138, 160, 14, 35, 185, 232, 28, 93, 196, 33, 131, 197, 172, 77, 156, 211, 0, 43, 144, 82, 218, 238, 110, 88, 13, 64, 88, 239, 32, 240, 125, 101, 213, 116, 120, 0, 48, 123, 195, 97, 112, 65, 165, 39, 132, 218, 243, 18, 198, 160, 23, 181, 1, 109, 237, 81, 221, 31, 164, 157, 166, 43, 60, 180 }, new byte[] { 46, 184, 68, 60, 208, 206, 87, 45, 12, 95, 98, 154, 104, 221, 64, 29, 166, 158, 229, 160, 143, 245, 101, 174, 153, 221, 139, 237, 115, 243, 157, 213, 126, 184, 177, 252, 21, 153, 241, 190, 17, 152, 179, 109, 171, 129, 135, 76, 177, 62, 200, 5, 57, 57, 199, 225, 92, 209, 136, 251, 72, 30, 224, 57, 142, 251, 201, 4, 76, 127, 164, 66, 23, 199, 187, 70, 133, 52, 137, 189, 247, 156, 178, 186, 255, 35, 25, 54, 67, 253, 241, 81, 188, 110, 99, 71, 211, 250, 70, 204, 89, 7, 154, 123, 122, 125, 169, 153, 114, 101, 66, 92, 56, 45, 0, 138, 104, 7, 188, 60, 57, 156, 83, 20, 88, 117, 85, 96 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 8, 4, 19, 35, 37, 789, DateTimeKind.Utc).AddTicks(9150), new byte[] { 43, 166, 169, 211, 164, 106, 10, 86, 47, 51, 103, 193, 128, 82, 244, 31, 229, 225, 1, 38, 111, 190, 62, 188, 180, 102, 24, 40, 16, 1, 90, 202, 202, 105, 11, 24, 81, 106, 136, 0, 228, 213, 85, 189, 149, 250, 40, 237, 205, 159, 185, 54, 73, 253, 236, 159, 81, 81, 1, 150, 28, 127, 24, 59 }, new byte[] { 100, 68, 61, 149, 163, 32, 2, 128, 166, 71, 171, 242, 151, 135, 149, 227, 114, 216, 147, 220, 120, 66, 153, 220, 27, 249, 219, 87, 155, 6, 36, 239, 186, 76, 140, 80, 78, 158, 125, 138, 223, 161, 25, 70, 30, 152, 36, 116, 91, 72, 181, 215, 142, 178, 30, 107, 153, 175, 45, 175, 206, 199, 229, 136, 179, 25, 88, 98, 109, 35, 229, 243, 235, 91, 213, 248, 39, 15, 37, 5, 43, 32, 138, 160, 73, 231, 189, 175, 27, 77, 184, 228, 66, 78, 205, 106, 80, 243, 79, 94, 3, 125, 102, 33, 211, 133, 239, 201, 174, 114, 147, 217, 179, 103, 47, 202, 249, 212, 143, 176, 207, 187, 65, 252, 232, 107, 122, 44 } });

            migrationBuilder.UpdateData(
                table: "UserAppRole",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 4, 19, 35, 37, 789, DateTimeKind.Utc).AddTicks(8420));

            migrationBuilder.UpdateData(
                table: "UserAppRole",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 4, 19, 35, 37, 789, DateTimeKind.Utc).AddTicks(8420));

            migrationBuilder.UpdateData(
                table: "UserTask",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DueDate" },
                values: new object[] { new DateTime(2023, 8, 4, 19, 35, 37, 789, DateTimeKind.Utc).AddTicks(9390), new DateTime(2023, 8, 11, 19, 35, 37, 789, DateTimeKind.Utc).AddTicks(9390) });

            migrationBuilder.UpdateData(
                table: "UserTask",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DueDate" },
                values: new object[] { new DateTime(2023, 8, 4, 19, 35, 37, 789, DateTimeKind.Utc).AddTicks(9400), new DateTime(2023, 8, 6, 19, 35, 37, 789, DateTimeKind.Utc).AddTicks(9400) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Guest",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "End", "Start" },
                values: new object[] { new DateTime(2023, 7, 28, 12, 22, 24, 446, DateTimeKind.Utc).AddTicks(9840), new DateTime(2023, 7, 31, 12, 22, 24, 446, DateTimeKind.Utc).AddTicks(9844), new DateTime(2023, 7, 29, 12, 22, 24, 446, DateTimeKind.Utc).AddTicks(9843) });

            migrationBuilder.UpdateData(
                table: "Guest",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "End", "Start" },
                values: new object[] { new DateTime(2023, 7, 28, 12, 22, 24, 446, DateTimeKind.Utc).AddTicks(9846), new DateTime(2023, 8, 1, 12, 22, 24, 446, DateTimeKind.Utc).AddTicks(9847), new DateTime(2023, 7, 30, 12, 22, 24, 446, DateTimeKind.Utc).AddTicks(9847) });

            migrationBuilder.UpdateData(
                table: "HomeSpace",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 28, 12, 22, 24, 446, DateTimeKind.Utc).AddTicks(9616));

            migrationBuilder.UpdateData(
                table: "HomeSpace",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 28, 12, 22, 24, 446, DateTimeKind.Utc).AddTicks(9619));

            migrationBuilder.UpdateData(
                table: "HomeSpace",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 28, 12, 22, 24, 446, DateTimeKind.Utc).AddTicks(9643));

            migrationBuilder.UpdateData(
                table: "HomeSpaceMemberRole",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 28, 12, 22, 24, 446, DateTimeKind.Utc).AddTicks(9788));

            migrationBuilder.UpdateData(
                table: "HomeSpaceMemberRole",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 28, 12, 22, 24, 446, DateTimeKind.Utc).AddTicks(9788));

            migrationBuilder.UpdateData(
                table: "HomeSpaceMemberRole",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 28, 12, 22, 24, 446, DateTimeKind.Utc).AddTicks(9789));

            migrationBuilder.UpdateData(
                table: "HomeSpaceMembers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "JoinedAt" },
                values: new object[] { new DateTime(2023, 7, 28, 12, 22, 24, 446, DateTimeKind.Utc).AddTicks(9805), new DateTime(2023, 7, 28, 12, 22, 24, 446, DateTimeKind.Utc).AddTicks(9806) });

            migrationBuilder.UpdateData(
                table: "HomeSpaceMembers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "JoinedAt" },
                values: new object[] { new DateTime(2023, 7, 28, 12, 22, 24, 446, DateTimeKind.Utc).AddTicks(9809), new DateTime(2023, 7, 28, 12, 22, 24, 446, DateTimeKind.Utc).AddTicks(9809) });

            migrationBuilder.UpdateData(
                table: "HomeSpaceMembers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "JoinedAt" },
                values: new object[] { new DateTime(2023, 7, 28, 12, 22, 24, 446, DateTimeKind.Utc).AddTicks(9810), new DateTime(2023, 7, 28, 12, 22, 24, 446, DateTimeKind.Utc).AddTicks(9810) });

            migrationBuilder.UpdateData(
                table: "HomeSpaceMembers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "JoinedAt" },
                values: new object[] { new DateTime(2023, 7, 28, 12, 22, 24, 446, DateTimeKind.Utc).AddTicks(9811), new DateTime(2023, 7, 28, 12, 22, 24, 446, DateTimeKind.Utc).AddTicks(9812) });

            migrationBuilder.UpdateData(
                table: "HomeSpacePreference",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 28, 12, 22, 24, 446, DateTimeKind.Utc).AddTicks(9823));

            migrationBuilder.UpdateData(
                table: "HomeSpacePreference",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 28, 12, 22, 24, 446, DateTimeKind.Utc).AddTicks(9825));

            migrationBuilder.UpdateData(
                table: "Notification",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 28, 12, 22, 24, 446, DateTimeKind.Utc).AddTicks(9660));

            migrationBuilder.UpdateData(
                table: "Notification",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 28, 12, 22, 24, 446, DateTimeKind.Utc).AddTicks(9663));

            migrationBuilder.UpdateData(
                table: "NotificationType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 28, 12, 22, 24, 446, DateTimeKind.Utc).AddTicks(9863));

            migrationBuilder.UpdateData(
                table: "NotificationType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 28, 12, 22, 24, 446, DateTimeKind.Utc).AddTicks(9865));

            migrationBuilder.UpdateData(
                table: "QuietHour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "End", "Start" },
                values: new object[] { new DateTime(2023, 7, 28, 12, 22, 24, 446, DateTimeKind.Utc).AddTicks(9722), new DateTime(2023, 7, 28, 14, 22, 24, 446, DateTimeKind.Utc).AddTicks(9724), new DateTime(2023, 7, 28, 12, 22, 24, 446, DateTimeKind.Utc).AddTicks(9724) });

            migrationBuilder.UpdateData(
                table: "QuietHour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "End", "Start" },
                values: new object[] { new DateTime(2023, 7, 28, 12, 22, 24, 446, DateTimeKind.Utc).AddTicks(9732), new DateTime(2023, 7, 30, 14, 22, 24, 446, DateTimeKind.Utc).AddTicks(9733), new DateTime(2023, 7, 30, 12, 22, 24, 446, DateTimeKind.Utc).AddTicks(9732) });

            migrationBuilder.UpdateData(
                table: "QuietHourImportance",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 28, 12, 22, 24, 446, DateTimeKind.Utc).AddTicks(9750));

            migrationBuilder.UpdateData(
                table: "QuietHourImportance",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 28, 12, 22, 24, 446, DateTimeKind.Utc).AddTicks(9751));

            migrationBuilder.UpdateData(
                table: "ShoppingList",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 28, 12, 22, 24, 446, DateTimeKind.Utc).AddTicks(9678));

            migrationBuilder.UpdateData(
                table: "ShoppingList",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 28, 12, 22, 24, 446, DateTimeKind.Utc).AddTicks(9686));

            migrationBuilder.UpdateData(
                table: "ShoppingListCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 28, 12, 22, 24, 446, DateTimeKind.Utc).AddTicks(9704));

            migrationBuilder.UpdateData(
                table: "ShoppingListCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 28, 12, 22, 24, 446, DateTimeKind.Utc).AddTicks(9706));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 7, 28, 12, 22, 24, 446, DateTimeKind.Utc).AddTicks(9517), new byte[] { 1, 118, 189, 189, 101, 106, 165, 127, 92, 202, 49, 181, 123, 81, 226, 9, 193, 18, 210, 172, 78, 208, 79, 188, 226, 54, 86, 186, 23, 36, 144, 47, 114, 72, 220, 249, 57, 9, 94, 200, 162, 140, 74, 100, 159, 164, 236, 96, 174, 13, 106, 168, 94, 67, 174, 63, 105, 39, 61, 120, 76, 239, 26, 216 }, new byte[] { 91, 75, 187, 103, 246, 159, 243, 143, 56, 80, 67, 43, 247, 166, 125, 156, 75, 181, 175, 158, 79, 252, 239, 147, 187, 181, 54, 4, 225, 127, 148, 26, 171, 151, 102, 78, 234, 239, 44, 231, 25, 134, 130, 222, 54, 182, 109, 102, 22, 186, 188, 148, 209, 209, 235, 246, 11, 239, 227, 211, 189, 124, 128, 70, 46, 96, 26, 169, 155, 108, 237, 94, 182, 81, 19, 139, 104, 56, 203, 252, 91, 19, 160, 151, 199, 192, 68, 193, 168, 87, 81, 197, 193, 193, 109, 136, 119, 116, 54, 58, 186, 165, 44, 191, 143, 181, 203, 252, 70, 67, 87, 23, 152, 245, 50, 69, 31, 11, 189, 55, 146, 77, 224, 153, 131, 171, 228, 149 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 7, 28, 12, 22, 24, 446, DateTimeKind.Utc).AddTicks(9563), new byte[] { 175, 23, 225, 233, 67, 68, 244, 211, 16, 142, 93, 50, 28, 114, 5, 178, 79, 218, 169, 217, 113, 187, 24, 149, 142, 5, 118, 86, 62, 190, 240, 112, 59, 9, 100, 199, 165, 50, 190, 112, 43, 53, 4, 116, 183, 137, 228, 245, 151, 47, 84, 38, 183, 37, 187, 76, 2, 35, 79, 43, 118, 169, 112, 145 }, new byte[] { 82, 218, 195, 249, 97, 118, 113, 231, 185, 87, 206, 203, 237, 83, 112, 210, 132, 121, 72, 24, 76, 52, 65, 191, 210, 242, 29, 132, 95, 200, 117, 250, 179, 88, 147, 135, 204, 1, 23, 249, 223, 212, 155, 9, 140, 225, 12, 187, 15, 98, 251, 20, 147, 182, 182, 242, 155, 172, 18, 140, 176, 212, 37, 36, 97, 167, 53, 127, 133, 202, 5, 233, 89, 169, 57, 141, 166, 249, 250, 111, 57, 87, 137, 138, 254, 164, 61, 91, 145, 55, 26, 229, 88, 96, 7, 248, 232, 198, 254, 101, 182, 24, 152, 35, 231, 154, 120, 243, 12, 56, 38, 77, 20, 123, 177, 250, 48, 159, 131, 55, 72, 91, 141, 237, 10, 71, 78, 118 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 7, 28, 12, 22, 24, 446, DateTimeKind.Utc).AddTicks(9596), new byte[] { 150, 252, 192, 240, 48, 82, 180, 18, 63, 89, 230, 29, 180, 63, 68, 118, 54, 18, 82, 68, 78, 20, 51, 139, 119, 34, 72, 8, 229, 124, 219, 201, 144, 115, 215, 58, 191, 49, 172, 171, 21, 92, 9, 11, 50, 102, 3, 222, 154, 142, 151, 152, 226, 10, 218, 110, 206, 156, 242, 224, 196, 196, 94, 124 }, new byte[] { 180, 202, 22, 8, 152, 224, 205, 158, 252, 9, 254, 167, 144, 171, 192, 209, 173, 137, 50, 39, 74, 227, 201, 75, 228, 49, 41, 190, 166, 33, 50, 229, 179, 63, 164, 79, 102, 199, 196, 17, 47, 32, 221, 231, 78, 136, 34, 159, 88, 46, 154, 202, 86, 123, 77, 239, 26, 253, 29, 25, 33, 61, 127, 206, 212, 246, 23, 33, 75, 103, 118, 127, 245, 97, 223, 218, 116, 140, 46, 136, 27, 20, 69, 217, 201, 171, 209, 20, 200, 222, 219, 86, 143, 232, 5, 69, 23, 65, 166, 200, 167, 69, 163, 156, 48, 42, 64, 108, 62, 66, 94, 163, 172, 21, 27, 50, 143, 187, 7, 49, 191, 53, 50, 233, 80, 210, 247, 56 } });

            migrationBuilder.UpdateData(
                table: "UserAppRole",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 28, 12, 22, 24, 446, DateTimeKind.Utc).AddTicks(9167));

            migrationBuilder.UpdateData(
                table: "UserAppRole",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 28, 12, 22, 24, 446, DateTimeKind.Utc).AddTicks(9170));

            migrationBuilder.UpdateData(
                table: "UserTask",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DueDate" },
                values: new object[] { new DateTime(2023, 7, 28, 12, 22, 24, 446, DateTimeKind.Utc).AddTicks(9765), new DateTime(2023, 8, 4, 12, 22, 24, 446, DateTimeKind.Utc).AddTicks(9767) });

            migrationBuilder.UpdateData(
                table: "UserTask",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DueDate" },
                values: new object[] { new DateTime(2023, 7, 28, 12, 22, 24, 446, DateTimeKind.Utc).AddTicks(9769), new DateTime(2023, 7, 30, 12, 22, 24, 446, DateTimeKind.Utc).AddTicks(9770) });
        }
    }
}
