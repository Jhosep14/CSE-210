using System.Collections.Generic;
using System;
using System.IO;
using System.Linq;

public class Journal
{
    public string _date;
    public string _prompt;
    public string _response;

    public void DisplayJournal()
    {
        string filePath = "journal.csv";
        
        string [] lines = File.ReadAllLines(filePath);
                
        foreach (string line in lines)
        {   
            if (line.Contains("Date, Prompt, Response"))
            {
                continue;
            }

            string [] parts = line.Split(',');

            if (parts.Length >= 3)
            {
                string date = parts[0];
                string prompt = parts[1];
                string response = parts[2];

                Console.WriteLine($"Date: {date} - Prompt: {prompt}");
                Console.WriteLine($"Response: {response}");
            }    
        }
    }

    public void RemoveJournalEntry(string date_to_remove)
    {
        string filePath = "journal.csv";
        List<string> lines = File.ReadAllLines(filePath).ToList();
        for(int i = 1; i < lines.Count; i++)
        {
            if (lines[i].Contains(date_to_remove))
            {
                Console.WriteLine(i + ". " + lines[i]);
            }
        }
        Console.WriteLine("-------------------------------------------");
        Console.Write("Which entry would you like to remove?: ");
        int entry_to_remove = int.Parse(Console.ReadLine());
        
        if (entry_to_remove > 0 && entry_to_remove <= lines.Count)
        {
            lines.RemoveAt(entry_to_remove);
            File.WriteAllLines(filePath, lines);
            Console.WriteLine("Entry Removed!");
        }
        else
        {
            Console.WriteLine("Invalid entry number.");
        }
    }
    
    
}