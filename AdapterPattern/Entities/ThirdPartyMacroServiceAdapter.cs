using AdapterPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Entities
{
    internal class ThirdPartyMacroServiceAdapter : MacroService
    {
        private readonly ThirdPartyMacroService _thirdPartyMacroService;
        public decimal Calories
        {
            get
            {
                return _thirdPartyMacroService.GetCalories();
            }
            set
            {

            }
        }
        public decimal Carbs
        {
            get
            {
                return _thirdPartyMacroService.GetCarbs();
            }
            set
            {

            }
        }
        public decimal Protein
        {
            get
            {
                return _thirdPartyMacroService.GetProtein();
            }
            set
            {

            }
        }
        public decimal Fat
        {
            get
            {
                return _thirdPartyMacroService.GetFat();
            }
            set
            {

            }
        }

        public ThirdPartyMacroServiceAdapter(ThirdPartyMacroService thirdPartyMacroService)
        {
            this._thirdPartyMacroService = thirdPartyMacroService;
        }

    }
}
