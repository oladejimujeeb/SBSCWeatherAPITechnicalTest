using System;
using System.ComponentModel.DataAnnotations;

namespace SBSCWeatherAPI.Dto
{
    public class ReportDate
    {
        [DataType(DataType.Date)]
        public DateTime WeatherReportDate { get; set; }
    }
}
