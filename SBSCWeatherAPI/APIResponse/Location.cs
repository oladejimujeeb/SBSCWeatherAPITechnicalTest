namespace SBSCWeatherAPI.APIResponse
{
    public class Location
    {
        public string name { get; set; }
        public string region { get; set; }
        public string country { get; set; }
        public float lat { get; set; }
        public float lon { get; set; }
        public string tz_id { get; set; }
        public int localtime_epoch { get; set; }
        public string localtime { get; set; }
        
       /* public float feelslike_c { get; set; }
        public float feelslike_f { get; set; }
        public float vis_km { get; set; }
        public float vis_miles { get; set; }
        public float uv { get; set; }
        public float gust_mph { get; set; }
        public float gust_kph { get; set; }*/
        

    }
}
