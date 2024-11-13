using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CommandPattern.Interfaces;

namespace CommandPattern.Entities
{
    internal class TimerControl
    {
        private Command? _command;
        public TimerControl() { }
        public void SetCommand(Command command)
        {
            this._command = command;
        }
        public void PressButton()
        {
            this._command?.Execute();
        }
    }
}
