using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lactao_MidtermCaseStudy.Classes
{
    public class ShoppingCart
    {
        private static ShoppingCart? _shoppingCart;

        private ShoppingCart()
        {

        }

        public static ShoppingCart getInstance()
        {
            if (_shoppingCart == null) { _shoppingCart = new ShoppingCart(); }

            return _shoppingCart;
        }

    }
}
