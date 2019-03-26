using Microsoft.EntityFrameworkCore.Migrations;

namespace ScheduleSqlite.Migrations
{
    public partial class Additions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsForAfterDate",
                table: "ScheduleItems",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Period",
                table: "ScheduleItems",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PeriodQuantity",
                table: "ScheduleItems",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "RelativeToDate",
                table: "ScheduleItems",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "MessageTempaltes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsForAfterDate",
                table: "ScheduleItems");

            migrationBuilder.DropColumn(
                name: "Period",
                table: "ScheduleItems");

            migrationBuilder.DropColumn(
                name: "PeriodQuantity",
                table: "ScheduleItems");

            migrationBuilder.DropColumn(
                name: "RelativeToDate",
                table: "ScheduleItems");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "MessageTempaltes");
        }
    }
}
