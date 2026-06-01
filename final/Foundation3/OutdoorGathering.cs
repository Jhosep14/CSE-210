namespace EventPlanner
{
    class OutdoorGathering : Event
    {
        private string _weatherForecast;

        public OutdoorGathering(string title, string description, string date, string time, string address, string weatherForecast)
        : base(title, description, date, time, address)
        {
            _weatherForecast = weatherForecast;
        }

        public override void GetFullDescription()
        {
            base.GetFullDescription();
            Console.WriteLine($"Event Type: Outdoor Gathering\nWeather Forecast: {_weatherForecast}");
        }
        public override void GetShortDescription()
        {
            Console.WriteLine($"Event Type: Outdoor Gathering");
            base.GetShortDescription();
        }
    }
}