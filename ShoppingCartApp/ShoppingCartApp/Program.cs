using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp
{
    class Program
    {

        static void Main(string[] args)
        {

            //todo: add user
            Console.WriteLine($"Hi, what's your name?");
            string name = Console.ReadLine()?.ToString();
            User u = new User {UserName = name};
            Console.WriteLine($"Welcome {u.UserName}!\n ");
            DB db = new DB();

            while (!db.store.Checkout)
            {
                Greeting(u, db);
                ShowCart(u, db);
                Input(db, u);
            }


        }

        private static void Input(DB db, User u)
        {
            InputInstruction(db);
            try
            {
                int userInput = int.Parse(Console.ReadLine());

                if (userInput == 0)
                {
                    db.cart = new Cart();
                    db.cart.Products = new List<Product>();
                    Greeting(u, db);
                    db.cart.CartIsEmpty = true;
                }
                else
                {
                    Product product = db.store.Products.FirstOrDefault(p => p.ProductId == userInput);
                    db.store.Sell(product);
                    db.cart.AddToCart(product);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"wrong input. {ex}");
            }

            //  showCart(u, db);
        }

        private static void InputInstruction(DB db)
        {
            Console.WriteLine("\n-----------------input product id to add it to your cart");
            Console.WriteLine("-----------------hit '0' to tempty your cart");
            Console.WriteLine("-----------------hit '1' to checkout \n");
        }

        private static void ShowCart(User u, DB db)
        {

            // if cart is empty, ask user to pick products
            if (db.cart.CartIsEmpty)
            {
                Console.WriteLine($"\nHi {u.UserName}, your cart is empty, come and pick some!");
            }
            else
            {
                //if cart is not empty, report counts, and list all items

                try
                {
                    db.cart.listCart();
                }
                catch (Exception ex)
                {

                    Console.WriteLine($"\n\n{ex}.");
                }
            }

        }

        private static void Greeting(User u, DB db)
        {

            Console.WriteLine($" this is {db.store.StoreName}. we've got following products:\n");
            db.store.ShowStoreProducts();
        }
    }
}
