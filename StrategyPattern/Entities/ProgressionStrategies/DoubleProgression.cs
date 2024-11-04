using StrategyPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Entities
{
    internal class DoubleProgression : ProgressionStrategy
    {
        public DoubleProgression() { }

        public decimal setWeight(decimal weight)
        {
            return weight;
        }

        public uint setReps(uint reps)
        {
            return reps;
        }
    }
}
