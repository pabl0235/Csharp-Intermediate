using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section2Exercises
{
    public class Stopwatch
    {
        private static bool stopwatchOngoing = false;
        private static DateTime start;
        private static DateTime stop;
        private static TimeSpan duration;
        //public static TimeSpan Duration { get; set; }
        public static void Start()
        {
            if (stopwatchOngoing)
            {
                throw new System.InvalidOperationException("stopwatch already started.");
            }
            else
            {
                stopwatchOngoing = true;
                start = DateTime.Now;
            }
        }
        public static void Stop()
        {
            stop = DateTime.Now;
            stopwatchOngoing = false;
            duration = stop- start;
            //Duration = duration;
            Console.WriteLine("Duration: {0}. From {1} to {2}", duration, start, stop);
        }
        public static TimeSpan GetDuration()
        {
            return duration;
        }
    }
}
