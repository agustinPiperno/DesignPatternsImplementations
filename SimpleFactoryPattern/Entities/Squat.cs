using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern.Entities
{
    internal class Squat : Exercise
    {
        public Squat() { }
        public override void PerformExercise()
        {
            Console.WriteLine("Performed Squat");
        }
    }
}
