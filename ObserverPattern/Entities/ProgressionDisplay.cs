using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPattern.Interfaces;

namespace ObserverPattern.Entities
{
    internal class ProgressionDisplay : Display, Observer
    {
        public decimal Weight { get; set; }
        public uint Reps { get; set; }
        private Subject exerciseData;

        public ProgressionDisplay(Subject exerciseData)
        {
            this.exerciseData = exerciseData;
            this.exerciseData.registerObserver(this);
        }
        public void update(decimal weight, uint reps)
        {
            this.Weight = weight;
            this.Reps = reps;
            this.display();
        } 
        public void display()
        {
            Console.WriteLine("Progression Display: " + this.Weight + " kg for " + this.Reps + " reps");
        }
    }
}
