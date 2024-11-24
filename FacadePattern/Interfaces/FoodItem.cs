using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Interfaces
{
    internal interface FoodItem
    {
        decimal Carbs { get; set; }
        decimal Protein { get; set; }
        decimal Fat { get; set; }
    }
}
