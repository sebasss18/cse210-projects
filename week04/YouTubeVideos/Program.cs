using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.\n");

        Video v1 = new Video("How to make french fries", "Ana Retes", 420);
        Video v2 = new Video("Top 10 songs 2025", "MusicZone", 300);
        Video v3 = new Video("How to invest", "investors", 350);


        v1.AddComment(new Comment("Ana", "Thank you, it was delicious!"));
        v1.AddComment(new Comment("Cris", "Very useful, thanks!"));
        v1.AddComment(new Comment("sebas", "Can you do Guacamole next?"));
        
        v2.AddComment(new Comment("Pam", "Song #3 is the best"));
        v2.AddComment(new Comment("Gael", "Nice playlist"));
        v2.AddComment(new Comment("Diego", "You forgot the Joji album!"));

        v3.AddComment(new Comment("Flor", "Really helpfull, thank you!"));
        v3.AddComment(new Comment("Paty", "Awesome explanation!"));
        v3.AddComment(new Comment("josh", "Idk why Im seeing this, I have 2 dollars In my bank account"));

        List<Video> videos = new List<Video>() {v1, v2, v3};

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()}");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine ($" - {comment.GetName()}: {comment.GetText()}");
            }
            Console.WriteLine();
        }
    }
}