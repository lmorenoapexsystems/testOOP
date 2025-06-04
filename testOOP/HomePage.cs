using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace testOOP
{
    class HomePage : basePage //Herencia
    {
        private Item[] items;
        public HomePage()
        {
            //Articulos de ejemplo
            items = new Item[3];
            items[0] = new Item { Name = "SportShirt", Image = "shirt.jpg", Price = 30 };
            items[1] = new Item { Name = "Jeans", Image = "jeans.jpg", Price = 40 };
            items[2] = new Item { Name = "Cap", Image = "cap.jpg", Price = 15 };
        }
        /* 
         4.	In the homepage add function to find an item by name in
        getItemByName(string itemName) the item in the homepage is an array of the Item class
         */
        public Item getItemByName(string itemName)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i].Name.Equals(itemName)) {
                    return items[i];
                }
            }
            return null;
        }

        public override void LoadPage() //Polimorfismo, public virtual pasa a public override
        {
            Console.WriteLine("Loading Home Page");
        }
        /* 
         •	Add 3 test cases one for each page (HomePage, CategoriesPage, CartPage) 
            that only calls the LoadPage method
         */
        public static void TestHomePageLoad()
        {
            Console.WriteLine("Test: Homepage Load");
            HomePage homePage = new HomePage();
            homePage.LoadPage(); // asegurarse que imprima "Loading Home Page"
        }
    }
}
