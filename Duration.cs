using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP_4
{
    internal class Duration
    {
        int Hours;
        int Minutes;
        int Seconds;
        string output;
        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours; Minutes = minutes; Seconds = seconds;
            output = $"Hours : {Hours} , Minutes : {Minutes} , Seconds : {Seconds}";
        }
        public Duration() { }
        public Duration(int NUM)
        {
            Hours = NUM / 3600;
            Minutes = (NUM % 3600) / 60;
            Seconds = NUM % 60;

            if (Hours > 0)
                output = $"Hours : {Hours} , Minutes : {Minutes} , Seconds : {Seconds}";
            else if (Minutes > 0)
                output = $"Minutes : {Minutes} , Seconds : {Seconds}";
            else
                output = $"Seconds : {Seconds}";

        }
        public override string ToString()
        {
            return output;
        }
        public static Duration operator +(Duration a, Duration b)
        {
            int totalSeconds = a.Hours * 3600 + a.Minutes * 60 + a.Seconds
                      + b.Hours * 3600 + b.Minutes * 60 + b.Seconds;

            return new Duration(totalSeconds);


        }
        public static Duration operator +(Duration a, int NUM)
        {
            int totalSeconds = a.Hours * 3600 + a.Minutes * 60 + a.Seconds + NUM;

            return new Duration(totalSeconds);
        }

        public static Duration operator +(int NUM, Duration a)
        {
            int totalSeconds = a.Hours * 3600 + a.Minutes * 60 + a.Seconds + NUM;

            return new Duration(totalSeconds);

        }
        public static Duration operator ++(Duration a)
        {
            int totalSeconds = a.Hours * 3600 + ((a.Minutes+1) * 60) + a.Seconds ;

            return new Duration(totalSeconds);

        }
        public static Duration operator --(Duration a)
        {
            int totalSeconds = a.Hours * 3600 + ((a.Minutes - 1) * 60) + a.Seconds;

            return new Duration(totalSeconds);
        }
        public static Duration operator -(Duration a, Duration b)
        {
            int totalSeconds = (a.Hours-b.Hours) * 3600 + ((a.Minutes - b.Minutes) * 60) + (a.Seconds-b.Seconds);

            return new Duration(totalSeconds);

        }
        public static bool operator >(Duration a, Duration b)
        {
            if ((a.Hours * 3600 + a.Minutes * 60 + a.Seconds) - (b.Hours * 3600 + b.Minutes * 60 + b.Seconds) > 0)
            {
                return true;
            }
            return false;
        }
        public static bool operator <(Duration a, Duration b)
        {
            if ((a.Hours * 3600 + a.Minutes * 60 + a.Seconds) - (b.Hours * 3600 + b.Minutes * 60 + b.Seconds) < 0)
            {
                return true;
            }
            return false;
        }
    }
}
