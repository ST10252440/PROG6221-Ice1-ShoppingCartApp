using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp
{
    internal class Product
    {
        private string name;
        private double price;
        private ProductCategory category;

        public Product(string name, double price, ProductCategory category)
        {
            this.name = name;
            this.price = price;
            this.category = category;

        }

        public virtual void get_info()
        {
            var info = new StringBuilder();
            info.Append($"Product Name: {name} \n");
            info.Append($"Product Price: R{price} \n");
            info.Append($"Product Category: {category} \n");
            Console.WriteLine(info.ToString());
        }

        public string get_name()
        {
            return name;
        }

        public double get_price()
        {
            return price;
        }

        public ProductCategory get_category()
        {
            return category;
        }

    }
}
