using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Entities
{
    internal abstract class Workout
    {
        public enum ExerciseType
        {
            BenchPress,
            Squat,
            Deadlift
        };
        public Workout() { }
        public void PerformWorkout(ExerciseType exerciseType)
        {
            Exercise? exercise = CreateExercise(exerciseType);
            exercise?.PerformExercise();
        }
        public abstract Exercise? CreateExercise(ExerciseType exerciseType);
    }
}
