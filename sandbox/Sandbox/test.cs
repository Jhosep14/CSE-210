public class Test
{
    public static void RunCode()
    {
        int age = 14;
        int y = 18;
        Console.Write("What's your favorite color?");
        string color = Console.ReadLine();

        Console.WriteLine(age);

        if (age>y)
        {
            Console.WriteLine("greater");
        }
        else
        {
            Console.WriteLine("lesser");
        }
        if (color == "red")
        {
            Console.WriteLine("Good choice");
            Console.WriteLine("Do it again!");
        }
        else
        {
            Console.WriteLine("You suck!");
        }
    }
}

