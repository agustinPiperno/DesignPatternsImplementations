using FacadePattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Entities
{
    internal class Burger : FoodItem
    {
        public decimal Carbs
        { get
            {
                return 20;
            }
            set
            {
            }
        }
        public decimal Protein
        { 
            get 
            {
                return 50;
            } 
            set
            { 
            } 
        }
        public decimal Fat 
        {
            get
            {
                return 50;
            }
            set 
            { 
            }
        }
        public Burger() { }
    }
}
