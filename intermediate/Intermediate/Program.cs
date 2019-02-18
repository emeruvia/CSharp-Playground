using System;

namespace Intermediate
{
    static class Program
    {
        static void Main(string[] args)
        {
            InitStopWatch();
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
                    if (String.IsNullOrEmpty(input))
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
                            break;
                    }
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
