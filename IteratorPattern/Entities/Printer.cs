using IteratorPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Entities
{
    internal class Printer
    {
        private Split _upperBodySplit;
        private Split _lowerBodySplit;
        public Printer(Split upperBodySplit, Split lowerBodySplit) 
        {
            _upperBodySplit = upperBodySplit;
            _lowerBodySplit = lowerBodySplit;
        }
        public void PrintExercises()
        {
            Iterator upperBodyIterator = _upperBodySplit.CreateIterator();
            Iterator lowerBodyIterator = _lowerBodySplit.CreateIterator();
            Console.WriteLine("Upper Body Exercises:");
            PrintExercises(upperBodyIterator);
            Console.WriteLine("Lower Body Exercises:");
            PrintExercises(lowerBodyIterator);
        }
        public void PrintExercises(Iterator iterator)
        {
            while(iterator.HasNext())
            {
                Exercise exercise = (Exercise)iterator.Next();
                Console.WriteLine(exercise.Name);
            }
        }
    }
}
