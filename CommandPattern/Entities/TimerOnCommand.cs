using CommandPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Entities
{
    internal class TimerOnCommand : Command
    {
        private Timer _timer;
        public TimerOnCommand(Timer timer) 
        {
            this._timer = timer;
        }
        public void Execute()
        {
            this._timer.Start();
        }
    }
}
