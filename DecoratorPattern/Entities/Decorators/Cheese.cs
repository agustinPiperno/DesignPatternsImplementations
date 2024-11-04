using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Entities.Burgers;

namespace DecoratorPattern.Entities.Decorators
{
    internal class Cheese : ToppingsDecorator
    {
        private Burger burger;
        public Cheese(Burger burger)
        {
            this.burger = burger;
        }

        public override string Description
        {
            get
            {
                return this.burger.Description + ", Cheese";
            }
            set
            {

            }
        }
        public override decimal Calories()
        {
            return this.burger.Calories() + 100;
        }
    }
}
