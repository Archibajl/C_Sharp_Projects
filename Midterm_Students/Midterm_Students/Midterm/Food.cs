using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    class Food : VendingMachineOption
    {
        public int CalorieCount { get; set; }
        public float Consistency { get;  set; }
        public bool IsVegetarian { get;  set; }
        public int ScovilleScale { get; set; }

        public Food(string name, float price, int quantity, int calorieCount, float consistency, int scovilleScale, bool isVegetarian): base(name, price, quantity)
        {            
            this.Consistency = consistency;
            this.ScovilleScale = scovilleScale;
            this.CalorieCount = calorieCount;
            this.IsVegetarian = isVegetarian;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
