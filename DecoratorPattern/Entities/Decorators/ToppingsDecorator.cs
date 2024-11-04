using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Entities.Decorators
{
    internal abstract class ToppingsDecorator : Burgers.Burger
    {
        public override abstract string Description { get; set; }

    }
}
