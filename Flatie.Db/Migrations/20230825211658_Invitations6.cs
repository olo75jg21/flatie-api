using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Flatie.Db.Migrations
{
    /// <inheritdoc />
    public partial class Invitations6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HomeSpaceMemberRoleId",
                table: "Invitation");

            migrationBuilder.AlterColumn<int>(
                name: "HomeSpaceMemberRoleId",
                table: "HomeSpaceMembers",
                type: "integer",
                nullable: false,
                defaultValue: 1,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.UpdateData(
                table: "Guest",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "End", "Start" },
                values: new object[] { new DateTime(2023, 8, 25, 21, 16, 58, 428, DateTimeKind.Utc).AddTicks(908), new DateTime(2023, 8, 28, 21, 16, 58, 428, DateTimeKind.Utc).AddTicks(911), new DateTime(2023, 8, 26, 21, 16, 58, 428, DateTimeKind.Utc).AddTicks(910) });

            migrationBuilder.UpdateData(
                table: "Guest",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "End", "Start" },
                values: new object[] { new DateTime(2023, 8, 25, 21, 16, 58, 428, DateTimeKind.Utc).AddTicks(913), new DateTime(2023, 8, 29, 21, 16, 58, 428, DateTimeKind.Utc).AddTicks(914), new DateTime(2023, 8, 27, 21, 16, 58, 428, DateTimeKind.Utc).AddTicks(913) });

            migrationBuilder.UpdateData(
                table: "HomeSpace",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 25, 21, 16, 58, 428, DateTimeKind.Utc).AddTicks(672));

            migrationBuilder.UpdateData(
                table: "HomeSpace",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 25, 21, 16, 58, 428, DateTimeKind.Utc).AddTicks(675));

            migrationBuilder.UpdateData(
                table: "HomeSpace",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 25, 21, 16, 58, 428, DateTimeKind.Utc).AddTicks(676));

            migrationBuilder.UpdateData(
                table: "HomeSpaceMemberRole",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 25, 21, 16, 58, 428, DateTimeKind.Utc).AddTicks(851));

            migrationBuilder.UpdateData(
                table: "HomeSpaceMemberRole",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 25, 21, 16, 58, 428, DateTimeKind.Utc).AddTicks(853));

            migrationBuilder.UpdateData(
                table: "HomeSpaceMemberRole",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 25, 21, 16, 58, 428, DateTimeKind.Utc).AddTicks(854));

            migrationBuilder.UpdateData(
                table: "HomeSpaceMembers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "JoinedAt" },
                values: new object[] { new DateTime(2023, 8, 25, 21, 16, 58, 428, DateTimeKind.Utc).AddTicks(865), new DateTime(2023, 8, 25, 21, 16, 58, 428, DateTimeKind.Utc).AddTicks(866) });

            migrationBuilder.UpdateData(
                table: "HomeSpaceMembers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "JoinedAt" },
                values: new object[] { new DateTime(2023, 8, 25, 21, 16, 58, 428, DateTimeKind.Utc).AddTicks(868), new DateTime(2023, 8, 25, 21, 16, 58, 428, DateTimeKind.Utc).AddTicks(869) });

            migrationBuilder.UpdateData(
                table: "HomeSpaceMembers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "JoinedAt" },
                values: new object[] { new DateTime(2023, 8, 25, 21, 16, 58, 428, DateTimeKind.Utc).AddTicks(869), new DateTime(2023, 8, 25, 21, 16, 58, 428, DateTimeKind.Utc).AddTicks(870) });

            migrationBuilder.UpdateData(
                table: "HomeSpaceMembers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "JoinedAt" },
                values: new object[] { new DateTime(2023, 8, 25, 21, 16, 58, 428, DateTimeKind.Utc).AddTicks(871), new DateTime(2023, 8, 25, 21, 16, 58, 428, DateTimeKind.Utc).AddTicks(871) });

            migrationBuilder.UpdateData(
                table: "HomeSpacePreference",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 25, 21, 16, 58, 428, DateTimeKind.Utc).AddTicks(888));

            migrationBuilder.UpdateData(
                table: "HomeSpacePreference",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 25, 21, 16, 58, 428, DateTimeKind.Utc).AddTicks(892));

            migrationBuilder.UpdateData(
                table: "Notification",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 25, 21, 16, 58, 428, DateTimeKind.Utc).AddTicks(691));

            migrationBuilder.UpdateData(
                table: "Notification",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 25, 21, 16, 58, 428, DateTimeKind.Utc).AddTicks(696));

            migrationBuilder.UpdateData(
                table: "NotificationType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 25, 21, 16, 58, 428, DateTimeKind.Utc).AddTicks(929));

            migrationBuilder.UpdateData(
                table: "NotificationType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 25, 21, 16, 58, 428, DateTimeKind.Utc).AddTicks(931));

            migrationBuilder.UpdateData(
                table: "QuietHour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "End", "Start" },
                values: new object[] { new DateTime(2023, 8, 25, 21, 16, 58, 428, DateTimeKind.Utc).AddTicks(778), new DateTime(2023, 8, 25, 23, 16, 58, 428, DateTimeKind.Utc).AddTicks(779), new DateTime(2023, 8, 25, 21, 16, 58, 428, DateTimeKind.Utc).AddTicks(779) });

            migrationBuilder.UpdateData(
                table: "QuietHour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "End", "Start" },
                values: new object[] { new DateTime(2023, 8, 25, 21, 16, 58, 428, DateTimeKind.Utc).AddTicks(786), new DateTime(2023, 8, 27, 23, 16, 58, 428, DateTimeKind.Utc).AddTicks(787), new DateTime(2023, 8, 27, 21, 16, 58, 428, DateTimeKind.Utc).AddTicks(786) });

            migrationBuilder.UpdateData(
                table: "QuietHourImportance",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 25, 21, 16, 58, 428, DateTimeKind.Utc).AddTicks(808));

            migrationBuilder.UpdateData(
                table: "QuietHourImportance",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 25, 21, 16, 58, 428, DateTimeKind.Utc).AddTicks(809));

            migrationBuilder.UpdateData(
                table: "ShoppingList",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 25, 21, 16, 58, 428, DateTimeKind.Utc).AddTicks(712));

            migrationBuilder.UpdateData(
                table: "ShoppingList",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 25, 21, 16, 58, 428, DateTimeKind.Utc).AddTicks(717));

            migrationBuilder.UpdateData(
                table: "ShoppingListCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 25, 21, 16, 58, 428, DateTimeKind.Utc).AddTicks(763));

            migrationBuilder.UpdateData(
                table: "ShoppingListCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 25, 21, 16, 58, 428, DateTimeKind.Utc).AddTicks(765));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 8, 25, 21, 16, 58, 428, DateTimeKind.Utc).AddTicks(541), new byte[] { 0, 179, 79, 201, 204, 208, 160, 38, 151, 154, 238, 111, 205, 210, 114, 3, 195, 71, 155, 42, 106, 104, 215, 48, 76, 131, 236, 235, 169, 245, 3, 87, 145, 221, 219, 78, 242, 202, 19, 190, 174, 182, 238, 120, 100, 34, 165, 89, 12, 157, 100, 242, 119, 108, 123, 239, 173, 63, 201, 147, 241, 48, 4, 164 }, new byte[] { 144, 53, 114, 61, 82, 135, 47, 52, 119, 168, 41, 15, 157, 243, 244, 227, 238, 6, 156, 129, 156, 76, 253, 101, 68, 200, 119, 33, 149, 43, 45, 11, 177, 217, 219, 58, 174, 120, 58, 96, 228, 74, 58, 161, 33, 200, 143, 221, 3, 179, 5, 15, 223, 35, 243, 29, 3, 91, 150, 115, 111, 74, 111, 87, 193, 207, 240, 117, 200, 124, 164, 78, 240, 132, 43, 253, 80, 248, 236, 162, 195, 136, 199, 95, 209, 26, 120, 45, 185, 131, 234, 234, 16, 210, 89, 180, 137, 89, 34, 79, 151, 86, 114, 182, 68, 134, 211, 188, 94, 3, 137, 23, 150, 171, 239, 87, 47, 136, 136, 34, 71, 41, 73, 56, 187, 64, 163, 81 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 8, 25, 21, 16, 58, 428, DateTimeKind.Utc).AddTicks(619), new byte[] { 132, 17, 89, 251, 178, 89, 153, 58, 131, 248, 30, 107, 72, 190, 150, 107, 149, 44, 136, 44, 49, 110, 201, 132, 169, 83, 154, 95, 146, 214, 143, 138, 18, 170, 252, 201, 10, 103, 163, 72, 137, 211, 207, 82, 16, 196, 222, 180, 110, 234, 162, 0, 23, 155, 7, 199, 48, 104, 145, 138, 62, 98, 235, 51 }, new byte[] { 116, 235, 186, 218, 225, 112, 78, 42, 165, 6, 43, 184, 134, 247, 88, 66, 134, 66, 89, 52, 92, 190, 101, 207, 200, 19, 82, 116, 122, 6, 185, 211, 17, 209, 172, 10, 32, 60, 127, 117, 123, 214, 144, 144, 86, 126, 19, 68, 128, 251, 229, 224, 114, 164, 11, 16, 62, 87, 160, 44, 132, 129, 227, 59, 107, 85, 40, 30, 245, 95, 35, 45, 6, 47, 171, 56, 117, 172, 238, 245, 97, 121, 248, 2, 172, 155, 88, 255, 132, 61, 181, 41, 84, 208, 184, 84, 60, 150, 159, 116, 83, 68, 182, 17, 153, 101, 227, 82, 205, 239, 81, 90, 60, 167, 29, 202, 113, 151, 30, 198, 59, 87, 70, 137, 210, 178, 34, 117 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 8, 25, 21, 16, 58, 428, DateTimeKind.Utc).AddTicks(655), new byte[] { 181, 113, 246, 9, 216, 0, 70, 75, 194, 30, 37, 159, 70, 24, 187, 125, 79, 61, 53, 49, 247, 50, 221, 213, 145, 230, 21, 73, 206, 188, 161, 170, 155, 253, 102, 173, 125, 254, 219, 34, 72, 231, 147, 59, 189, 228, 55, 147, 125, 30, 160, 79, 126, 55, 78, 127, 47, 223, 93, 121, 67, 82, 6, 185 }, new byte[] { 55, 241, 135, 180, 28, 39, 119, 201, 79, 213, 76, 105, 46, 95, 112, 74, 189, 190, 40, 0, 237, 98, 170, 215, 54, 158, 56, 223, 113, 16, 107, 142, 40, 231, 212, 149, 222, 88, 42, 73, 84, 127, 125, 37, 185, 80, 54, 191, 236, 89, 87, 186, 208, 153, 9, 184, 1, 130, 6, 84, 212, 101, 179, 104, 201, 140, 180, 131, 44, 199, 25, 199, 83, 245, 96, 192, 111, 64, 50, 211, 143, 108, 6, 111, 143, 190, 15, 60, 177, 119, 76, 54, 158, 185, 223, 138, 241, 57, 161, 227, 187, 60, 188, 206, 157, 204, 200, 116, 246, 124, 87, 36, 85, 54, 71, 193, 135, 188, 7, 120, 235, 29, 52, 121, 207, 24, 14, 183 } });

            migrationBuilder.UpdateData(
                table: "UserAppRole",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 25, 21, 16, 58, 428, DateTimeKind.Utc).AddTicks(18));

            migrationBuilder.UpdateData(
                table: "UserAppRole",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 25, 21, 16, 58, 428, DateTimeKind.Utc).AddTicks(21));

            migrationBuilder.UpdateData(
                table: "UserTask",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DueDate" },
                values: new object[] { new DateTime(2023, 8, 25, 21, 16, 58, 428, DateTimeKind.Utc).AddTicks(828), new DateTime(2023, 9, 1, 21, 16, 58, 428, DateTimeKind.Utc).AddTicks(829) });

            migrationBuilder.UpdateData(
                table: "UserTask",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DueDate" },
                values: new object[] { new DateTime(2023, 8, 25, 21, 16, 58, 428, DateTimeKind.Utc).AddTicks(831), new DateTime(2023, 8, 27, 21, 16, 58, 428, DateTimeKind.Utc).AddTicks(832) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HomeSpaceMemberRoleId",
                table: "Invitation",
                type: "integer",
                nullable: false,
                defaultValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "HomeSpaceMemberRoleId",
                table: "HomeSpaceMembers",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldDefaultValue: 1);

            migrationBuilder.UpdateData(
                table: "Guest",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "End", "Start" },
                values: new object[] { new DateTime(2023, 8, 25, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(5012), new DateTime(2023, 8, 28, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(5016), new DateTime(2023, 8, 26, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(5014) });

            migrationBuilder.UpdateData(
                table: "Guest",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "End", "Start" },
                values: new object[] { new DateTime(2023, 8, 25, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(5017), new DateTime(2023, 8, 29, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(5018), new DateTime(2023, 8, 27, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(5017) });

            migrationBuilder.UpdateData(
                table: "HomeSpace",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 25, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(4816));

            migrationBuilder.UpdateData(
                table: "HomeSpace",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 25, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(4818));

            migrationBuilder.UpdateData(
                table: "HomeSpace",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 25, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(4820));

            migrationBuilder.UpdateData(
                table: "HomeSpaceMemberRole",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 25, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(4958));

            migrationBuilder.UpdateData(
                table: "HomeSpaceMemberRole",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 25, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(4960));

            migrationBuilder.UpdateData(
                table: "HomeSpaceMemberRole",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 25, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(4961));

            migrationBuilder.UpdateData(
                table: "HomeSpaceMembers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "JoinedAt" },
                values: new object[] { new DateTime(2023, 8, 25, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(4973), new DateTime(2023, 8, 25, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(4974) });

            migrationBuilder.UpdateData(
                table: "HomeSpaceMembers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "JoinedAt" },
                values: new object[] { new DateTime(2023, 8, 25, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(4976), new DateTime(2023, 8, 25, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(4977) });

            migrationBuilder.UpdateData(
                table: "HomeSpaceMembers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "JoinedAt" },
                values: new object[] { new DateTime(2023, 8, 25, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(4977), new DateTime(2023, 8, 25, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(4978) });

            migrationBuilder.UpdateData(
                table: "HomeSpaceMembers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "JoinedAt" },
                values: new object[] { new DateTime(2023, 8, 25, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(4978), new DateTime(2023, 8, 25, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(4979) });

            migrationBuilder.UpdateData(
                table: "HomeSpacePreference",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 25, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(4993));

            migrationBuilder.UpdateData(
                table: "HomeSpacePreference",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 25, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(4996));

            migrationBuilder.UpdateData(
                table: "Notification",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 25, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(4835));

            migrationBuilder.UpdateData(
                table: "Notification",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 25, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(4838));

            migrationBuilder.UpdateData(
                table: "NotificationType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 25, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(5033));

            migrationBuilder.UpdateData(
                table: "NotificationType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 25, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(5034));

            migrationBuilder.UpdateData(
                table: "QuietHour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "End", "Start" },
                values: new object[] { new DateTime(2023, 8, 25, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(4893), new DateTime(2023, 8, 25, 23, 10, 6, 433, DateTimeKind.Utc).AddTicks(4894), new DateTime(2023, 8, 25, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(4894) });

            migrationBuilder.UpdateData(
                table: "QuietHour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "End", "Start" },
                values: new object[] { new DateTime(2023, 8, 25, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(4902), new DateTime(2023, 8, 27, 23, 10, 6, 433, DateTimeKind.Utc).AddTicks(4903), new DateTime(2023, 8, 27, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(4902) });

            migrationBuilder.UpdateData(
                table: "QuietHourImportance",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 25, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(4918));

            migrationBuilder.UpdateData(
                table: "QuietHourImportance",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 25, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(4919));

            migrationBuilder.UpdateData(
                table: "ShoppingList",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 25, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(4857));

            migrationBuilder.UpdateData(
                table: "ShoppingList",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 25, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(4861));

            migrationBuilder.UpdateData(
                table: "ShoppingListCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 25, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(4877));

            migrationBuilder.UpdateData(
                table: "ShoppingListCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 25, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(4878));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 8, 25, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(4700), new byte[] { 126, 228, 64, 128, 113, 10, 25, 210, 65, 27, 201, 188, 124, 227, 220, 100, 118, 91, 103, 169, 246, 172, 83, 146, 173, 62, 3, 137, 1, 161, 231, 26, 193, 117, 32, 150, 143, 133, 30, 245, 33, 176, 78, 1, 35, 238, 163, 86, 200, 11, 177, 212, 246, 142, 237, 84, 43, 67, 11, 37, 96, 106, 191, 90 }, new byte[] { 97, 56, 110, 228, 104, 208, 143, 222, 11, 117, 81, 221, 149, 207, 145, 166, 52, 219, 170, 162, 41, 233, 111, 192, 27, 98, 154, 159, 108, 2, 98, 74, 138, 2, 183, 228, 37, 166, 137, 17, 111, 75, 217, 214, 151, 129, 89, 220, 4, 97, 224, 112, 254, 123, 251, 55, 158, 118, 97, 71, 25, 10, 196, 249, 17, 124, 174, 67, 106, 104, 121, 86, 38, 114, 241, 5, 184, 158, 213, 146, 25, 6, 161, 221, 49, 97, 185, 223, 45, 83, 186, 218, 169, 174, 141, 165, 1, 92, 178, 197, 51, 7, 167, 148, 32, 197, 193, 159, 57, 101, 232, 51, 47, 165, 116, 78, 98, 2, 217, 175, 245, 130, 115, 35, 120, 135, 246, 35 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 8, 25, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(4744), new byte[] { 128, 196, 5, 199, 231, 253, 250, 168, 212, 253, 145, 171, 212, 14, 124, 58, 61, 118, 202, 24, 198, 83, 47, 158, 157, 20, 220, 104, 112, 136, 206, 249, 249, 83, 44, 117, 192, 197, 93, 192, 125, 48, 78, 208, 5, 122, 244, 32, 252, 209, 25, 198, 211, 162, 168, 189, 93, 156, 174, 161, 48, 228, 204, 101 }, new byte[] { 127, 199, 82, 157, 58, 135, 146, 188, 169, 100, 13, 118, 153, 199, 128, 1, 15, 92, 61, 1, 34, 252, 20, 129, 213, 202, 94, 13, 63, 83, 36, 169, 77, 231, 217, 240, 161, 12, 163, 4, 235, 189, 135, 153, 191, 232, 58, 227, 220, 117, 97, 150, 178, 246, 142, 19, 25, 129, 44, 196, 28, 154, 99, 96, 254, 132, 202, 236, 224, 29, 121, 242, 227, 210, 188, 161, 43, 16, 179, 50, 158, 194, 236, 135, 187, 2, 9, 158, 245, 219, 127, 231, 252, 164, 35, 70, 88, 163, 86, 20, 79, 176, 34, 132, 196, 180, 122, 103, 186, 189, 96, 214, 129, 224, 4, 162, 172, 74, 32, 185, 55, 154, 228, 185, 223, 211, 32, 170 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 8, 25, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(4777), new byte[] { 190, 28, 53, 250, 231, 89, 90, 193, 87, 91, 248, 79, 16, 27, 19, 51, 233, 181, 185, 90, 103, 134, 50, 108, 108, 222, 154, 8, 11, 169, 34, 3, 126, 6, 12, 128, 31, 169, 95, 167, 111, 200, 41, 53, 78, 95, 186, 151, 78, 85, 41, 195, 67, 105, 104, 240, 171, 35, 199, 250, 231, 224, 203, 146 }, new byte[] { 158, 0, 252, 154, 136, 254, 213, 30, 212, 90, 216, 202, 33, 245, 108, 143, 194, 164, 192, 113, 181, 157, 147, 22, 209, 44, 19, 17, 77, 11, 114, 58, 143, 99, 250, 18, 172, 73, 149, 213, 98, 125, 177, 160, 229, 34, 78, 135, 187, 161, 180, 77, 25, 132, 6, 208, 117, 90, 141, 166, 225, 91, 29, 129, 99, 56, 195, 153, 54, 161, 243, 165, 36, 104, 51, 95, 128, 46, 204, 216, 7, 68, 166, 31, 44, 77, 61, 15, 155, 82, 96, 177, 13, 133, 41, 232, 220, 95, 223, 150, 64, 143, 105, 119, 181, 4, 57, 243, 229, 201, 49, 4, 69, 210, 106, 243, 75, 32, 186, 203, 249, 194, 1, 198, 96, 23, 68, 235 } });

            migrationBuilder.UpdateData(
                table: "UserAppRole",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 25, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(4270));

            migrationBuilder.UpdateData(
                table: "UserAppRole",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 25, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(4274));

            migrationBuilder.UpdateData(
                table: "UserTask",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DueDate" },
                values: new object[] { new DateTime(2023, 8, 25, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(4939), new DateTime(2023, 9, 1, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(4940) });

            migrationBuilder.UpdateData(
                table: "UserTask",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DueDate" },
                values: new object[] { new DateTime(2023, 8, 25, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(4941), new DateTime(2023, 8, 27, 21, 10, 6, 433, DateTimeKind.Utc).AddTicks(4942) });
        }
    }
}
