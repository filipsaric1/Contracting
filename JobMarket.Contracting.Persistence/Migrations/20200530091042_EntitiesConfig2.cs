using Microsoft.EntityFrameworkCore.Migrations;

namespace JobMarket.Contracting.Persistence.Migrations
{
    public partial class EntitiesConfig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Article_Clause_ClauseId",
                table: "Article");

            migrationBuilder.DropForeignKey(
                name: "FK_Contract_Template_TemplateId",
                table: "Contract");

            migrationBuilder.AlterColumn<int>(
                name: "TemplateId",
                table: "Contract",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClauseId",
                table: "Article",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Article_Clause_ClauseId",
                table: "Article",
                column: "ClauseId",
                principalTable: "Clause",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Contract_Template_TemplateId",
                table: "Contract",
                column: "TemplateId",
                principalTable: "Template",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Article_Clause_ClauseId",
                table: "Article");

            migrationBuilder.DropForeignKey(
                name: "FK_Contract_Template_TemplateId",
                table: "Contract");

            migrationBuilder.AlterColumn<int>(
                name: "TemplateId",
                table: "Contract",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ClauseId",
                table: "Article",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Article_Clause_ClauseId",
                table: "Article",
                column: "ClauseId",
                principalTable: "Clause",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Contract_Template_TemplateId",
                table: "Contract",
                column: "TemplateId",
                principalTable: "Template",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
