using Microsoft.EntityFrameworkCore;
using SBSCWeatherAPI.Entities;

namespace SBSCWeatherAPI.Context
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext>options):base(options)
        {

        }
        public DbSet<WeatherReport> WeatherReports { get; set; }

    }
}
