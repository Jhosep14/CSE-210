public class Person
{
    public string _firstName;
    public string _lastName;
    
    public void ShowEasternName()
    {
        Console.WriteLine($"{_lastName}, {_firstName}");
    }
    
    public void ShowWesternName()
    {
        Console.WriteLine($"{_firstName} {_lastName}");
    }

}
