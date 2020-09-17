using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobMarket.Contracting.Persistence.Migrations
{
    public partial class nullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Template",
                nullable: false,
                defaultValue: new DateTime(2020, 5, 31, 10, 42, 18, 737, DateTimeKind.Local).AddTicks(8160),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 5, 30, 17, 27, 16, 153, DateTimeKind.Local).AddTicks(4893));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Placeholder",
                nullable: false,
                defaultValue: new DateTime(2020, 5, 31, 10, 42, 18, 736, DateTimeKind.Local).AddTicks(4556),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 5, 30, 17, 27, 16, 150, DateTimeKind.Local).AddTicks(9142));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Contract",
                nullable: false,
                defaultValue: new DateTime(2020, 5, 31, 10, 42, 18, 734, DateTimeKind.Local).AddTicks(1265),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 5, 30, 17, 27, 16, 147, DateTimeKind.Local).AddTicks(2709));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Clause",
                nullable: false,
                defaultValue: new DateTime(2020, 5, 31, 10, 42, 18, 732, DateTimeKind.Local).AddTicks(490),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 5, 30, 17, 27, 16, 143, DateTimeKind.Local).AddTicks(9906));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArticleContract",
                nullable: false,
                defaultValue: new DateTime(2020, 5, 31, 10, 42, 18, 731, DateTimeKind.Local).AddTicks(1826),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 5, 30, 17, 27, 16, 142, DateTimeKind.Local).AddTicks(2330));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Article",
                nullable: false,
                defaultValue: new DateTime(2020, 5, 31, 10, 42, 18, 721, DateTimeKind.Local).AddTicks(4730),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 5, 30, 17, 27, 16, 126, DateTimeKind.Local).AddTicks(8877));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Template",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 5, 30, 17, 27, 16, 153, DateTimeKind.Local).AddTicks(4893),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 5, 31, 10, 42, 18, 737, DateTimeKind.Local).AddTicks(8160));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Placeholder",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 5, 30, 17, 27, 16, 150, DateTimeKind.Local).AddTicks(9142),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 5, 31, 10, 42, 18, 736, DateTimeKind.Local).AddTicks(4556));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Contract",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 5, 30, 17, 27, 16, 147, DateTimeKind.Local).AddTicks(2709),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 5, 31, 10, 42, 18, 734, DateTimeKind.Local).AddTicks(1265));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Clause",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 5, 30, 17, 27, 16, 143, DateTimeKind.Local).AddTicks(9906),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 5, 31, 10, 42, 18, 732, DateTimeKind.Local).AddTicks(490));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArticleContract",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 5, 30, 17, 27, 16, 142, DateTimeKind.Local).AddTicks(2330),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 5, 31, 10, 42, 18, 731, DateTimeKind.Local).AddTicks(1826));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Article",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 5, 30, 17, 27, 16, 126, DateTimeKind.Local).AddTicks(8877),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 5, 31, 10, 42, 18, 721, DateTimeKind.Local).AddTicks(4730));
        }
    }
}
