using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    class StopWatch
    {
        static DateTime _startTime;
        static DateTime _stopTime;

        public static DateTime Start ()
        {
            Console.WriteLine("our watch has started");
            _startTime = DateTime.Now;
            return _startTime;
        }

        public static DateTime Stop ()
        {
            Console.WriteLine("our watch has stopped");
            _stopTime = DateTime.Now;
            return _stopTime;
        }

        public static TimeSpan Duration ()
        {

            TimeSpan span = _stopTime -_startTime;
            Console.WriteLine("The duration is : " + span);
            return span;
        }
    }
}
