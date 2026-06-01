namespace FitnessApp
{
    abstract class Activity
    {
        private string _date;
        private int _length;
        private string _activityType;

        public Activity(string date, int length, string activityType)
        {
            _date = date;
            _length = length;
            _activityType = activityType;
        }

        public int GetLength()
        {
            return _length;
        }

        public virtual double GetDistance()
        {
            return 0;
        }
        public virtual double GetSpeed()
        {
            return 0;
        }
        public virtual double GetPace()
        {
            return 0;
        }

        public string GetSummary()
        {
            return $"{_date} {_activityType} ({_length} min)- Distance {GetDistance()} km, Speed {GetSpeed()} kph, Pace: {GetPace()} min per km";
        }

        public void DisplaySummary()
        {
            Console.WriteLine(GetSummary());
        }
    }
}