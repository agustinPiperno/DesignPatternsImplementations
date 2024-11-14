using AdapterPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Entities
{
    internal class MainApp : MacroService
    {
        public MainApp() { }
        public decimal Calories { get; set; }
        public decimal Carbs { get; set; }
        public decimal Protein { get; set; }
        public decimal Fat { get; set; }

    }
}
