using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Entities
{
    internal class LowerBodyWorkout : Workout
    {
        public LowerBodyWorkout() { }
        public override Exercise? CreateExercise(ExerciseType exerciseType)
        {
            if(exerciseType == ExerciseType.Squat)
            {
                return new Squat();
            }
            else if (exerciseType == ExerciseType.Deadlift)
            {
                return new Deadlift();
            }
            else
            {
                return null;
            }
        }
    }
}
