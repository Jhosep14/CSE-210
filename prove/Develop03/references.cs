using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

class Reference
{
    private List<Scriptures> _scriptures;

    public Reference()
    {
        string _jsonString = File.ReadAllText("data.json");
        JsonSerializerOptions options = new JsonSerializerOptions();
        options.PropertyNameCaseInsensitive = true;
        _scriptures = JsonSerializer.Deserialize<List<Scriptures>>(_jsonString, options);

    }

    
    public void DisplayReferences()
    {
        foreach (Scriptures id in _scriptures)
        {
            id.GetReference();
        }

    }

    public Scriptures DisplayReferenceText(int scripture_choice)
    {
        foreach (Scriptures id in _scriptures)
        {
            if (scripture_choice == id.Id)
            {
                Console.WriteLine("------------------------------------" + '\n');
                Console.Write(id.Text + "\n");
                return id;
            }
        } 
        return null;
    }

    public Scriptures GetRandomScripture()
    {
        Random random = new Random();
        int random_scripture = random.Next(1, _scriptures.Count + 1);
        foreach (Scriptures id in _scriptures)
        {
            if (random_scripture == id.Id)
            {
                Console.WriteLine("------------------------------------" + '\n');
                Console.Write(id.Text + "\n");
                return id;
            }
        }
        return null;
    }
    
    
}