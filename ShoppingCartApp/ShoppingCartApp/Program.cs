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
            Product p1 = new Product { ProductName = "p1 name",ProductPrice = 11.11};
            Product p2 = new Product { ProductName = "p2 name",ProductPrice = 22.22};
            //todo: add user

            User u = new User {UserName = "moss"};
            Console.WriteLine($"Welcome {u.UserName}! we have folling products:");
            Console.WriteLine();

            Cart c = new Cart {CartId = 1,Products = new List<Product>()};
            c.Products.Add(p1);
            c.Products.Add(p2);
            c.TotalPrice = c.GetPrice();

            Console.WriteLine("Do you want to checkout?");

            //yes,to checkout; No, go on shopping
            //yes =>
            Console.WriteLine($"Thanks {u.UserName} ! products you choose {c.Products.Count} products");


            foreach (Product p in c.Products)
            {
                Console.WriteLine(p.ProductName);
            }
           // Console.WriteLine(c.Products.Select(p => p.ProductName));
            

            Console.WriteLine(c.TotalPrice);

            Console.WriteLine(c.Products.Count);





            Console.ReadLine();
        }
    }
}
