using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;

namespace testOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            HomePage page = new HomePage();
            page.LoadPage(); 

            //Buscar item
            Item foundItem = page.getItemByName("Cap");

            if (foundItem != null)
            { //Si se encontró el item
                //Crear carrito
                CartPage carrito = new CartPage();
                carrito.LoadPage();

                //crear cart Item
                CartItem cartItem = new CartItem
                { //asigna valores según lo que se encontró
                    Name = foundItem.Name,
                    Image = foundItem.Image,
                    Price = foundItem.Price,
                    Quantity = 1 //from cartItem
                };

                carrito.addToCart(cartItem, 0); //se agrega al carrito con index (posición) 0

                //llamar función de Part2,Punto5

                CartItem itemCreated = carrito.getCartItemByIndex(0);
                Console.WriteLine("Cart item: " + itemCreated.Name);
            }
            else { Console.WriteLine("item not found :("); }

            
            
        }
        
    }
}

    