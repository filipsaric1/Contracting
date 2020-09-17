using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobMarket.Contracting.Persistence.Migrations
{
    public partial class RoleAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Template",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 6, 11, 52, 1, 826, DateTimeKind.Local).AddTicks(7298),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 6, 5, 20, 59, 15, 624, DateTimeKind.Local).AddTicks(9167));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Placeholder",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 6, 11, 52, 1, 825, DateTimeKind.Local).AddTicks(3823),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 6, 5, 20, 59, 15, 621, DateTimeKind.Local).AddTicks(2394));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Contract",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 6, 11, 52, 1, 823, DateTimeKind.Local).AddTicks(1256),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 6, 5, 20, 59, 15, 614, DateTimeKind.Local).AddTicks(2194));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Clause",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 6, 11, 52, 1, 821, DateTimeKind.Local).AddTicks(601),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 6, 5, 20, 59, 15, 608, DateTimeKind.Local).AddTicks(3266));

            migrationBuilder.AddColumn<int>(
                name: "Role",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 2);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Article",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 6, 11, 52, 1, 810, DateTimeKind.Local).AddTicks(8286),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 6, 5, 20, 59, 15, 581, DateTimeKind.Local).AddTicks(2774));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Role",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Template",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 5, 20, 59, 15, 624, DateTimeKind.Local).AddTicks(9167),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 6, 6, 11, 52, 1, 826, DateTimeKind.Local).AddTicks(7298));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Placeholder",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 5, 20, 59, 15, 621, DateTimeKind.Local).AddTicks(2394),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 6, 6, 11, 52, 1, 825, DateTimeKind.Local).AddTicks(3823));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Contract",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 5, 20, 59, 15, 614, DateTimeKind.Local).AddTicks(2194),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 6, 6, 11, 52, 1, 823, DateTimeKind.Local).AddTicks(1256));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Clause",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 5, 20, 59, 15, 608, DateTimeKind.Local).AddTicks(3266),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 6, 6, 11, 52, 1, 821, DateTimeKind.Local).AddTicks(601));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Article",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 5, 20, 59, 15, 581, DateTimeKind.Local).AddTicks(2774),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 6, 6, 11, 52, 1, 810, DateTimeKind.Local).AddTicks(8286));
        }
    }
}
