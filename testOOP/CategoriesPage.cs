using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testOOP
{
    /* 
     1.	In the CategoriesPage add a function to find a category by name 
    getCategory(string category)
    */
    internal class CategoriesPage : basePage 
    {   //Encapsulation, private y public properties
        private string[] categories = { "Men", "Women", "Babies" };


        public string getCategory(string category) 
        {
            for (int i = 0; i < categories.Length; i++)
            {
                if (categories[i] == category)
                {
                    return category;
                }
            }
            return null;
        }
        public override void LoadPage()
        {
            Console.WriteLine("Loading Categories");
        }

        public static void TestCategoriesLoad()
        {
            Console.WriteLine("Test: CategoriesPage Load");
            CategoriesPage catPage = new CategoriesPage();
            catPage.LoadPage(); // asegurarse que imprima "Loading Home Page"
        }
    }
}
