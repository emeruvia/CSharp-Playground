using System;

namespace Intermediate
{
    // The job of this class is to simulate a stopwatch.
    internal class StopWatch : IStopWatch
    {
        private TimeSpan Interval { get; set; }
        private DateTime _startTimeSpan;
        private DateTime _stopTimeSpan;
        private bool _started;

        public void Start()
        {
            if (_started)
            {
                throw new System.InvalidOperationException("Can only start the timer once");
            }

            _startTimeSpan = DateTime.Now;
            _started = true;
            Console.WriteLine("started...");
        }

        public void Stop()
        {
            if (!_started)
            {
                throw new System.InvalidOperationException("The timer was not started");
            }

            _started = false;
            _stopTimeSpan = DateTime.Now;
            Interval = _stopTimeSpan - _startTimeSpan;
            Console.WriteLine("stopped...");
            PrintTimer();
        }

        private void PrintTimer()
        {
            var message = $"\nStarted at: {_startTimeSpan}\t\t" +
                          $"Stopped at: {_stopTimeSpan}\n" +
                          $"Timer: {Interval.Seconds} seconds...";
            Console.WriteLine(message);
        }
    }
}