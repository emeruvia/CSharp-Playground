using System;

namespace Intermediate
{
    // The job of this class is to simulate a stopwatch.
    class StopWatch : IStopWatch
    {
        public TimeSpan Interval { get; private set; }
        private DateTime _startTimeSpan;
        private bool _started;

        public void Start()
        {
            if (_started)
            {
                throw new System.InvalidOperationException("Can only start the timer once");
            }
            _startTimeSpan = DateTime.Now;
            _started = true;
            var s = $"Started timer at {_startTimeSpan}";
            Console.WriteLine(s);
        }

        public void Stop()
        {
            _started = false;
            var stop = DateTime.Now;
            Interval = stop - _startTimeSpan;
            var s = $"Stopped timer at {stop}";
            Console.WriteLine(s);
        }
    }
}