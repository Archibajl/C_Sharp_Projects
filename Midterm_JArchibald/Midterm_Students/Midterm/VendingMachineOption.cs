using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    abstract class VendingMachineOption : VendingMachine
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }      

        //Adjusts all constructors to use the parent abstract classes general values
        public VendingMachineOption(string name, float price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
