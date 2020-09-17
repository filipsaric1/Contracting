using Microsoft.EntityFrameworkCore.Migrations;

namespace JobMarket.Contracting.Persistence.Migrations
{
    public partial class EntitiesConfig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Placeholder_Article_ArticleId",
                table: "Placeholder");

            migrationBuilder.AlterColumn<int>(
                name: "ArticleId",
                table: "Placeholder",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Placeholder_Article_ArticleId",
                table: "Placeholder",
                column: "ArticleId",
                principalTable: "Article",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Placeholder_Article_ArticleId",
                table: "Placeholder");

            migrationBuilder.AlterColumn<int>(
                name: "ArticleId",
                table: "Placeholder",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Placeholder_Article_ArticleId",
                table: "Placeholder",
                column: "ArticleId",
                principalTable: "Article",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
