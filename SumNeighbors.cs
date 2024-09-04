using System;
using System.Collections.Generic;
using System.Linq;

namespace NumberListProcessing
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            List<int> numbers = new List<int>();
            Random rand = new Random();
            for (int i = 0; i < 20; i++)
            {
                numbers.Add(rand.Next(0, 100));
            }

            List<int> evenNumbers = numbers.Where(n => n % 2 == 0).ToList();

            List<int> addNumbers = numbers.Where(n => n % 2 != 0).ToList();

            List<int> sortNumbers = evenNumbers.Concat(addNumbers).ToList();

            Console.WriteLine("So   rteeritud numbers: ");

            sortNumbers.ForEach(n => Console.WriteLine(n + " "));
        }

    }
}