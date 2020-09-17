using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobMarket.Contracting.Persistence.Migrations
{
    public partial class TemplateFKInContract : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Template",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 3, 13, 58, 58, 281, DateTimeKind.Local).AddTicks(4541),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 5, 31, 10, 47, 9, 30, DateTimeKind.Local).AddTicks(7919));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Placeholder",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 3, 13, 58, 58, 279, DateTimeKind.Local).AddTicks(4557),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 5, 31, 10, 47, 9, 29, DateTimeKind.Local).AddTicks(3582));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Contract",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 3, 13, 58, 58, 275, DateTimeKind.Local).AddTicks(6449),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 5, 31, 10, 47, 9, 26, DateTimeKind.Local).AddTicks(9496));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Clause",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 3, 13, 58, 58, 272, DateTimeKind.Local).AddTicks(3929),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 5, 31, 10, 47, 9, 24, DateTimeKind.Local).AddTicks(7665));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArticleContract",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 3, 13, 58, 58, 270, DateTimeKind.Local).AddTicks(9757),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 5, 31, 10, 47, 9, 23, DateTimeKind.Local).AddTicks(8666));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Article",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 3, 13, 58, 58, 257, DateTimeKind.Local).AddTicks(5881),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 5, 31, 10, 47, 9, 13, DateTimeKind.Local).AddTicks(9342));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Template",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 5, 31, 10, 47, 9, 30, DateTimeKind.Local).AddTicks(7919),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 6, 3, 13, 58, 58, 281, DateTimeKind.Local).AddTicks(4541));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Placeholder",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 5, 31, 10, 47, 9, 29, DateTimeKind.Local).AddTicks(3582),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 6, 3, 13, 58, 58, 279, DateTimeKind.Local).AddTicks(4557));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Contract",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 5, 31, 10, 47, 9, 26, DateTimeKind.Local).AddTicks(9496),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 6, 3, 13, 58, 58, 275, DateTimeKind.Local).AddTicks(6449));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Clause",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 5, 31, 10, 47, 9, 24, DateTimeKind.Local).AddTicks(7665),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 6, 3, 13, 58, 58, 272, DateTimeKind.Local).AddTicks(3929));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArticleContract",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 5, 31, 10, 47, 9, 23, DateTimeKind.Local).AddTicks(8666),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 6, 3, 13, 58, 58, 270, DateTimeKind.Local).AddTicks(9757));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Article",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 5, 31, 10, 47, 9, 13, DateTimeKind.Local).AddTicks(9342),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 6, 3, 13, 58, 58, 257, DateTimeKind.Local).AddTicks(5881));
        }
    }
}
