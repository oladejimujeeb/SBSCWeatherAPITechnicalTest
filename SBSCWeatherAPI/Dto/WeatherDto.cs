namespace SBSCWeatherAPI.Dto
{
    public class WeatherDto
    {
        int id { get; set; }
        public string Name { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public float Latitude { get; set; }
        public float Longtude { get; set; }
        public int Cloud { get; set; }
        public string LocalTime { get; set; }
        public float Temprature_Celsius { get; set; }
        public float Temprature_Fahrenheit { get; set; }
        public string Last_updated { get; set; }
        public int Humidity { get; set; }
        public string WeatherCondition { get; set; }
        public float WindSpeed { get; set; }
        public string WindDirection { get; set; }
    }
    
}
