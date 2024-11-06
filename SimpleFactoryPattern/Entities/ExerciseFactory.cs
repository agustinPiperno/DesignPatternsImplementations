using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern.Entities
{
    internal class ExerciseFactory
    {
        public enum ExerciseType 
        { 
            BenchPress, 
            Squat, 
            Deadlift 
        };

        public ExerciseFactory() { }
        public Exercise CreateExercise(ExerciseType exerciseType)
        {
            Exercise? exercise = null;

            if (exerciseType == ExerciseFactory.ExerciseType.BenchPress)
            {
                exercise = new BenchPress();
            }
            else if (exerciseType == ExerciseFactory.ExerciseType.Squat)
            {
                exercise = new Squat();
            }
            else if (exerciseType == ExerciseFactory.ExerciseType.Deadlift)
            {
                exercise = new Deadlift();
            }
            return exercise;
        }
        
    }
}
