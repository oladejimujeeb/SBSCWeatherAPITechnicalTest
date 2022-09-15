using Microsoft.EntityFrameworkCore.Migrations;

namespace SBSCWeatherAPI.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Date",
                table: "WeatherReports",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WeatherCondition",
                table: "WeatherReports",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WindDirection",
                table: "WeatherReports",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "WindSpeed",
                table: "WeatherReports",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "WeatherReports");

            migrationBuilder.DropColumn(
                name: "WeatherCondition",
                table: "WeatherReports");

            migrationBuilder.DropColumn(
                name: "WindDirection",
                table: "WeatherReports");

            migrationBuilder.DropColumn(
                name: "WindSpeed",
                table: "WeatherReports");
        }
    }
}
