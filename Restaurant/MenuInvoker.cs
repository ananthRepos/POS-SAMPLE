using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class MenuInvoker
    {
        private OrderCommand _orderCommand;
        private MenuItem _menuItem;
        private Order _order;

        public MenuInvoker()
        {
            _order = new Order();
        }

        public void SetCommand(int commandOption)
        {
            _orderCommand = new CommandFactory().GetCommand(commandOption);
        }

        public void SetMenuItem(MenuItem item)
        {
            _menuItem = item;
        }

        public MenuItem GetItem(int itemID)
        {
             return _order.currentItems.Find(m=>m.ItemID == itemID);

        }

        public void ExecuteCommand()
        {
            _order.ExecuteCommand(_orderCommand, _menuItem);
        }

        public void ShowCurrentOrder()
        {
            _order.ShowCurrentItems();
        }
    }

    public class CommandFactory
    {
        //Factory method
        public OrderCommand GetCommand(int commandOption)
        {
            switch (commandOption)
            {
                case 1:
                    return new AddCommand();
                case 2:
                   // return Modify item price etc
                case 3:
                // return Remove item from check etc
                default:
                    return new AddCommand();
            }
        }
    }
}
