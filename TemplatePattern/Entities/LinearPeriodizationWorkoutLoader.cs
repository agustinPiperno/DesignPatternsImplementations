using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern.Entities
{
    internal class LinearPeriodizationWorkoutLoader : WorkoutLoader
    {
        public LinearPeriodizationWorkoutLoader() { }
        public override void LoadProgression()
        {
            Console.WriteLine("Loading linear periodization workout...");
        }
        public override void LoadRestTimer()
        {
            Console.WriteLine("Loading rest timer of 3 minutes...");
        }
    }
}
