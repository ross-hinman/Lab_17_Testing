using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_17_Testing
{
    public class Program
    {
        static void Main(string[] args)
        {
            var validator = new PrimeNumberValidator();
            List<int> primes = new List<int>();
            int number = 2;
            do
            {
                if (validator.IsPrime(number))
                {
                    primes.Add(number);
                }
                number++;
            } while (primes.Count < 100);
            bool repeat = true;
            do
            {
                Console.WriteLine("Please enter a number that cooresponds to the prime number you would like to see:");
                int input = int.Parse(Console.ReadLine());
                Console.WriteLine($"Prime number {input} is {primes[input - 1]}.");
                Console.WriteLine("Do you wish to continue? (y/n)");
                string answer = Console.ReadLine().ToLower();
                if (answer == "y")
                {
                    repeat = true;
                }
                if (answer == "n")
                {
                    Console.WriteLine("Thank you!");
                    repeat = false;
                }
            } while (repeat == true);
            


        }
    }
}
