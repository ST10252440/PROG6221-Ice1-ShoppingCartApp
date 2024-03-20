using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ShoppingCartApp
{
    internal class ElectronicsProduct : Product
    {
        private string brand { get; }
        private string model { get; }
        public ElectronicsProduct(string name, double price, ProductCategory category, string brand, string model) : base(name, price, category)
        {
            this.brand = brand;
            this.model = model;
        }

        public override void get_info()
        {
            var info = new StringBuilder();
            info.Append($"Product Name: {get_name()} \n");
            info.Append($"Product Price: R{get_price()} \n");
            info.Append($"Product Category: {get_category()} \n");
            info.Append($"Product Brand: {brand} \n");
            info.Append($"Product Model: {model} \n");
            Console.WriteLine(info.ToString());
        }
    }
}
