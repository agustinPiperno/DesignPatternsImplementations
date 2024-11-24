using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacadePattern.Interfaces;

namespace FacadePattern.Entities
{
    internal class MacroTrackerFacade : IMacroTrackerFacade
    {
        private decimal _carbs;
        private decimal _protein;
        private decimal _fat;
        public MacroTrackerFacade() { }
        public void TrackMacros(FoodItem item)
        {
            _carbs += item.Carbs;
            _protein += item.Protein;
            _fat += item.Fat;
        }
        public void DisplayTotals()
        {
            Console.WriteLine("Carbs: " + _carbs);
            Console.WriteLine("Protein: " + _protein);
            Console.WriteLine("Fat: " + _fat);
        }
    }
}
