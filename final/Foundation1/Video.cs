using System;
using System.Collections.Generic;
using System.Text;

namespace Foundation1
{
    class Video
    {
        private string _author;
        private string _title;
        private List<Comment> _comments = new List<Comment>();
        private double _lenght;

        public Video(string author, string title, double lenght)
        {
            _author = author;
            _title = title;
            _lenght = lenght;
        }

        public Video(string author, string title, double lenght, List<Comment> comments)
        {
            _author = author;
            _title = title;
            _lenght = lenght;
            _comments.AddRange(comments);
        }

        private string getTimeString()
        {
            double minutes = Math.Round(_lenght / 60);
            double seconds = Math.Round( _lenght % 60);

            return $"{minutes}:{seconds}";
        }

        private string VideoInfoString()
        {
            string info = $"{_author}: {_title} [{getTimeString()}] \nComments[{CommentNumber()}]: ";
            return info;
        }

        private int CommentNumber()
        {
            return _comments.Count();
        }

        public void Display()
        {
            Console.WriteLine(VideoInfoString());
            Console.WriteLine();
            foreach (Comment comment in _comments)
            {
                comment.Display();
                Console.WriteLine();
            }
        }

        public void AddComment(Comment comment)
        {
            _comments.Add(comment);
        }

        public void AddComments(List<Comment> comments)
        {
            _comments.AddRange(comments);
        }
    }
}
