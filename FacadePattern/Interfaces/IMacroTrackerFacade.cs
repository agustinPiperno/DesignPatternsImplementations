using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Interfaces
{
    internal interface IMacroTrackerFacade
    {
        void TrackMacros(FoodItem item);
        void DisplayTotals();
    }
}
