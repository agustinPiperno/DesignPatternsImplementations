using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern.Entities
{
    internal class Deadlift : Exercise
    {
        public Deadlift() { }
        public override void PerformExercise()
        {
            Console.WriteLine("Performed Deadlift");
        }
    }
}
