using System;

namespace Intermediate
{
    // This class models a StackOverflow post
    // title, description, date/time it was created
    // upvote or downvote
    // current vote value
    class Post : IPost
    {
        private int _votes;

        public int Votes => _votes;
        public string Title { get; }
        public string Description { get;}
        public DateTime DateTime { get; }

        public Post(string title, string description)
        {
            Title = title;
            Description = description;
            DateTime = DateTime.Now;
        }

        public int UpVote()
        {
            return _votes += 1;
        }

        public int DownVote()
        {
            return _votes -= 1;
        }
    }
}