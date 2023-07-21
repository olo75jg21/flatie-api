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
            migrationBuilder.CreateIndex(
                name: "IX_ShoppingList_PucharsedByUserId",
                table: "ShoppingList",
                column: "PucharsedByUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingList_User_PucharsedByUserId",
                table: "ShoppingList",
                column: "PucharsedByUserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingList_User_PucharsedByUserId",
                table: "ShoppingList");

            migrationBuilder.DropIndex(
                name: "IX_ShoppingList_PucharsedByUserId",
                table: "ShoppingList");
        }
    }
}
