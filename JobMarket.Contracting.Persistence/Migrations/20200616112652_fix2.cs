using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobMarket.Contracting.Persistence.Migrations
{
    public partial class fix2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Template",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 16, 13, 26, 52, 274, DateTimeKind.Local).AddTicks(4831),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 6, 16, 13, 23, 40, 721, DateTimeKind.Local).AddTicks(256));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Placeholder",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 16, 13, 26, 52, 273, DateTimeKind.Local).AddTicks(4115),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 6, 16, 13, 23, 40, 719, DateTimeKind.Local).AddTicks(9746));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Contract",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 16, 13, 26, 52, 271, DateTimeKind.Local).AddTicks(1431),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 6, 16, 13, 23, 40, 717, DateTimeKind.Local).AddTicks(6799));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Clause",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 16, 13, 26, 52, 269, DateTimeKind.Local).AddTicks(1798),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 6, 16, 13, 23, 40, 715, DateTimeKind.Local).AddTicks(7270));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Article",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 16, 13, 26, 52, 260, DateTimeKind.Local).AddTicks(2994),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 6, 16, 13, 23, 40, 707, DateTimeKind.Local).AddTicks(573));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Template",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 16, 13, 23, 40, 721, DateTimeKind.Local).AddTicks(256),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 6, 16, 13, 26, 52, 274, DateTimeKind.Local).AddTicks(4831));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Placeholder",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 16, 13, 23, 40, 719, DateTimeKind.Local).AddTicks(9746),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 6, 16, 13, 26, 52, 273, DateTimeKind.Local).AddTicks(4115));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Contract",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 16, 13, 23, 40, 717, DateTimeKind.Local).AddTicks(6799),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 6, 16, 13, 26, 52, 271, DateTimeKind.Local).AddTicks(1431));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Clause",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 16, 13, 23, 40, 715, DateTimeKind.Local).AddTicks(7270),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 6, 16, 13, 26, 52, 269, DateTimeKind.Local).AddTicks(1798));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Article",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 16, 13, 23, 40, 707, DateTimeKind.Local).AddTicks(573),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 6, 16, 13, 26, 52, 260, DateTimeKind.Local).AddTicks(2994));
        }
    }
}
