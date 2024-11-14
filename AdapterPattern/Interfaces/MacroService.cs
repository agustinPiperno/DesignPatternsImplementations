using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Interfaces
{
    internal interface MacroService
    {
        decimal Calories { get; set; }
        decimal Carbs { get; set; }
        decimal Protein { get; set; }
        decimal Fat { get; set; }

    }
}
