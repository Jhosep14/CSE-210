using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;

class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Link { get; set; }
    public int LengthInSeconds { get; set; }
    public int Index { get; set; }
    public List<Comment> Comments { get; set; }

    public Video() 
    {
        Comments = new List<Comment>();
    }
    
    public Video(string title, string author, int lengthInSeconds, string link, int index)
    {
        Title = title;
        Author = author;
        LengthInSeconds = lengthInSeconds;
        Link = link;
        Index = index;
        Comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        if (Comments == null)
        {
            Comments = new List<Comment>();
        }
        Comments.Add(comment);
    }

    public void RemoveComment(Comment comment)
    {
        if (Comments != null)
        {
            Comments.Remove(comment);
        }
    }

    public static List<Video> LoadVideos()
    {
        if (!File.Exists("videos_info.json")) return new List<Video>();
        var videosJson = File.ReadAllText("videos_info.json");
        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        return JsonSerializer.Deserialize<List<Video>>(videosJson, options) ?? new List<Video>();
    }

    public void DisplayVideoList()
    {
        List<Video> videos = LoadVideos();
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Videos List:");
        Console.WriteLine("--------------------------------------------------");
        foreach (var video in videos)
        {
            Console.WriteLine($"{video.Index}. {video.Title}");
        }
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("");
    }

    public void DisplayVideoInfo(int choice)
    {
        if (choice == Index)
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Link: {Link}");
            Console.WriteLine($"Length: {LengthInSeconds} seconds");
            Console.WriteLine($"Number of comments: {Comments?.Count ?? 0}");
            if (Comments != null)
            {
                foreach (var comment in Comments)
                {
                    if (comment != null)
                    {
                        Console.WriteLine($"- {comment._name}: \"{comment._comment}\"");
                    }
                }
            }
            Console.WriteLine("--------------------------------------------------");
        }
    }
}
