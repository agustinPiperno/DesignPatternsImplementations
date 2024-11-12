using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIngletonPattern.Entities
{
    internal class Configuration
    {
        private static Configuration? _configurationInstance;

        private Configuration() { }
        public static Configuration getInstance()
        {
            if(_configurationInstance == null)
            {
                _configurationInstance = new Configuration();
            }
            return _configurationInstance;
        }
    }
}
