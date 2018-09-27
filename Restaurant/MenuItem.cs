using System;
using System.Collections.Generic;

namespace Restaurant
{
    public class MenuItem
    {
        public int ItemID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }
        public MenuItem(int itemID, string name, double price, Category category)
        {
            ItemID = itemID;
            Name = name;
            Price = price;
            Category = category;
        }
        public void Display()
        {
            Console.WriteLine("\nName: " + Name);
            Console.WriteLine("Price: $" + Price.ToString());
            Console.WriteLine("Category: " + Category.ToString());
        }
        //public List<MenuItem> GetMenuItems()
        //{
        //    List<MenuItem> items = new List<Restaurant.MenuItem>();
        //    items.Add(new Restaurant.MenuItem()
        //    {
        //        Name = "Cheeseburger",
        //        Price = 10.99,
        //        Category = Category.Sandwich
        //    });
        //    items.Add(new Restaurant.MenuItem()
        //    {
        //        Name = "Veggie Burger",
        //        Price = 8.99,
        //        Category = Category.Sandwich
        //    });
        //    items.Add(new Restaurant.MenuItem()
        //    {
        //        Name = "Bottle Water",
        //        Price = 1.99,
        //        Category = Category.Drink
        //    });
        //    items.Add(new Restaurant.MenuItem()
        //    {
        //        Name = "Cookie",
        //        Price = 2.49,
        //        Category = Category.Dessert
        //    });
        //    return items;
        //}

    }
    public enum Category
    {
        Sandwich,
        Drink,
        Dessert
    }
    public class Discount
    {
        public string Name { get; set; }
        public decimal Percentage { get; set; }
        public Category Category { get; set; }
        public List<Discount> GetAvailableDiscounts()
        {
            List<Discount> discounts = new List<Discount>();
            discounts.Add(new Restaurant.Discount()
            {
                Name = "10OFF",
                Percentage = 10,
                Category = Category.Sandwich
            });
            discounts.Add(new Restaurant.Discount()
            {
                Name = "50OFF",
                Percentage = 50,
                Category = Category.Drink
            });
            discounts.Add(new Restaurant.Discount()
            {
                Name = "100OFF",
                Percentage = 100,
                Category = Category.Dessert
            });
            return discounts;
        }
    }
}
