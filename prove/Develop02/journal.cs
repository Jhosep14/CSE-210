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

    /// <summary>
    /// Removes a specific journal entry from the CSV file based on a given date.
    /// It displays all entries for that date and prompts the user to select which one to delete.
    /// </summary>
    public void RemoveJournalEntry(string date_to_remove)
    {
        string filePath = "journal.csv";
        
        // Read all lines from the file into a List so we can easily modify them
        List<string> lines = File.ReadAllLines(filePath).ToList();
        
        // Loop through the entries. We start at index 1 to skip the CSV header.
        for(int i = 1; i < lines.Count; i++)
        {
            // Check if the current line contains the date we are looking for
            if (lines[i].Contains(date_to_remove))
            {
                // Display the line index and the entry content to the user
                Console.WriteLine(i + ". " + lines[i]);
            }
        }
        
        Console.WriteLine("-------------------------------------------");
        Console.Write("Which entry would you like to remove?: ");
        
        // Get the line number to remove from the user
        int entry_to_remove = int.Parse(Console.ReadLine());
        
        // Ensure the chosen line number is valid (greater than 0 to protect the header)
        if (entry_to_remove > 0 && entry_to_remove <= lines.Count)
        {
            // Remove the selected entry from the list
            lines.RemoveAt(entry_to_remove);
            
            // Overwrite the file with the updated list of entries
            File.WriteAllLines(filePath, lines);
            Console.WriteLine("Entry Removed!");
        }
        else
        {
            Console.WriteLine("Invalid entry number.");
        }
    }
    
    
}