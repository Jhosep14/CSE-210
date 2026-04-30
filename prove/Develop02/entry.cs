using System.IO;
using System.Collections.Generic;
using System;

public class Entry
{
    public string _date = DateTime.Now.ToString("dd/MM/yyyy");
    public string _prompt;
    public string _response;

    List<Entry> entries = new List<Entry>();

    public void AddEntry(string prompt, string response)
    {
        Entry singleEntry = new Entry();
        singleEntry._prompt = prompt;
        singleEntry._response = response;
        singleEntry._date = _date;
        entries.Add(singleEntry);
    }

    public void SaveEntry(string prompt, string response)
    {
        string filePath = "journal.csv";
        foreach(Entry entry in entries)
        {
            File.AppendAllText(filePath, entry._date + "," + entry._prompt + "," + entry._response + "\n");
        }
        entries.Clear();
    } 

    public void DisplayEntry(string prompt, string response)
    {
        Console.WriteLine("Here are your Today's journal entries:");
        foreach (Entry entry in entries)
        {
            Console.WriteLine($"Date: {entry._date} - Prompt: {entry._prompt}");
            Console.WriteLine($"{entry._response}");
            
        }
    }
    
}
