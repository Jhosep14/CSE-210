namespace EventPlanner
{
    class Lecture : Event
    {
        private string _eventSpeaker;
        private string _eventCapacity;

        public Lecture(string title, string description, string date, string time, string address, string eventSpeaker, string eventCapacity)
        : base(title, description, date, time, address)
        {
            _eventSpeaker = eventSpeaker;
            _eventCapacity = eventCapacity;
        }

        public override void GetFullDescription()
        {
            base.GetFullDescription();
            Console.WriteLine($"Event Type: Lecture\nSpeaker: {_eventSpeaker}\nCapacity: {_eventCapacity}");
        }
        public override void GetShortDescription()
        {
            Console.WriteLine($"Event Type: Lecture");
            base.GetShortDescription();
        }
    }
}