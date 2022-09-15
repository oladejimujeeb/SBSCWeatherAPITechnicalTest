using SBSCWeatherAPI.Context;
using SBSCWeatherAPI.Dto;
using SBSCWeatherAPI.Entities;
using SBSCWeatherAPI.Interface.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SBSCWeatherAPI.Services.Repository
{
    public class WeatherRepository : IWeatherRepository
    {
        private readonly ApplicationContext _context;

        public WeatherRepository(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<bool> AddWeatherReport(WeatherReport report)
        {
            await _context.WeatherReports.AddAsync(report);
            return true;
        }

        public IList<WeatherReport> GetWeatherReportByDate(string date)
        {
            
            return _context.WeatherReports.Where(x=>x.Date==date).ToList();
        }

        public WeatherReport GetWeatherReportByState(string state)
        {
            var report = _context.WeatherReports.Where(x => x.Region.ToLower() == state.ToLower()).ToList().LastOrDefault();
            return report;
        }

        public async Task<bool> SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
