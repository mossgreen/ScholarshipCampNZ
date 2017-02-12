using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EggsInBasket
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("The minimum number of Eggs in the basket given the situation is");
            for (int numberOfEggs = 1;; numberOfEggs += 1)
            {
                if ((numberOfEggs%1 == 0) && (numberOfEggs%2 == 1) && (numberOfEggs%3 == 0) && (numberOfEggs%4 == 1) &&
                    ((numberOfEggs + 1)%5 == 0) && (numberOfEggs%6 == 3) && (numberOfEggs%7 == 0) &&
                    (numberOfEggs%8 == 1) && (numberOfEggs%9 == 0))
                {
                    Console.WriteLine(numberOfEggs);
                    break;
                }
            }
            Console.ReadLine();

            //int number = 9;

            //Boolean logic =
            //    (number%2 == 1) && (number%3 == 0) && (number%4 == 1) && ((number+1)%5 == 4) && (number%6 == 3) &&
            //    (number%7 == 0) && (number%8 == 1) && (number%9 == 0);

            //while (!logic)
            //{
            //    number += 1;
            //    Console.WriteLine($"number is: {number}");
            //}

            //Console.WriteLine($"number is: {number}");
        }
    }
}
