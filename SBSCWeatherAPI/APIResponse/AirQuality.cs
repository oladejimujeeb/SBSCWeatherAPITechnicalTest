namespace SBSCWeatherAPI.APIResponse
{
    public class AirQuality
    {
        public double co { get; set; }
        public double no2 { get; set; }
        public double o3 { get; set; }
        public double so2{ get; set; }
        public double pm2_5{ get; set; }
        public double pm10{ get; set; }
        public int us_epa_index { get; set; }
        public int gb_defra_index{ get; set; }
}
}
