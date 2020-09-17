using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobMarket.Contracting.Persistence.Migrations
{
    public partial class fix_34 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Template",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 16, 16, 0, 50, 252, DateTimeKind.Local).AddTicks(6446),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 6, 16, 15, 54, 23, 782, DateTimeKind.Local).AddTicks(2065));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Placeholder",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 16, 16, 0, 50, 251, DateTimeKind.Local).AddTicks(5803),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 6, 16, 15, 54, 23, 781, DateTimeKind.Local).AddTicks(1073));

            migrationBuilder.AlterColumn<bool>(
                name: "IsAnnex",
                table: "Contract",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Contract",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 16, 16, 0, 50, 249, DateTimeKind.Local).AddTicks(3276),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 6, 16, 15, 54, 23, 779, DateTimeKind.Local).AddTicks(1697));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Clause",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 16, 16, 0, 50, 247, DateTimeKind.Local).AddTicks(4382),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 6, 16, 15, 54, 23, 777, DateTimeKind.Local).AddTicks(3545));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Article",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 16, 16, 0, 50, 238, DateTimeKind.Local).AddTicks(5835),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 6, 16, 15, 54, 23, 768, DateTimeKind.Local).AddTicks(5891));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Template",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 16, 15, 54, 23, 782, DateTimeKind.Local).AddTicks(2065),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 6, 16, 16, 0, 50, 252, DateTimeKind.Local).AddTicks(6446));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Placeholder",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 16, 15, 54, 23, 781, DateTimeKind.Local).AddTicks(1073),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 6, 16, 16, 0, 50, 251, DateTimeKind.Local).AddTicks(5803));

            migrationBuilder.AlterColumn<bool>(
                name: "IsAnnex",
                table: "Contract",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Contract",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 16, 15, 54, 23, 779, DateTimeKind.Local).AddTicks(1697),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 6, 16, 16, 0, 50, 249, DateTimeKind.Local).AddTicks(3276));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Clause",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 16, 15, 54, 23, 777, DateTimeKind.Local).AddTicks(3545),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 6, 16, 16, 0, 50, 247, DateTimeKind.Local).AddTicks(4382));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Article",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 16, 15, 54, 23, 768, DateTimeKind.Local).AddTicks(5891),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 6, 16, 16, 0, 50, 238, DateTimeKind.Local).AddTicks(5835));
        }
    }
}
