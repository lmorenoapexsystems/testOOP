using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using testOOP.Logging;
using System;

namespace testOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new ConsoleLogger();
            logger.Log(LogLevel.Info, "Tests initiated successfully");
            HomePage page = new HomePage();
            page.LoadPage();

            //Buscar item
            Item foundItem = page.getItemByName("Cap");

            if (foundItem != null)
            { //Si se encontró el item
                //Crear carrito
                logger.Log(LogLevel.Info, "Item found!");
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
                logger.Log(LogLevel.Warning, "Cart created!");

            }
            else { Console.WriteLine("item not found :("); }
            logger.Log(LogLevel.Error, "No items found");

            //LoggerFIle
            //string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ILogger filelog = new FileLog("test_log.txt");
            //test filelog
            filelog.Log(LogLevel.Info, "it works!");

        }
        
    }
}

    