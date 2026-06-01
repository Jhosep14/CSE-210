using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;

using System.Text.Json.Serialization;

class Comment
{
    private string _name;
    private string _comment;

    [JsonPropertyName("_name")]
    public string Name { get { return _name; } set { _name = value; } }

    [JsonPropertyName("_comment")]
    public string CommentText { get { return _comment; } set { _comment = value; } }

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