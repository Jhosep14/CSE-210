using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;

class Video
{
    private string _title;
    private string _author;
    private string _link;
    private int _lengthInSeconds;
    private int _index;
    private List<Comment> _comments;

    public string Title { get { return _title; } set { _title = value; } }
    public string Author { get { return _author; } set { _author = value; } }
    public string Link { get { return _link; } set { _link = value; } }
    public int LengthInSeconds { get { return _lengthInSeconds; } set { _lengthInSeconds = value; } }
    public int Index { get { return _index; } set { _index = value; } }
    public List<Comment> Comments { get { return _comments; } set { _comments = value; } }

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
                        Console.WriteLine($"- {comment.Name}: \"{comment.CommentText}\"");
                    }
                }
            }
            Console.WriteLine("--------------------------------------------------");
        }
    }
}
