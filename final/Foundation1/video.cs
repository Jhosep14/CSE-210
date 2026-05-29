using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;

class Video : DataStructure
{
    public Video() : base() { }
    
    public Video(string title, string author, int lengthInSeconds, string link, int index)
        : base(title, author, lengthInSeconds, link, index)
    {
    }

    public static List<Video> LoadVideos()
    {
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
                        Console.WriteLine($"- {comment.GetName()}: \"{comment.GetComment()}\"");
                    }
                }
            }
            Console.WriteLine("--------------------------------------------------");
        }
    }
}
