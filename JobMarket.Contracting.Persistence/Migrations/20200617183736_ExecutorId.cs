using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobMarket.Contracting.Persistence.Migrations
{
    public partial class ExecutorId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Template",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 17, 20, 37, 36, 139, DateTimeKind.Local).AddTicks(6862),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 6, 16, 21, 12, 52, 298, DateTimeKind.Local).AddTicks(7107));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Placeholder",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 17, 20, 37, 36, 138, DateTimeKind.Local).AddTicks(6584),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 6, 16, 21, 12, 52, 296, DateTimeKind.Local).AddTicks(7645));

            migrationBuilder.AlterColumn<string>(
                name: "ExecutorId",
                table: "Contract",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Contract",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 17, 20, 37, 36, 136, DateTimeKind.Local).AddTicks(3918),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 6, 16, 21, 12, 52, 292, DateTimeKind.Local).AddTicks(7730));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Clause",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 17, 20, 37, 36, 134, DateTimeKind.Local).AddTicks(6456),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 6, 16, 21, 12, 52, 289, DateTimeKind.Local).AddTicks(3908));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Article",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 17, 20, 37, 36, 125, DateTimeKind.Local).AddTicks(9756),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 6, 16, 21, 12, 52, 275, DateTimeKind.Local).AddTicks(7017));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Template",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 16, 21, 12, 52, 298, DateTimeKind.Local).AddTicks(7107),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 6, 17, 20, 37, 36, 139, DateTimeKind.Local).AddTicks(6862));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Placeholder",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 16, 21, 12, 52, 296, DateTimeKind.Local).AddTicks(7645),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 6, 17, 20, 37, 36, 138, DateTimeKind.Local).AddTicks(6584));

            migrationBuilder.AlterColumn<int>(
                name: "ExecutorId",
                table: "Contract",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Contract",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 16, 21, 12, 52, 292, DateTimeKind.Local).AddTicks(7730),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 6, 17, 20, 37, 36, 136, DateTimeKind.Local).AddTicks(3918));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Clause",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 16, 21, 12, 52, 289, DateTimeKind.Local).AddTicks(3908),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 6, 17, 20, 37, 36, 134, DateTimeKind.Local).AddTicks(6456));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Article",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 16, 21, 12, 52, 275, DateTimeKind.Local).AddTicks(7017),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 6, 17, 20, 37, 36, 125, DateTimeKind.Local).AddTicks(9756));
        }
    }
}
