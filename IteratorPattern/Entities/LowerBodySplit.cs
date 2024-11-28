using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IteratorPattern.Interfaces;

namespace IteratorPattern.Entities
{
    internal class LowerBodySplit : Split
    {
        private List<Exercise> _exercises;

        public LowerBodySplit()
        {
            _exercises = new List<Exercise>();
            AddExercise("Squats");
            AddExercise("Leg Press");
            AddExercise("Leg Curls");
            AddExercise("Calf Raises");
        }
        public void AddExercise(string name)
        {
            Exercise exercise = new Exercise(name);
            this._exercises.Add(exercise);
        }
        public Iterator CreateIterator() 
        {
            return new LowerBodySplitIterator(_exercises);
        }
    }
}
