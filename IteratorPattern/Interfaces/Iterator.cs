using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Interfaces
{
    internal interface Iterator
    {
        bool HasNext();
        Object Next();
        void Remove();
    }
}
