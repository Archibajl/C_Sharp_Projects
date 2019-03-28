using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    class Drink : VendingMachineOption
    { 
        public int SizeInOunces { get;  set; }        
        public int CalorieCount { get;  set; }
        public bool IsVegetarian { get;  set; }

        public Drink(string name, float price, int quantity, int calorieCount, int sizeInOunces, bool isVegetarian) : base(name, price, quantity)
    {            
            this.SizeInOunces = sizeInOunces;
            this.CalorieCount = calorieCount;
            this.IsVegetarian = isVegetarian;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
