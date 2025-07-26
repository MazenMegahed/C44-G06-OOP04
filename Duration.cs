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
        public Duration(int NUM)
        {
            if (NUM / 3600 >= 1)
            {
                Hours = NUM / 3600;
                if (Hours % 60 >= 1)
                {
                    Minutes = (NUM - (Hours * 3600)) / 60;
                    Seconds = ((NUM - (Hours * 3600) - (Minutes * 60))) % 60;
                    output = $"Hours : {Hours} , Minutes : {Minutes} , Seconds : {Seconds}";
                }
            }
            else
            {
                if (NUM % 60 >= 1)
                {
                    Minutes = (NUM ) / 60;
                    Seconds = ((NUM - (Minutes * 60))) % 60;
                    output = $"Minutes : {Minutes} , Seconds : {Seconds}";
                }

            }
        }
        public override string ToString() 
        {
            return output;
        }
    }
}
