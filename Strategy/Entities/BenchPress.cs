using Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Entities
{
    internal class BenchPress : Exercise
    {
        public ProgressionStrategy progressionStrategy { get; set; }
        public BenchPress(ProgressionStrategy progressionStrategy)
        {
            this.progressionStrategy = progressionStrategy;
        }
        public void performExercise()
        {
            Console.WriteLine("Performed Bench Press!");
        }
    }
}
