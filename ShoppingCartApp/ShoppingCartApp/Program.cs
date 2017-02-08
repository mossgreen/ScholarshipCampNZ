using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Boolean cartIsEmpty = true;
            //todo: add user
            Console.WriteLine($"Hi, what's your name?");
            string name = Console.ReadLine().ToString();
            User u = new User {UserName = name};
            Console.WriteLine($"Welcome {u.UserName}! ");
            Console.WriteLine();

            DB db = new DB();

            Console.WriteLine($" this is {db.store.StoreName}. we've got following products:");

            foreach (Product p in db.store.Products)
            {
                Console.WriteLine($"product ID: {p.ProductId}, product name: {p.ProductName}, price: {p.ProductPrice}");
            }

            
            Console.WriteLine("hit '0' to Leave store");
            Console.WriteLine("hit product id to add it to your cart");
            if (!cartIsEmpty)
            {
                Console.WriteLine("-----------------hit '1' to checkout");
                Console.WriteLine("-----------------hit '2' to empty your cart");
            }

            try
            {
                int input = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Incorrect input");
            }


            Console.ReadLine();
        }
    }
}
