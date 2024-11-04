using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Entities.Burgers;

namespace DecoratorPattern.Entities.Decorators
{
    internal class Mayo : ToppingsDecorator
    {
        private Burger burger;
        public Mayo(Burger burger)
        {
            this.burger = burger;
        }
        public override string Description
        {
            get
            {
                return this.burger.Description + ", Mayo";
            }
            set
            {

            }
        }
        public override decimal Calories()
        {
            return this.burger.Calories() + 50;
        }
    }
}
