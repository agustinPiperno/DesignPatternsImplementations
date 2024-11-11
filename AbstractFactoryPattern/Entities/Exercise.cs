using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Entities
{
    internal abstract class Exercise
    {
        public string ExerciseType { get; set; }
        public Exercise() 
        {
            this.ExerciseType = "Undefined Exercise";
        }
        public abstract void PerformExercise();
    }
}
