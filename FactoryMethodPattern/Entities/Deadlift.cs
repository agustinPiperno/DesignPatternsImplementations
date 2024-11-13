using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Entities
{
    internal class Deadlift : Exercise
    {
        public Deadlift()
        {
            this.ExerciseType = "Deadlift";
        }
        public override void PerformExercise()
        {
            Console.WriteLine("Performed " + this.ExerciseType);
        }
    }
}
