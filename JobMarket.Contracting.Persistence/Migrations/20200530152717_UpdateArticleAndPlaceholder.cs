using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobMarket.Contracting.Persistence.Migrations
{
    public partial class UpdateArticleAndPlaceholder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Template",
                nullable: false,
                defaultValue: new DateTime(2020, 5, 30, 17, 27, 16, 153, DateTimeKind.Local).AddTicks(4893),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 5, 30, 11, 19, 21, 872, DateTimeKind.Local).AddTicks(6973));

            migrationBuilder.AlterColumn<int>(
                name: "Location",
                table: "Placeholder",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Placeholder",
                nullable: false,
                defaultValue: new DateTime(2020, 5, 30, 17, 27, 16, 150, DateTimeKind.Local).AddTicks(9142),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 5, 30, 11, 19, 21, 872, DateTimeKind.Local).AddTicks(101));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Contract",
                nullable: false,
                defaultValue: new DateTime(2020, 5, 30, 17, 27, 16, 147, DateTimeKind.Local).AddTicks(2709),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 5, 30, 11, 19, 21, 870, DateTimeKind.Local).AddTicks(1006));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Clause",
                nullable: false,
                defaultValue: new DateTime(2020, 5, 30, 17, 27, 16, 143, DateTimeKind.Local).AddTicks(9906),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 5, 30, 11, 19, 21, 868, DateTimeKind.Local).AddTicks(3569));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArticleContract",
                nullable: false,
                defaultValue: new DateTime(2020, 5, 30, 17, 27, 16, 142, DateTimeKind.Local).AddTicks(2330),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 5, 30, 11, 19, 21, 867, DateTimeKind.Local).AddTicks(6299));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Article",
                nullable: false,
                defaultValue: new DateTime(2020, 5, 30, 17, 27, 16, 126, DateTimeKind.Local).AddTicks(8877),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 5, 30, 11, 19, 21, 859, DateTimeKind.Local).AddTicks(4550));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Template",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 5, 30, 11, 19, 21, 872, DateTimeKind.Local).AddTicks(6973),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 5, 30, 17, 27, 16, 153, DateTimeKind.Local).AddTicks(4893));

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "Placeholder",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(int),
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Placeholder",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 5, 30, 11, 19, 21, 872, DateTimeKind.Local).AddTicks(101),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 5, 30, 17, 27, 16, 150, DateTimeKind.Local).AddTicks(9142));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Contract",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 5, 30, 11, 19, 21, 870, DateTimeKind.Local).AddTicks(1006),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 5, 30, 17, 27, 16, 147, DateTimeKind.Local).AddTicks(2709));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Clause",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 5, 30, 11, 19, 21, 868, DateTimeKind.Local).AddTicks(3569),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 5, 30, 17, 27, 16, 143, DateTimeKind.Local).AddTicks(9906));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArticleContract",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 5, 30, 11, 19, 21, 867, DateTimeKind.Local).AddTicks(6299),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 5, 30, 17, 27, 16, 142, DateTimeKind.Local).AddTicks(2330));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Article",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 5, 30, 11, 19, 21, 859, DateTimeKind.Local).AddTicks(4550),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 5, 30, 17, 27, 16, 126, DateTimeKind.Local).AddTicks(8877));
        }
    }
}
