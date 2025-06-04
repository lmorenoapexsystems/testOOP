using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testOOP
{
    /* 
     2.	Add a new class "Item" that contains the main elements for the Item in the cart:
    image, name, price. 
    3.	Add a new class “CartItem” that inherits from “Item” and add the attribute for the quantity
     */
    public class Item
    {
        private string name;
        private string image;
        private int price;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Image
        {
            get { return image; }
            set { image = value; }
        }

        public int Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
