using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IteratorPattern.Interfaces;

namespace IteratorPattern.Entities
{
    internal class UpperBodySplitIterator : Iterator
    {
        private Exercise[] _exercises;
        private int _currentPosition = 0;

        public UpperBodySplitIterator(Exercise[] exercises)
        {
            _exercises = exercises;
        }
        public bool HasNext()
        {
            return _currentPosition < _exercises.Length - 1;
        }
        public Object Next()
        {
            if (!HasNext())
            {
                return null;
            }
            Exercise exercise = _exercises[_currentPosition];
            _currentPosition++;
            return exercise;
        }
        public void Remove()
        {
            _exercises[_currentPosition] = null;
        }
    }
}
