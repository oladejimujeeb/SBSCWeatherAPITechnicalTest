using SBSCWeatherAPI.Dto;
using SBSCWeatherAPI.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SBSCWeatherAPI.Interface.IRepository
{
    public interface IWeatherRepository
    {
        Task<bool> AddWeatherReport(WeatherReport report);
        Task<bool> SaveChangesAsync();
        IList<WeatherReport> GetWeatherReportByDate(string date);
        WeatherReport GetWeatherReportByState(string state);

    }
}
