using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace testOOP
{
    class basePage
    {
        /*
        •	Create a base class Page that represents a generic web e-commerce page 
        •	Add a method for the menu (only the method) 
        */
        //Method for the Menu
        public void Menu()
        {
            Console.WriteLine("Menu: Categories / Offers / ? Help ");
        }

        /* 
        •	Create a base class Page that represents a generic web e-commerce page 
        •	Add a method for the menu (only the method) 
         */

        /*
        •	Implement a method LoadPage() in the base class Page and override it in the
        derived classes to load the specific page. 
         */

        public virtual void LoadPage() {
            Console.WriteLine("Loading");
        }
        /*
        //Properties
        public string ItemName { get; set; }
        public string ItemCategory { get; set; }
        public int ItemPrice { get; set; }

        //Constructor
        public basePage(string itemName, string itemCategory, int itemPrice)
        {
            ItemName = itemName;
            ItemCategory = itemCategory;
            ItemPrice = itemPrice;
        }
         */
        
        // **************** Logger

        
       
    }
    
    

    
}
