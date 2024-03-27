using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework03
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public double Total { get; set; }

        public Product(string name)
        {
            Name = name;
        }
        public void Sell()
        {
            if (Count == 0)
            {
                Console.WriteLine("Mehsuldan elde yoxdur.");
            }
            else
            {
                Console.WriteLine($"{Name} Satildi");
                Count = Count - 1;
                Total = Total + 1;

            }
        }
    }
}
