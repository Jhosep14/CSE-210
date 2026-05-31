using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;

class Comment
{
    public string _name { get; set; }
    public string _comment { get; set; }

    public Comment() { }
    
    public Comment(string name, string comment)
    {
        _name = name;
        _comment = comment;
    }

    public static List<Comment> LoadComments()
    {
        var videos = Video.LoadVideos();
        var allComments = new List<Comment>();
        foreach (var video in videos)
        {
            if (video.Comments != null)
            {
                allComments.AddRange(video.Comments);
            }
        }
        return allComments;
    }

    public static List<Video> DeserializeVideosFromJson(string jsonString)
    {
        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        return JsonSerializer.Deserialize<List<Video>>(jsonString, options) ?? new List<Video>();
    }

    public static List<Comment> GetComments(string name, string comment)
    {
        var newComment = new Comment(name, comment);
        return new List<Comment> { newComment };
    }

    public static void AddComment(List<Video> videos, Video video, string name, string comment)
    {
        video.AddComment(new Comment(name, comment));
        
        File.WriteAllText("videos_info.json", JsonSerializer.Serialize(videos, new JsonSerializerOptions { WriteIndented = true }));
    }

    public static void RemoveComment(List<Video> videos, Video video, Comment comment)
    {
        video.RemoveComment(comment);
        
        File.WriteAllText("videos_info.json", JsonSerializer.Serialize(videos, new JsonSerializerOptions { WriteIndented = true }));
    }

    public void DisplayComment()
    {
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Comment: {_comment}");
        Console.WriteLine("--------------------------------------------------");
    }
}