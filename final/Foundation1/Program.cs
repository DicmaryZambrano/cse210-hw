using System;
using Foundation1;
class Program
{
    static void Main(string[] args)
    {

        Comment comment1 = new Comment("Jon Doe","This video is so cool!");
        Comment comment2 = new Comment("Sofy28","What camera do you use?");
        Comment comment3 = new Comment("Laura Baby","This is my favorite game!");
        Comment comment4 = new Comment("DarkLink79","minute 1:18 was so funny");
        Comment comment5 = new Comment("Marcos","This recipe was delicious");
        Comment comment6 = new Comment("Maria White","I made this for my mom and she loved it");
        Comment comment7 = new Comment("Mario123","Your cat is so adorablee");
        Comment comment8 = new Comment("Luigui342","I have to buy this toy for my cat");
        Comment comment9 = new Comment("Karen23","Is it really ok to squish that cat?");

        List<Comment> comments1 = new List<Comment>()
        {
            comment1,
            comment2,
            comment3
        };
        List<Comment> comments2 = new List<Comment>()
        {
            comment4,
            comment5,
            comment6
        };
        List<Comment> comments3 = new List<Comment>()
        {
            comment7,
            comment8,
            comment9
        };

        Video video1 = new Video("Marcos Gaming", "How to beat Raiden Shogun BossFight in Genshins Inpact", 2600);
        Video video2 = new Video("Sofia Cooks", "How Cook That - Chocolate Cake", 2200);
        Video video3 = new Video("CatVideos", "Fluffy the cat #short", 15);

        video1.AddComments(comments1);
        video2.AddComments(comments2);
        video3.AddComments(comments3);

        List<Video> videos = new List<Video>()
        {
            video1,
            video2,
            video3
        };

        foreach (Video video in videos)
        {
            Console.WriteLine(new string('*', 100));
            video.Display();
        }
    }
}