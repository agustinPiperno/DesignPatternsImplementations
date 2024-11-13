using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Entities
{
    internal class Timer
    {
        public Timer() { }
        public void Start()
        {
            Console.WriteLine("Timer started");
        }
        public void Stop()
        {
            Console.WriteLine("Timer stopped");
        }
    }
}
