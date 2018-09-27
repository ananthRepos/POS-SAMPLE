using System;
using System.Collections.Generic;
using System.Linq;

namespace Restaurant
{
    public class Check
    {
        private List<MenuItem> listMenuItem;

        private Discount discount;

        public Check()
        {
            listMenuItem = new List<Restaurant.MenuItem>();            
        }

        public List<MenuItem> GetSelectedItems()
        {
            return listMenuItem;
        }
        public void AddItems(MenuItem item)
        {
            listMenuItem.Add(item);
        }
        public void AddOneDiscount(Category category)
        {
            //get discoutns

            Discount dis = new Restaurant.Discount();
            discount= dis.GetAvailableDiscounts().FirstOrDefault(m=>m.Category == category);
        }
        public double Calculate(Check chk)
        {

            double subtotal = 0;
            foreach (var menuitem in listMenuItem)
            {
                if(menuitem.Category == chk.discount.Category)
                {
                    menuitem.Price = menuitem.Price - (menuitem.Price * Convert.ToDouble(chk.discount.Percentage)) / 100;
                }

                subtotal = subtotal + menuitem.Price;
            }

            return subtotal;
        }
    }
}
