using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Entities
{
    internal class Estimated1RMDisplay : Display, Observer
    {
        public decimal Weight { get; set; }
        public uint Reps { get; set; }
        private Subject exerciseData;

        public Estimated1RMDisplay(Subject exerciseData)
        {
            this.exerciseData = exerciseData;
            exerciseData.registerObserver(this);
        }
        public void update(decimal weight, uint reps)
        {
            this.Weight = weight;
            this.Reps = reps;
            this.display();
        }
        public void display()
        {
            Console.WriteLine("Estimated 1RM Display: " + (this.Weight * (1 + (decimal)this.Reps / 30)).ToString("0.00") + " kg");
        }
    }
}
