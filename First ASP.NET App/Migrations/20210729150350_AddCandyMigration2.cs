using Microsoft.EntityFrameworkCore.Migrations;

namespace First_ASP.NET_App.Migrations
{
    public partial class AddCandyMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Candies_Categories_CategoryId",
                table: "Candies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Candies",
                table: "Candies");

            migrationBuilder.RenameTable(
                name: "Candies",
                newName: "Candy");

            migrationBuilder.RenameIndex(
                name: "IX_Candies_CategoryId",
                table: "Candy",
                newName: "IX_Candy_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Candy",
                table: "Candy",
                column: "CandyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Candy_Categories_CategoryId",
                table: "Candy",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Candy_Categories_CategoryId",
                table: "Candy");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Candy",
                table: "Candy");

            migrationBuilder.RenameTable(
                name: "Candy",
                newName: "Candies");

            migrationBuilder.RenameIndex(
                name: "IX_Candy_CategoryId",
                table: "Candies",
                newName: "IX_Candies_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Candies",
                table: "Candies",
                column: "CandyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Candies_Categories_CategoryId",
                table: "Candies",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
