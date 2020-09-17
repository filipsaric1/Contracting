using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobMarket.Contracting.Persistence.Migrations
{
    public partial class ContextRemovePlaceholder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "ArticleContract");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ArticleContract");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Template",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 5, 20, 59, 15, 624, DateTimeKind.Local).AddTicks(9167),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 6, 3, 13, 58, 58, 281, DateTimeKind.Local).AddTicks(4541));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Placeholder",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 5, 20, 59, 15, 621, DateTimeKind.Local).AddTicks(2394),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 6, 3, 13, 58, 58, 279, DateTimeKind.Local).AddTicks(4557));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Contract",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 5, 20, 59, 15, 614, DateTimeKind.Local).AddTicks(2194),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 6, 3, 13, 58, 58, 275, DateTimeKind.Local).AddTicks(6449));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Clause",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 5, 20, 59, 15, 608, DateTimeKind.Local).AddTicks(3266),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 6, 3, 13, 58, 58, 272, DateTimeKind.Local).AddTicks(3929));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Article",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 5, 20, 59, 15, 581, DateTimeKind.Local).AddTicks(2774),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 6, 3, 13, 58, 58, 257, DateTimeKind.Local).AddTicks(5881));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Template",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 3, 13, 58, 58, 281, DateTimeKind.Local).AddTicks(4541),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 6, 5, 20, 59, 15, 624, DateTimeKind.Local).AddTicks(9167));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Placeholder",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 3, 13, 58, 58, 279, DateTimeKind.Local).AddTicks(4557),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 6, 5, 20, 59, 15, 621, DateTimeKind.Local).AddTicks(2394));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Contract",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 3, 13, 58, 58, 275, DateTimeKind.Local).AddTicks(6449),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 6, 5, 20, 59, 15, 614, DateTimeKind.Local).AddTicks(2194));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Clause",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 3, 13, 58, 58, 272, DateTimeKind.Local).AddTicks(3929),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 6, 5, 20, 59, 15, 608, DateTimeKind.Local).AddTicks(3266));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "ArticleContract",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 3, 13, 58, 58, 270, DateTimeKind.Local).AddTicks(9757));

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "ArticleContract",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Article",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 3, 13, 58, 58, 257, DateTimeKind.Local).AddTicks(5881),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 6, 5, 20, 59, 15, 581, DateTimeKind.Local).AddTicks(2774));
        }
    }
}
