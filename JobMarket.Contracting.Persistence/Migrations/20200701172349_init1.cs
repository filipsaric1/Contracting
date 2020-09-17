using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobMarket.Contracting.Persistence.Migrations
{
    public partial class init1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Template",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 1, 19, 23, 49, 428, DateTimeKind.Local).AddTicks(4818),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 1, 18, 54, 58, 404, DateTimeKind.Local).AddTicks(3760));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Placeholder",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 1, 19, 23, 49, 427, DateTimeKind.Local).AddTicks(1709),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 1, 18, 54, 58, 403, DateTimeKind.Local).AddTicks(2897));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Contract",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 1, 19, 23, 49, 424, DateTimeKind.Local).AddTicks(4152),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 1, 18, 54, 58, 401, DateTimeKind.Local).AddTicks(802));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Clause",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 1, 19, 23, 49, 421, DateTimeKind.Local).AddTicks(9261),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 1, 18, 54, 58, 398, DateTimeKind.Local).AddTicks(9677));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Article",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 1, 19, 23, 49, 407, DateTimeKind.Local).AddTicks(3250),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 1, 18, 54, 58, 385, DateTimeKind.Local).AddTicks(248));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Template",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 1, 18, 54, 58, 404, DateTimeKind.Local).AddTicks(3760),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 1, 19, 23, 49, 428, DateTimeKind.Local).AddTicks(4818));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Placeholder",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 1, 18, 54, 58, 403, DateTimeKind.Local).AddTicks(2897),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 1, 19, 23, 49, 427, DateTimeKind.Local).AddTicks(1709));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Contract",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 1, 18, 54, 58, 401, DateTimeKind.Local).AddTicks(802),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 1, 19, 23, 49, 424, DateTimeKind.Local).AddTicks(4152));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Clause",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 1, 18, 54, 58, 398, DateTimeKind.Local).AddTicks(9677),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 1, 19, 23, 49, 421, DateTimeKind.Local).AddTicks(9261));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Article",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 1, 18, 54, 58, 385, DateTimeKind.Local).AddTicks(248),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 1, 19, 23, 49, 407, DateTimeKind.Local).AddTicks(3250));
        }
    }
}
