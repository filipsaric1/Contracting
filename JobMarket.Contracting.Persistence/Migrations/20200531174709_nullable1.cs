using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobMarket.Contracting.Persistence.Migrations
{
    public partial class nullable1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "TemplateClause");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Template");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Placeholder");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Contract");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Clause");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "ArticleContract");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Article");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Template",
                nullable: false,
                defaultValue: new DateTime(2020, 5, 31, 10, 47, 9, 30, DateTimeKind.Local).AddTicks(7919),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 5, 31, 10, 42, 18, 737, DateTimeKind.Local).AddTicks(8160));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Placeholder",
                nullable: false,
                defaultValue: new DateTime(2020, 5, 31, 10, 47, 9, 29, DateTimeKind.Local).AddTicks(3582),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 5, 31, 10, 42, 18, 736, DateTimeKind.Local).AddTicks(4556));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Contract",
                nullable: false,
                defaultValue: new DateTime(2020, 5, 31, 10, 47, 9, 26, DateTimeKind.Local).AddTicks(9496),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 5, 31, 10, 42, 18, 734, DateTimeKind.Local).AddTicks(1265));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Clause",
                nullable: false,
                defaultValue: new DateTime(2020, 5, 31, 10, 47, 9, 24, DateTimeKind.Local).AddTicks(7665),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 5, 31, 10, 42, 18, 732, DateTimeKind.Local).AddTicks(490));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArticleContract",
                nullable: false,
                defaultValue: new DateTime(2020, 5, 31, 10, 47, 9, 23, DateTimeKind.Local).AddTicks(8666),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 5, 31, 10, 42, 18, 731, DateTimeKind.Local).AddTicks(1826));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Article",
                nullable: false,
                defaultValue: new DateTime(2020, 5, 31, 10, 47, 9, 13, DateTimeKind.Local).AddTicks(9342),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 5, 31, 10, 42, 18, 721, DateTimeKind.Local).AddTicks(4730));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "TemplateClause",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Template",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 5, 31, 10, 42, 18, 737, DateTimeKind.Local).AddTicks(8160),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 5, 31, 10, 47, 9, 30, DateTimeKind.Local).AddTicks(7919));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Template",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Placeholder",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 5, 31, 10, 42, 18, 736, DateTimeKind.Local).AddTicks(4556),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 5, 31, 10, 47, 9, 29, DateTimeKind.Local).AddTicks(3582));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Placeholder",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Contract",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 5, 31, 10, 42, 18, 734, DateTimeKind.Local).AddTicks(1265),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 5, 31, 10, 47, 9, 26, DateTimeKind.Local).AddTicks(9496));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Contract",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Clause",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 5, 31, 10, 42, 18, 732, DateTimeKind.Local).AddTicks(490),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 5, 31, 10, 47, 9, 24, DateTimeKind.Local).AddTicks(7665));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Clause",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArticleContract",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 5, 31, 10, 42, 18, 731, DateTimeKind.Local).AddTicks(1826),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 5, 31, 10, 47, 9, 23, DateTimeKind.Local).AddTicks(8666));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "ArticleContract",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Article",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 5, 31, 10, 42, 18, 721, DateTimeKind.Local).AddTicks(4730),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 5, 31, 10, 47, 9, 13, DateTimeKind.Local).AddTicks(9342));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Article",
                type: "datetime2",
                nullable: true);
        }
    }
}
