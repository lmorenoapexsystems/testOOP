using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testOOP
{
    internal class CartPage : basePage
    {
        private CartItem[] cartItems;

        public CartPage()
        {
            cartItems = new CartItem[1];
        }

        public void addToCart(CartItem item, int index)//index empieza de 0
        {
            if (index >= 0 && index < cartItems.Length)
            {
                cartItems[index] = item;
            }
        }

        /* 
         5.	In the cart Page add a function to access the CartItem by Index
        getCartItemByIndex(int index) 
         */
        public CartItem getCartItemByIndex(int index)
        {
            if (index >= 0 && index < cartItems.Length)
            {
                return cartItems[index];
            }
            return null;
        }

        public override void LoadPage()
        {
            Console.WriteLine("Loading Categories");
        }

        public static void TestCartPageLoad()
        {
            Console.WriteLine("Test: cartPage Load");
            CartPage cartPage = new CartPage();
            cartPage.LoadPage(); // asegurarse que imprima "Loading Home Page"
        }
    }
}
