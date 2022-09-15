using SBSCWeatherAPI.APIResponse;
using SBSCWeatherAPI.Dto;
using SBSCWeatherAPI.Entities;
using SBSCWeatherAPI.Interface.IRepository;
using SBSCWeatherAPI.Interface.IServices;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SBSCWeatherAPI.Implementation.Services
{
    public class WeatherService : IWeatherService
    {
        private readonly IWeatherRepository _repository;

        public WeatherService(IWeatherRepository repository)
        {
            _repository = repository;
        }

        public async Task<bool> AddWeatherReport()
        {
            string[] state = { "Ibadan", "Abuja", "Lagos", "Akure", "Kaduna", "Kano", "Asaba" };
            foreach (var st in state) 
            { 
                using var httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var response = await httpClient.GetAsync($"http://api.weatherapi.com/v1/current.json?key=041616c45cdd4df3b16180246221309&q={st}&aqi=yes\r\n");
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var responseToString = await response.Content.ReadAsStringAsync();
                    var weatherReportApi = JsonSerializer.Deserialize<WeatherData>(responseToString);
                    var weatherReport = new WeatherReport
                    {
                        Cloud = weatherReportApi.current.cloud,
                        Country = weatherReportApi.location.country,
                        Humidity = weatherReportApi.current.humidity,
                        Last_updated = weatherReportApi.current.last_updated,
                        Latitude = weatherReportApi.location.lat,
                        LocalTime = weatherReportApi.location.localtime,
                        Longtude = weatherReportApi.location.lon,
                        Name = weatherReportApi.location.name,
                        Region = weatherReportApi.location.region,
                        Temprature_Celsius = weatherReportApi.current.temp_c,
                        Temprature_Fahrenheit = weatherReportApi.current.temp_f,
                        WeatherCondition = weatherReportApi.current.condition.text,
                        WindSpeed = weatherReportApi.current.wind_kph,
                        WindDirection = weatherReportApi.current.wind_dir,
                        Date = DateTime.Now.ToString("MM/dd/yyyy")
                    };
                    await _repository.AddWeatherReport(weatherReport);
                    await _repository.SaveChangesAsync();
                }
            }
            return true;
        }

        public WeatherResponsesModel GetWeatherReportByDate(DateTime date)
        {
            if(date>DateTime.Now)
            {
                return new WeatherResponsesModel()
                {
                    Message = "No weather report yet",
                    Status = false,

                };
            }
            var reportDate = date.ToString("MM/dd/yyyy");
            var report = _repository.GetWeatherReportByDate(reportDate).Select(x=> new WeatherDto
            {
                Cloud = x.Cloud,
                Country = x.Country,
                Humidity = x.Humidity,
                Last_updated = x.Last_updated,
                Latitude = x.Latitude,
                LocalTime = x.LocalTime,
                Longtude = x.Longtude,
                Name = x.Name,
                Region = x.Region,
                Temprature_Celsius = x.Temprature_Celsius,
                Temprature_Fahrenheit=x.Temprature_Fahrenheit,
                WeatherCondition = x.WeatherCondition,
                WindDirection = x.WindDirection,
                WindSpeed = x.WindSpeed
                
            }).ToList();
            if(report.Count < 1)
            {
                return new WeatherResponsesModel() 
                { 
                    Message ="No weather report yet",
                    Status = false,
                   
                };
            }
            return new WeatherResponsesModel()
            {
                Status=true,
                Data = report
            };
        }

        public WeatherResponseModel GetWeatherReportByState(string state)
        {
            var report = _repository.GetWeatherReportByState(state);
            if(report == null)
            {
                return new WeatherResponseModel()
                {
                    Message = "No weather report",
                    Status = false,

                };
            }
            return new WeatherResponseModel()
            {
                
                Status = true,
                Data = new WeatherDto 
                {
                    Cloud = report.Cloud,
                    Country = report.Country,
                    Humidity = report.Humidity,
                    Last_updated = report.Last_updated,
                    Latitude = report.Latitude,
                    LocalTime = report.LocalTime,
                    Longtude = report.Longtude,
                    Name = report.Name,
                    Region = report.Region,
                    Temprature_Celsius = report.Temprature_Celsius,
                    Temprature_Fahrenheit = report.Temprature_Fahrenheit,
                    WeatherCondition = report.WeatherCondition,
                    WindDirection = report.WindDirection,
                    WindSpeed = report.WindSpeed
                }

            };
            
        }
    }
}
