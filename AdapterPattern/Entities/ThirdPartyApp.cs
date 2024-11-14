using AdapterPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Entities
{
    internal class ThirdPartyApp : ThirdPartyMacroService
    {
        public ThirdPartyApp() { }
        public decimal GetCalories()
        {
            Console.WriteLine("Getting calories from third party app");
            return 100;
        }
        public decimal GetCarbs()
        {
            Console.WriteLine("Getting carbs from third party app");
            return 4;
        }
        public decimal GetProtein()
        {
            Console.WriteLine("Getting protein from third party app");
            return 4; 
        }
        public decimal GetFat()
        {
            Console.WriteLine("Getting fat from third party app");
            return 9; 
        }
    }
}
