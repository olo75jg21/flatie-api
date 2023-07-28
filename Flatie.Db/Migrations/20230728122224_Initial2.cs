using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Flatie.Db.Migrations
{
    /// <inheritdoc />
    public partial class Initial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "User");

            migrationBuilder.AddColumn<byte[]>(
                name: "PasswordHash",
                table: "User",
                type: "bytea",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<byte[]>(
                name: "PasswordSalt",
                table: "User",
                type: "bytea",
                nullable: false,
                defaultValue: new byte[0]);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "User");

            migrationBuilder.DropColumn(
                name: "PasswordSalt",
                table: "User");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "User",
                type: "text",
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.UpdateData(
                table: "HomeSpaceMemberRole",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 27, 13, 19, 1, 506, DateTimeKind.Utc).AddTicks(3259));

            migrationBuilder.UpdateData(
                table: "HomeSpaceMemberRole",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 27, 13, 19, 1, 506, DateTimeKind.Utc).AddTicks(3261));

            migrationBuilder.UpdateData(
                table: "HomeSpaceMemberRole",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 7, 27, 13, 19, 1, 506, DateTimeKind.Utc).AddTicks(3261));

            migrationBuilder.UpdateData(
                table: "HomeSpaceMembers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "JoinedAt" },
                values: new object[] { new DateTime(2023, 7, 27, 13, 19, 1, 506, DateTimeKind.Utc).AddTicks(3276), new DateTime(2023, 7, 27, 13, 19, 1, 506, DateTimeKind.Utc).AddTicks(3277) });

            migrationBuilder.UpdateData(
                table: "HomeSpaceMembers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "JoinedAt" },
                values: new object[] { new DateTime(2023, 7, 27, 13, 19, 1, 506, DateTimeKind.Utc).AddTicks(3279), new DateTime(2023, 7, 27, 13, 19, 1, 506, DateTimeKind.Utc).AddTicks(3279) });

            migrationBuilder.UpdateData(
                table: "HomeSpaceMembers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "JoinedAt" },
                values: new object[] { new DateTime(2023, 7, 27, 13, 19, 1, 506, DateTimeKind.Utc).AddTicks(3280), new DateTime(2023, 7, 27, 13, 19, 1, 506, DateTimeKind.Utc).AddTicks(3280) });

            migrationBuilder.UpdateData(
                table: "HomeSpaceMembers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "JoinedAt" },
                values: new object[] { new DateTime(2023, 7, 27, 13, 19, 1, 506, DateTimeKind.Utc).AddTicks(3281), new DateTime(2023, 7, 27, 13, 19, 1, 506, DateTimeKind.Utc).AddTicks(3281) });

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
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 7, 27, 13, 19, 1, 506, DateTimeKind.Utc).AddTicks(3096), "adminpassword" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 7, 27, 13, 19, 1, 506, DateTimeKind.Utc).AddTicks(3100), "user1password" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 7, 27, 13, 19, 1, 506, DateTimeKind.Utc).AddTicks(3102), "user2password" });

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
        }
    }
}
