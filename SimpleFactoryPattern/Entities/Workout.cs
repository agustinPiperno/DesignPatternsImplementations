using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern.Entities
{
    internal class Workout
    {
        private ExerciseFactory _exerciseFactory;
        public Workout(ExerciseFactory exerciseFactory)
        {
            _exerciseFactory = exerciseFactory;
        }
        public void PerformWorkout(ExerciseFactory.ExerciseType exerciseType) 
        {
            Exercise exercise = _exerciseFactory.CreateExercise(exerciseType);
            exercise.PerformExercise();
        }
    }
}
