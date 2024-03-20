using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp
{
    internal class ShoppingCart
    {
        public ShoppingCart(int capacity)
        {

            itemCount = 0;
            products = new Product[capacity];
            arrayCap = capacity;
        }

        private int arrayCap;
        private Product[] products;
        private int itemCount { get; set;  }



        public Product[] get_products()
        {
            return products;
        }

        public void add_product(Product product)
        {
            try            {
                products[itemCount] = product;
                itemCount++;
                Console.WriteLine("Product added successfully. \n");
            }
            catch
            {
                Console.WriteLine("Error, could not add product. \n");
            }
        }

        public int get_item_count()
        {
            return itemCount;
        }

        public void remove_product(Product product)
        {
            try 
            {
                int p = 0;
                foreach (Product item in products)
                {
                    if (item == product)
                    {
                        
                        Product[] replaceArray = new Product[arrayCap];
                        int replaceValue = 0;
                        for (int preValue = 0; preValue <= itemCount; preValue++)
                        { 
                            if (preValue == p)
                            {
                                replaceValue+= 1;
                                itemCount--;
                            }
                            replaceArray[preValue] = (products[replaceValue]);
                            replaceValue++;
                        }
                        products = replaceArray;
                        return;
                    }
                    p++;
                }
                Console.WriteLine("Sorry, we could not find that product. \n");
            }
            catch
            {
                Console.WriteLine("Error, could not remove product. \n");
            }
        }

        public void display_product_summary()
        {
            for (int i = 0; i < itemCount; i++)
            {
                if (products[i] != null)
                {
                    products[i].get_info();
                }
            }
        }
    }
}
