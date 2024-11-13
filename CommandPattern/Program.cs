using CommandPattern.Entities;
using CommandPattern.Interfaces;

TimerControl timerControl = new TimerControl();
CommandPattern.Entities.Timer timer = new CommandPattern.Entities.Timer();
TimerOnCommand timerOn = new TimerOnCommand(timer);
timerControl.SetCommand(timerOn);
timerControl.PressButton();
