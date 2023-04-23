using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XayDungLopStopWatch
{
    public class StopWatch
    {
        private double startTime, endTime;
        public double elapsedTime;

        public void Reset()
        {
            startTime = 0;
        }
        public void Start()
        {
            startTime = DateTime.Now.Ticks;
        }

        public void Stop()
        {
            endTime = DateTime.Now.Ticks;
            elapsedTime = endTime - startTime;
        }

        public void GetElapsedTimePerMillisecond()
        {
            elapsedTime = elapsedTime / 10000;
        }
    }
}
