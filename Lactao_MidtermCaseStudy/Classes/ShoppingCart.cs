using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.CodeDom;

namespace Lactao_MidtermCaseStudy.Classes
{
    public class ShoppingCart
    {
        private static ShoppingCart? _shoppingCart;
        private decimal total;
        public BindingList<Order> Orders { get; set; }

        private ShoppingCart()
        {
            Orders = new BindingList<Order>();
        }

        public static ShoppingCart getInstance()
        {
            if (_shoppingCart == null) { _shoppingCart = new ShoppingCart(); }

            return _shoppingCart;
        }

        public void AddtoCart(Product prod, int qty)
        {
            Order? check = Orders.SingleOrDefault(p => p.Name == prod.Name);
            decimal amount;
           
            if (check == null)
            {
                amount = prod.Price * qty;
                Orders.Add(new Order()
                {
                    OrderId = Orders.Count,
                    Name = prod.Name,
                    Quantity = qty,
                    Unit = prod.Unit,
                    Amount = amount
                });

            }
            else
            {
                int checkId = Orders.IndexOf(check);
                int newQty = check.Quantity + qty;
                amount = newQty * prod.Price;
                DeleteItem(checkId);

                Orders.Insert(checkId, new Order()
                {
                    OrderId = Orders.Count,
                    Name = prod.Name,
                    Quantity = newQty,
                    Unit = prod.Unit,
                    Amount = amount
                });

            }

            total += amount;

        }

        public void DeleteItem(int index)
        {
            total -= Orders[index].Amount;
            Orders.RemoveAt(index);
        }

        public decimal GetTotal()
        {
            return total;
        }


    }
}
