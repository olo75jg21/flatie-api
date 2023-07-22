using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Flatie.Db.Migrations
{
    /// <inheritdoc />
    public partial class UserAppRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Role",
                table: "User");

            migrationBuilder.AddColumn<int>(
                name: "UserAppRoleId",
                table: "User",
                type: "integer",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_User_UserAppRoleId",
                table: "User",
                column: "UserAppRoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_User_UserAppRole_UserAppRoleId",
                table: "User",
                column: "UserAppRoleId",
                principalTable: "UserAppRole",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_UserAppRole_UserAppRoleId",
                table: "User");

            migrationBuilder.DropTable(
                name: "UserAppRole");

            migrationBuilder.DropIndex(
                name: "IX_User_UserAppRoleId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "UserAppRoleId",
                table: "User");

            migrationBuilder.AddColumn<int>(
                name: "Role",
                table: "User",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
