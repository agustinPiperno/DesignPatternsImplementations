using Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Entities.Exercises
{
    internal class BenchPress : Exercise
    {
        public decimal Weight { get; set; }
        public decimal Reps { get; set; }
        public decimal Sets { get; set; }
        public ProgressionStrategy progressionStrategy { get; set; }

        public BenchPress(ProgressionStrategy progressionStrategy)
        {
            this.progressionStrategy = progressionStrategy;
        }

        public void performExercise()
        {
            Console.WriteLine("Performed Bench Press: " + Sets + 'x' + Reps + ' ' + Weight + " kg");
            addProgress();

        }

        public void addProgress()
        {
            Weight = progressionStrategy.setWeight(Weight);
            Reps = progressionStrategy.setReps(Reps);
        }
    }
}
