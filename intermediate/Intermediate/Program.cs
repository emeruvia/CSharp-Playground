using System;
using System.Runtime.InteropServices.ComTypes;

namespace Intermediate
{
    static class Program
    {
        static void Main(string[] args)
        {
            InitStopWatch();
            InitPosts();
            Console.ReadLine();
        }

        private static void InitStopWatch()
        {
            var stopWatch = new StopWatch();
            var loop = true;
            while (loop)
            {
                try
                {
                    var input = Console.ReadLine()?.ToLower();
                    if (string.IsNullOrEmpty(input))
                    {
                        throw new InvalidOperationException("Input cannot be null or empty");
                    }

                    switch (input)
                    {
                        case "start":
                            stopWatch.Start();
                            break;
                        case "stop":
                            stopWatch.Stop();
                            break;
                        case "exit":
                            loop = false;
                            break;
                        default:
                            throw new InvalidOperationException("Your options are 'start', 'stop' or 'exit'.");
                    }
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private static void InitPosts()
        {
            // Random StackOverflow post
            const string title = "What is the difference between a field and a property?";
            const string description = "In C#, what makes a field different from a property," +
                                       " and when should a field be used instead of a property?";
            var newPost = new Post(title, description);

            //Randomize the number of posts
            var rand = new Random();
            var i = rand.Next(150);
            while (i > 0)
            {
                var temp = rand.Next(i);
                if (temp % 2 == 0)
                {
                    newPost.Downvote();
                }
                else
                {
                    newPost.Upvote();
                }

                i--;
            }

            var message = $"Title: {newPost.Title}\n" +
                          $"at: {newPost.DateTime}\t" +
                          $"votes: {newPost.Votes}\n\n" +
                          $"Description:\n{newPost.Description}";
            Console.WriteLine(message);
        }
    }
}
