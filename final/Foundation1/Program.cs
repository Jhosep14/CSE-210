using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = Video.LoadVideos();
        Video video = new Video();
        Comment comment = new Comment();
        
        Console.WriteLine("Welcome to the YouTube Comment Manager");
        do
        {
            Console.WriteLine("--------------------------------------------------");
            video.DisplayVideoList();
            Console.WriteLine("1. Video Information");
            Console.WriteLine("2. Add Comment");
            Console.WriteLine("3. Remove Comment");
            Console.WriteLine("4. Exit");
            Console.WriteLine("--------------------------------------------------");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();
            int choiceVal = 0;

            switch (choice)
            {
                case "1":
                    Console.Write("Enter video index: ");
                    if (int.TryParse(Console.ReadLine(), out choiceVal))
                    {
                        Video selectedVideo = videos.Find(v => v.Index == choiceVal);
                        if (selectedVideo != null)
                        {
                            selectedVideo.DisplayVideoInfo(choiceVal);
                        }
                        else
                        {
                            Console.WriteLine("Video not found.");
                        }
                    }
                    break;

                case "2":
                    Console.Write("Enter video index to comment on: ");
                    if (int.TryParse(Console.ReadLine(), out choiceVal))
                    {
                        Video selectedVideo = videos.Find(v => v.Index == choiceVal);
                        if (selectedVideo != null)
                        {
                            Console.Write("Enter your name: ");
                            string name = Console.ReadLine();
                            Console.Write("Enter your comment: ");
                            string commentText = Console.ReadLine();

                            Comment.AddComment(videos, selectedVideo, name, commentText);
                            Console.WriteLine("Comment saved successfully!");
                        }
                        else
                        {
                            Console.WriteLine("Video not found.");
                        }
                    }
                    break;

                case "3":
                    Console.Write("Enter video index to remove comment from: ");
                    if (int.TryParse(Console.ReadLine(), out choiceVal))
                    {
                        Video selectedVideo = videos.Find(v => v.Index == choiceVal);
                        if (selectedVideo != null)
                        {
                            if (selectedVideo.Comments != null && selectedVideo.Comments.Count > 0)
                            {
                                Console.WriteLine("Comments:");
                                for (int i = 0; i < selectedVideo.Comments.Count; i++)
                                {
                                    Console.WriteLine($"{i + 1}. @{selectedVideo.Comments[i].Name}: \"{selectedVideo.Comments[i].CommentText}\"");
                                }
                                Console.Write("Select comment number to remove: ");
                                if (int.TryParse(Console.ReadLine(), out int commentChoice) && commentChoice > 0 && commentChoice <= selectedVideo.Comments.Count)
                                {
                                    Comment selectedComment = selectedVideo.Comments[commentChoice - 1];
                                    Comment.RemoveComment(videos, selectedVideo, selectedComment);
                                    Console.WriteLine("Comment removed successfully!");
                                }
                                else
                                {
                                    Console.WriteLine("Invalid comment selection.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("This video has no comments.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Video not found.");
                        }
                    }
                    break;

                case "4":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        } while (true);
        Console.WriteLine("Thanks for using the YouTube Comment Manager!");
    }
}