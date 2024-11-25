using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern.Entities
{
    internal class LinearProgressionWorkoutLoader : WorkoutLoader
    {
        public LinearProgressionWorkoutLoader() { }
        public override void LoadProgression()
        {
            Console.WriteLine("Loading linear progression workout...");
        }
        
    }
}
