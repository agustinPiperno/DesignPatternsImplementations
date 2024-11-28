using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Entities
{
    internal class Exercise
    {
        public string Name {get; set; }
        public Exercise(String name)
        {
            Name = name;
        }
    }
}
