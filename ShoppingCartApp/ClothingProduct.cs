using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ShoppingCartApp
{
    internal class ClothingProduct : Product
    {
        private string size { get; }
        private string color { get; }
        public ClothingProduct(string name, double price, ProductCategory category, string size, string color) : base(name, price, category)
        {
            this.size = size;
            this.color = color;
        }

        public override void get_info()
        {
            var info = new StringBuilder();
            info.Append($"Product Name: {get_name()} \n");
            info.Append($"Product Price: R{get_price()} \n");
            info.Append($"Product Category: {get_category()} \n");
            info.Append($"Product Size: {size} \n");
            info.Append($"Product Color: {color} \n");
            Console.WriteLine(info.ToString());
        }
    }
}
