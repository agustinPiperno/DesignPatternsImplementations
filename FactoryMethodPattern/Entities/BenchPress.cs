using FactoryMethodPattern.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Entities
{
    internal class BenchPress : Exercise
    {
        public BenchPress()
        {
            ExerciseType = "Bench Press";
        }
        public override void PerformExercise()
        {
            Console.WriteLine("Performed " + ExerciseType);
        }

    }
}
