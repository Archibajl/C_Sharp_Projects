using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw5_Pt2_Archibald
{
    public class Item
    {
        public string ItemName { get; set; }
        public int NumberOfSales { get; set; }
        public float ItemPrice { get; set; }

        public Item(string name, int sales, float price)
        {
            ItemName = name;
            NumberOfSales = sales;
            ItemPrice = price;
        }
    }
}
