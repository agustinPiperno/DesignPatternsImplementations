using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Entities
{
    internal class BenchPress : Exercise
    {
        public BenchPress() 
        {
            this.ExerciseType = "Bench Press";
        }
        public override void PerformExercise()
        {
            Console.WriteLine("Performed " + this.ExerciseType);
        }

    }
}
