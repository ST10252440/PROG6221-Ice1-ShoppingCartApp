namespace ShoppingCartApp;

enum ProductCategory { Clothing, Electronics, Home, Beauty, Groceries};

internal class Program
{
    static ShoppingCart cart;

    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, welcome to the shopping cart app.");
        Console.WriteLine("How big would you like your shopping cart" +
            " to be?");
        bool validation = false;
        int numInput = 0;
        while (!validation) {
            try
            {
                string input = Console.ReadLine();
                numInput = Int32.Parse(input);

                if (numInput > 5000 || numInput < 1)
                {
                    throw new Exception("e");
                }

                
                validation = true;
                Console.WriteLine("Thank you.\n");
            }
            catch
            {
                validation = false;
                Console.WriteLine("Error, incorrect input.\n");
            }
        }

        cart = new ShoppingCart(numInput);
        validation = false;
        while (!validation) 
        {
            Console.WriteLine("What would you like to do?\n" +
                " A - Add Item. \n" +
                " R - Remove Item \n" +
                " D - Displays Items \n" +
                " E - Exits Program.\n");
            string input = Console.ReadLine();
            switch (input) {
                case "A":
                    Console.WriteLine("\n");
                    if (cart.get_item_count() >= numInput)
                    {
                        Console.WriteLine("Cart full.\n");
                    }
                    else
                    {
                        bool categoryBoolean = false;
                        ProductCategory category = ProductCategory.Clothing;
                        while (!categoryBoolean)
                        {
                            Console.WriteLine("What type of product? \n " +
                                "A - Clothing \n " +
                                "B - Electronics \n " +
                                "C - Home \n " +
                                "D - Beauty \n " +
                                "E - Groceries \n");
                            string choice = Console.ReadLine();
                            switch (choice)
                            {
                                case "A":
                                    categoryBoolean = true;
                                    category = ProductCategory.Clothing;
                                    break;
                                case "B":
                                    categoryBoolean = true;
                                    category = ProductCategory.Electronics;
                                    break;
                                case "C":
                                    categoryBoolean = true;
                                    category = ProductCategory.Home;
                                    break;
                                case "D":
                                    categoryBoolean = true;
                                    category = ProductCategory.Beauty;
                                    break;
                                case "E":
                                    categoryBoolean = true;
                                    category = ProductCategory.Groceries;
                                    break;
                                default:
                                    Console.WriteLine("Invalid category");
                                    break;
                            }
                        }
                        Console.WriteLine("What is the item called?");
                        string name = Console.ReadLine();
                        Console.WriteLine("What is product's price?");
                        double price = 0.0;
                        bool valid = false;
                        while (!valid)
                        {
                            try
                            {
                                price = Double.Parse(Console.ReadLine());
                                valid = true;
                            }
                            catch
                            {
                                valid = false;
                                Console.WriteLine("Invalid input.\n");
                            }
                        }

                        if (category == ProductCategory.Clothing)
                        {
                            Console.WriteLine("Please enter the item's size.");
                            string size = Console.ReadLine();
                            Console.WriteLine("Please enter the colour of the item.");
                            string color = Console.ReadLine();
                            ClothingProduct newProduct = new ClothingProduct(name, price, category, size, color);
                            cart.add_product(newProduct);
                        }
                        else if (category == ProductCategory.Electronics)
                        {
                            Console.WriteLine("Please enter the item's brand.");
                            string brand = Console.ReadLine();
                            Console.WriteLine("Please enter the item's model name.");
                            string model = Console.ReadLine();
                            ElectronicsProduct newProduct = new ElectronicsProduct(name, price, category, brand, model);
                            cart.add_product(newProduct);
                        }
                        else
                        {
                            Product newProduct = new Product(name, price, category);
                            cart.add_product(newProduct);
                        }
                        Console.WriteLine("Item successfully added to cart.\n");
                    }
                    break;
                case "R":
                    Console.WriteLine("\n");  
                    if (cart.get_item_count() > 0)
                    {

                        Console.WriteLine("Please enter the name of the item:\n");
                        String item = Console.ReadLine();
                        bool objFound = false;

                        foreach (Product deleteItem in cart.get_products())
                        {
                            if (deleteItem != null && deleteItem.get_name() == item)
                            {
                                cart.remove_product(deleteItem);
                                Console.WriteLine("Item Successfully Deleted\n");
                                objFound = true;
                            }
                        }
                        if (!objFound) 
                        { 
                            Console.WriteLine("Sorry, no item was found.\n");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Sorry, no items in cart. \n");
                    }
                    break;
                case "D":
                    Console.WriteLine("\n");
                    if (cart.get_item_count() > 0)
                    {
                        cart.display_product_summary();
                    }
                    else
                    {
                        Console.WriteLine("Sorry, no items in cart. \n");
                    }
                    break;
                case "E":
                    validation = true; 
                    break;
            }
        }
    }

}