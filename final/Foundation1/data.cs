using System.IO;
using System.Collections.Generic;
using System.Text.Json;

class DataStructure
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Link { get; set; }
    public int LengthInSeconds { get; set; }
    public List<Comment> Comments { get; set; }
    public List<Video> Videos { get; set; }
    public int Index { get; set; }

    public string _name { get; set; }
    public string _comment { get; set; }

    public DataStructure() { }

    public DataStructure(string name, string comment)
    {
        _name = name;
        _comment = comment;
    }

    public DataStructure(string title, string author, int lengthInSeconds, string link, int index)
    {
        Title = title;
        Author = author;
        Link = link;
        Index = index;
        LengthInSeconds = lengthInSeconds;
        Comments = new List<Comment>();
        Videos = new List<Video>();
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

    public string GetName()
    {
        return _name;
    }

    public string GetComment()
    {
        return _comment;
    }

    public string GetTitle()
    {
        return Title;
    }
    
    public string GetAuthor()
    {
        return Author;
    }
    
    public int GetLengthInSeconds()
    {
        return LengthInSeconds;
    }
    
    public List<Comment> GetComments()
    {
        return Comments;
    }
    public List<Video> GetVideos()
    {
        return Videos;
    }
    public int GetIndex()
    {
        return Index;
    }
    public string GetLink()
    {
        return Link;
    }
}