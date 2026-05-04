using System;
using System.Text.Json.Serialization;

public class Scriptures
{
    public int Id { get; private set; }
    public string Book { get; private set; }
    public int Chapter { get; private set; }
    public int Verse { get; private set; }
    public int EndVerse { get; private set; }
    public string Text { get; private set; }

    [JsonConstructor]
    public Scriptures(int id, string book, int chapter, int verse, int endVerse, string text)
    {
        Id = id;
        Book = book;
        Chapter = chapter;
        Verse = verse;
        EndVerse = endVerse;
        Text = text;
    }
    public void GetReference()
    {
        Console.Write(Id + ". " + Book + " " + Chapter + ":" + Verse + "-"+ EndVerse + "\n");

    }

}
    