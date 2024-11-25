using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern.Entities
{
    internal abstract class WorkoutLoader
    {
        public void LoadWorkout()
        {
            LoadWarmup();
            LoadProgression();
            LoadRestTimer();
        }

        public void LoadWarmup()
        {
            Console.WriteLine("Loading warmup...");
        }
        public abstract void LoadProgression();
        public virtual void LoadRestTimer() 
        {
            Console.WriteLine("Loading rest timer of 2 minutes...");
        }
    }
}
