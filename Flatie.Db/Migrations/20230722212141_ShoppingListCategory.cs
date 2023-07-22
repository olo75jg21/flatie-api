using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Flatie.Db.Migrations
{
    /// <inheritdoc />
    public partial class ShoppingListCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "ShoppingList");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "ShoppingList",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PurchasePrice",
                table: "ShoppingList",
                type: "integer",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingList_CategoryId",
                table: "ShoppingList",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingList_ShoppingListCategory_CategoryId",
                table: "ShoppingList",
                column: "CategoryId",
                principalTable: "ShoppingListCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingList_ShoppingListCategory_CategoryId",
                table: "ShoppingList");

            migrationBuilder.DropTable(
                name: "ShoppingListCategory");

            migrationBuilder.DropIndex(
                name: "IX_ShoppingList_CategoryId",
                table: "ShoppingList");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "ShoppingList");

            migrationBuilder.DropColumn(
                name: "PurchasePrice",
                table: "ShoppingList");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "ShoppingList",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
