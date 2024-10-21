using Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Entities
{
    internal class Workout
    {
        private List<Exercise> exercises = new List<Exercise>();

        public void AddExercise(Exercise exercise)
        {
            this.exercises.Add(exercise);
        }
        public void PerformWorkout()
        {
            foreach(Exercise exercise in exercises)
            {
                exercise.performExercise();
            }
        }
    }
}
