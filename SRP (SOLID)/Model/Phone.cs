using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP__SOLID_.Model
{
    internal class Phone
    {
        public string Model { get; set; }
        public int Price { get; set; }

        public Phone(string model, int price)
        {
            Model = model; Price = price;
        }
    }
}
