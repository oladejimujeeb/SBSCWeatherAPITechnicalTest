using Microsoft.Extensions.Hosting;
using System.Threading;
using System.Threading.Tasks;
using System;
using Microsoft.Extensions.DependencyInjection;
using SBSCWeatherAPI.Interface.IServices;

namespace SBSCWeatherAPI.BackgroundServices
{
    public class WeatherBackgroundService : BackgroundService
    {
        
        private readonly IServiceProvider _serviceProvider;

        public WeatherBackgroundService(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while(!stoppingToken.IsCancellationRequested)
            {
                using(var weatherService =_serviceProvider.CreateScope())
                {
                    var addWeather = weatherService.ServiceProvider.GetRequiredService<IWeatherService>();
                    await addWeather.AddWeatherReport();
                    Console.WriteLine("weather report saved successfully");
                    await Task.Delay(TimeSpan.FromMinutes(15), stoppingToken);
                }
            }
           
        }
    }
}
