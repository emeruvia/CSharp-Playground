using System;

namespace Intermediate
{
    static class Program
    {
        static void Main(string[] args)
        {
            var stopWatch = new StopWatch();
            var input = Console.ReadLine()?.ToLower();
            do
            {
                if (input == "start")
                {
                    try
                    {
                        stopWatch.Start();
                    }
                    catch (InvalidOperationException exception)
                    {
                        Console.WriteLine(exception.Message);
                    }
                }
                else if (input == "stop")
                {
                    stopWatch.Stop();
                    var s = $"Total time: {stopWatch.Interval.Seconds} seconds...";
                    Console.WriteLine(s);
                }

                input = Console.ReadLine();
            } while (input != null && !input.Equals("exit"));
        }
    }
}
