using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Entities.Burgers
{
    internal class Cheeseburger : Burger
    {
        public Cheeseburger()
        {
            this.Description = "Cheeseburger"; 
        }

        public override decimal Calories()
        {
            return 500;
        }
    }
}
