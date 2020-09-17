using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobMarket.Contracting.Persistence.Migrations
{
    public partial class fix_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Template",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 16, 15, 54, 23, 782, DateTimeKind.Local).AddTicks(2065),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 6, 16, 13, 26, 52, 274, DateTimeKind.Local).AddTicks(4831));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Placeholder",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 16, 15, 54, 23, 781, DateTimeKind.Local).AddTicks(1073),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 6, 16, 13, 26, 52, 273, DateTimeKind.Local).AddTicks(4115));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Contract",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 16, 15, 54, 23, 779, DateTimeKind.Local).AddTicks(1697),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 6, 16, 13, 26, 52, 271, DateTimeKind.Local).AddTicks(1431));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Clause",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 16, 15, 54, 23, 777, DateTimeKind.Local).AddTicks(3545),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 6, 16, 13, 26, 52, 269, DateTimeKind.Local).AddTicks(1798));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Article",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 16, 15, 54, 23, 768, DateTimeKind.Local).AddTicks(5891),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 6, 16, 13, 26, 52, 260, DateTimeKind.Local).AddTicks(2994));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Template",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 16, 13, 26, 52, 274, DateTimeKind.Local).AddTicks(4831),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 6, 16, 15, 54, 23, 782, DateTimeKind.Local).AddTicks(2065));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Placeholder",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 16, 13, 26, 52, 273, DateTimeKind.Local).AddTicks(4115),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 6, 16, 15, 54, 23, 781, DateTimeKind.Local).AddTicks(1073));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Contract",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 16, 13, 26, 52, 271, DateTimeKind.Local).AddTicks(1431),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 6, 16, 15, 54, 23, 779, DateTimeKind.Local).AddTicks(1697));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Clause",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 16, 13, 26, 52, 269, DateTimeKind.Local).AddTicks(1798),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 6, 16, 15, 54, 23, 777, DateTimeKind.Local).AddTicks(3545));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Article",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 16, 13, 26, 52, 260, DateTimeKind.Local).AddTicks(2994),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 6, 16, 15, 54, 23, 768, DateTimeKind.Local).AddTicks(5891));
        }
    }
}
