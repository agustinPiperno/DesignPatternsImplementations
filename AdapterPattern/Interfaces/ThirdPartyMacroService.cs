using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Interfaces
{
    internal interface ThirdPartyMacroService
    {
        decimal GetCalories();
        decimal GetCarbs();
        decimal GetProtein();
        decimal GetFat();

    }
}
