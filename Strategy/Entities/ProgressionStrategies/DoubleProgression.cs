using Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Entities.ProgressionStrategies
{
    internal class DoubleProgression : ProgressionStrategy
    {
        public DoubleProgression() { }

        public decimal setWeight(decimal weight)
        {
            return weight;
        }

        public decimal setReps(decimal reps)
        {
            return reps;
        }
    }
}
