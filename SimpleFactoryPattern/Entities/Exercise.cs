using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern.Entities
{
    internal abstract class Exercise
    {
        public Exercise() { }
        public abstract void PerformExercise();
    }
}
