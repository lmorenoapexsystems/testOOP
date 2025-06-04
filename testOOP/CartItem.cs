using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testOOP
{
    public class CartItem : Item // Herencia
    {
        private int quantity; //misma estructura que Item
        public int Quantity {  
            get { return quantity; } 
            set { quantity = value; } }

    }
}
