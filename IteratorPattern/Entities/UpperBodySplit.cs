using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using IteratorPattern.Interfaces;

namespace IteratorPattern.Entities
{
    internal class UpperBodySplit : Split
    {
        public static readonly int MAX_EXERCISES = 5;
        public int numberOfExercises = 0;
        public Exercise[] Exercises;

        public UpperBodySplit()
        {
            Exercises = new Exercise[MAX_EXERCISES];
            AddExercise("Bench Press");
            AddExercise("Lateral raises");
            AddExercise("Bicep Curls");
            AddExercise("Tricep Extensions");
        }
        public void AddExercise(string name)
        {
            if (numberOfExercises >= MAX_EXERCISES)
            {
                Console.WriteLine("Can't add more exercises to the split");
                return;
            }
            Exercise exercise = new Exercise(name);
            Exercises[numberOfExercises] = exercise;
            numberOfExercises++;
        }
        public Iterator CreateIterator() 
        {
            return new UpperBodySplitIterator(Exercises);
        }
    }
}
