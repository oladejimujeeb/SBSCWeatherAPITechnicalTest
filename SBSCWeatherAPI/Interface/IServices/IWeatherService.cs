using SBSCWeatherAPI.Dto;
using SBSCWeatherAPI.Entities;
using System;
using System.Threading.Tasks;

namespace SBSCWeatherAPI.Interface.IServices
{
    public interface IWeatherService
    {
        Task<bool> AddWeatherReport();
        WeatherResponsesModel GetWeatherReportByDate(DateTime date);
        WeatherResponseModel GetWeatherReportByState(string state);
    }
}
