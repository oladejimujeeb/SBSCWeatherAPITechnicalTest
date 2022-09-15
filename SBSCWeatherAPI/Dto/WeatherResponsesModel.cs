using System.Collections.Generic;

namespace SBSCWeatherAPI.Dto
{
    public class WeatherResponsesModel:BaseResponseModel
    {
        public IList<WeatherDto> Data { get; set; } = new List<WeatherDto>();
    }
}
