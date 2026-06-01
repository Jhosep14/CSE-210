namespace EventPlanner
{
    class Reception : Event
    {
        private string _eventRSVP;

        public Reception(string title, string description, string date, string time, string address, string eventRSVP)
        : base(title, description, date, time, address)
        {
            _eventRSVP = eventRSVP;
        }

        public override void GetFullDescription()
        {
            base.GetFullDescription();
            Console.WriteLine($"Event Type: Reception\nRSVP: {_eventRSVP}");
        }
        public override void GetShortDescription()
        {
            Console.WriteLine($"Event Type: Reception");
            base.GetShortDescription();
        }
    }
}