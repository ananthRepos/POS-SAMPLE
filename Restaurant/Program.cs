using System;
using System.Collections.Generic;
using System.Linq;

namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {

            MenuInvoker menuInvoker = new MenuInvoker();
            /*1-Adding all the menu items to pick*/
            menuInvoker.SetCommand(1);
            menuInvoker.SetMenuItem(new MenuItem(1, "Cheeseburger", 10.99, Category.Sandwich));
            menuInvoker.ExecuteCommand();

            menuInvoker.SetCommand(1);
            menuInvoker.SetMenuItem(new MenuItem(2, "Veggie Burger", 8.99, Category.Sandwich));
            menuInvoker.ExecuteCommand();

            menuInvoker.SetCommand(1);
            menuInvoker.SetMenuItem(new MenuItem(3, "Bottle Water", 1.99, Category.Drink));
            menuInvoker.ExecuteCommand();

            menuInvoker.SetCommand(1);
            menuInvoker.SetMenuItem(new MenuItem(4, "Cookie", 2.49, Category.Dessert));
            menuInvoker.ExecuteCommand();
            menuInvoker.ShowCurrentOrder();

            Check check = new Check();

            while (true) // Loop indefinitely
            {
                Console.WriteLine("Please enter 1 or 2 or 3 or 4 or (10 for Total)");
                string line = Console.ReadLine(); // Get string from Console
                if (line == "10") // Check string
                {
                    break;
                }
                else
                {
                    //Adding items to Check
                    check.AddItems(menuInvoker.GetItem(int.Parse(line)));
                }
            }
            //Adding discount to selected category
            check.AddOneDiscount(check.GetSelectedItems().FirstOrDefault().Category);
            //Calling Subtotal method
            Console.WriteLine("Check Total is: " + check.Calculate(check));
            Console.Read();
        }
    }
}
