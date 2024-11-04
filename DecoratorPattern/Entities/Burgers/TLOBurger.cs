using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Entities.Burgers
{
    internal class TLOBurger : Burger
    {
        public TLOBurger()
        {
            this.Description = "TLO Burger";
        }
        public override decimal Calories()
        {
            return 300;
        }
    }
}
