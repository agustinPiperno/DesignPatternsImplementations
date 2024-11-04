using StrategyPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Entities
{
    internal class LinearProgression : ProgressionStrategy
    {
        public LinearProgression() { }

        public decimal setWeight(decimal weight)
        {
            return weight + 2.5m;
        }

        public uint setReps(uint reps)
        {
            return reps;
        }
    }
}
