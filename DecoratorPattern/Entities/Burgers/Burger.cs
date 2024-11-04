using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Entities.Burgers
{
    internal abstract class Burger
    {
        public virtual string Description { get; set; } = "Unknown Burger";

        public abstract decimal Calories();

    }
}
