using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace SBSCWeatherAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WeatherReports",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Region = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    Latitude = table.Column<float>(nullable: false),
                    Longtude = table.Column<float>(nullable: false),
                    Cloud = table.Column<int>(nullable: false),
                    LocalTime = table.Column<string>(nullable: true),
                    Temprature_Celsius = table.Column<float>(nullable: false),
                    Temprature_Fahrenheit = table.Column<float>(nullable: false),
                    Last_updated = table.Column<string>(nullable: true),
                    Humidity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeatherReports", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WeatherReports");
        }
    }
}
