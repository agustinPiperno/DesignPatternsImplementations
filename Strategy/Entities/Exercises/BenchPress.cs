using StrategyPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Entities
{
    internal class BenchPress : Exercise
    {
        public decimal Weight { get; set; }
        public uint Reps { get; set; }
        public uint Sets { get; set; }
        public ProgressionStrategy progressionStrategy { get; set; }

        public BenchPress(ProgressionStrategy progressionStrategy)
        {
            this.progressionStrategy = progressionStrategy;
        }

        public void performExercise()
        {
            Console.WriteLine("Performed Bench Press: " + this.Sets + 'x' + this.Reps + ' ' + this.Weight + " kg");
            this.addProgress();

        }

        public void addProgress()
        {
            this.Weight = this.progressionStrategy.setWeight(this.Weight);
            this.Reps = this.progressionStrategy.setReps(this.Reps);
        }
    }
}
