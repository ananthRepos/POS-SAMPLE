using System;
using System.Collections.Generic;

namespace Restaurant
{
    public class Order
    {
        public List<MenuItem> currentItems { get; set; }
        public Order()
        {
            currentItems = new List<MenuItem>();
        }

        public void ExecuteCommand(OrderCommand command, MenuItem item)
        {
            command.Execute(this.currentItems, item);
        }

        
        public void ShowCurrentItems()
        {
            foreach (var item in currentItems)
            {
                item.Display();
            }
            Console.WriteLine("-----------------------");
        }
    }

}