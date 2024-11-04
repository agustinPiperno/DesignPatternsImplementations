using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPattern.Interfaces;

namespace ObserverPattern.Entities
{
    internal class ExerciseData : Subject
    {
        private List<Observer> observers;
        public decimal Weight { get; set; }
        public uint Reps { get; set; }

        public ExerciseData()
        {
            this.observers = new List<Observer>();
        }
        public void registerObserver(Observer observer)
        {
            this.observers.Add(observer);
        }
        public void removeObserver(Observer observer)
        {
            this.observers.Remove(observer);
        }
        public void notifyObservers()
        {
            foreach (Observer observer in this.observers)
            {
                observer.update(this.getWeight(), this.getReps());
            }
        }
        public void measurementsChanged()
        {
            notifyObservers();
        }
        public void setMeasurements(decimal weight, uint reps)
        {
            this.Weight = weight;
            this.Reps = reps;
            this.measurementsChanged();
        }
        public decimal getWeight()
        {
            return this.Weight;
        }
        public uint getReps()
        {
            return this.Reps;
        }
    }
}
