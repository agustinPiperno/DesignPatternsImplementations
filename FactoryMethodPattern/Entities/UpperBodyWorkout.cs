using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Entities
{
    internal class UpperBodyWorkout : Workout
    {
        public UpperBodyWorkout() { }
        public override Exercise? CreateExercise(ExerciseType exerciseType)
        {
            if (exerciseType == ExerciseType.BenchPress)
            {
                return new BenchPress();
            }
            else
            {
                return null;
            }
        }
    }
}
