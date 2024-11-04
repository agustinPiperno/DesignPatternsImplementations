using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Interfaces
{
    internal interface ProgressionStrategy
    {
        public decimal setWeight(decimal weight);
        public uint setReps(uint reps);
    }
}
