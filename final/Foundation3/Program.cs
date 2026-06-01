using System;

namespace EventPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lecture event
            Lecture lecture = new Lecture("Stake Conference", "A conference for the stake", "2026-05-15", "9:00 AM", "123 E 1st St", "Elder Smith", "1000");
            
            //Outdoor Gathering
            OutdoorGathering outdoorGathering = new OutdoorGathering("Summer Concert", "A concert in the park", "2026-06-25", "7:00 PM", "123 E 1st St", "Sunny with a high of 75 degrees");

            //Reception
            Reception reception = new Reception("Wedding Reception", "A reception for a wedding", "2026-08-15", "6:00 PM", "123 E 1st St", "[EMAIL_ADDRESS]");

            Console.WriteLine("1");
            lecture.GetShortDescription();
            Console.WriteLine("2");
            lecture.GetStandardDescription();
            Console.WriteLine("3");
            lecture.GetFullDescription();

            Console.WriteLine("4");
            outdoorGathering.GetShortDescription();
            Console.WriteLine("5");
            outdoorGathering.GetStandardDescription();
            Console.WriteLine("6");
            outdoorGathering.GetFullDescription();

            Console.WriteLine("7");
            reception.GetShortDescription();
            Console.WriteLine("8");
            reception.GetStandardDescription();
            Console.WriteLine("9");
            reception.GetFullDescription();
        }
    }
}