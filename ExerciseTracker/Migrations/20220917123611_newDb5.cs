using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExerciseTracker.Migrations
{
    public partial class newDb5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Workout");

            migrationBuilder.DropColumn(
                name: "Time",
                table: "Workout");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateEnd",
                table: "Workout",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateStart",
                table: "Workout",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<TimeSpan>(
                name: "Duration",
                table: "Workout",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateEnd",
                table: "Workout");

            migrationBuilder.DropColumn(
                name: "DateStart",
                table: "Workout");

            migrationBuilder.DropColumn(
                name: "Duration",
                table: "Workout");

            migrationBuilder.AddColumn<string>(
                name: "Date",
                table: "Workout",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Time",
                table: "Workout",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
