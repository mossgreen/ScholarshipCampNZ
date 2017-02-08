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
            User u = new User { UserName = name };
            DB db = new DB();
            db.cart.CartIsEmpty = true;

            while (!db.store.Checkout)
            {
                Greeting(u, db);
                showCart(u, db);
                Input(db, u);
            }
            

        }

        private static void Input(DB db, User u)
        {
            inputInstruction(db);
            int userInput = int.Parse(Console.ReadLine());

            if (userInput == 0)
            {
                db.cart = new Cart();
                db.cart.Products = new List<Product>();
                Greeting(u, db);
                db.cart.CartIsEmpty = false;
            }
            else
            {
                Product product = db.store.Products.FirstOrDefault(p => p.ProductId == userInput);
                db.cart.Products.Add(product);
                db.cart.CartIsEmpty = false;
            }

            showCart(u, db);
        }

        private static void inputInstruction(DB db)
        {
            Console.WriteLine("\n-----------------input product id to add it to your cart");
            Console.WriteLine("-----------------hit '0' to tempty your cart");
            Console.WriteLine("-----------------hit '1' to checkout \n");
        }

        private static void showCart(User u, DB db)
        {
            
            // if cart is empty, ask user to pick products
            if (db.cart.CartIsEmpty)
            {
                Console.WriteLine($"Hi {u.UserName}, your cart is empty, come and pick some!");
            }
            else
            {
                //if cart is not empty, report counts, and list all items
                Console.WriteLine($"\nyou've got {db.cart.Products.Count} items in your cart, see the following list:\n ");

                foreach (Product p in db.cart.Products)
                {
                    Console.WriteLine($"product ID: {p.ProductId}, product name: {p.ProductName}, price: {p.ProductPrice}");
                }


            }

        }

        private static void Greeting(User u, DB db)
        {
            Console.WriteLine($"Welcome {u.UserName}!\n ");
            Console.WriteLine($" this is {db.store.StoreName}. we've got following products:\n");

            foreach (Product p in db.store.Products)
            {
                Console.WriteLine($"product ID: {p.ProductId}, product name: {p.ProductName}, price: {p.ProductPrice}");
            }
        }
    }
}
