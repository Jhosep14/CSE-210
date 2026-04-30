public class NameList
{
    List<string> _namesList = new List<string>();

    public void addName(string name)
    {
        if (name == "quit")
        {
            return;
        }
        else
        {
            _namesList.Add(name);
        }
    }

    public void displayList()
    {
        Console.WriteLine("Names in list");
        Console.WriteLine("-------------");
        foreach (string name in _namesList)
        {
            Console.WriteLine(name);
        }
    }

}
