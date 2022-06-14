using System;
using System.Collections.Generic;
using System.IO;
using System.CodeDom.Compiler;
using System.Linq;

namespace GorilaEvenNumbers
{
    class Program
    {
        private static void Main(string[] args)
        {
           
            int amountOfEvenNumbersRequired = Convert.ToInt32(Console.ReadLine());

            List<int> numbers = new List<int>();
            for (int i = 1; i <= 200; i++)
            {
                numbers.Add(i);
            }

            List<int> res = GetEvenNumbers(numbers, amountOfEvenNumbersRequired);

            foreach (var evenNumber in res)
            {
                Console.WriteLine(evenNumber);
            }

            Console.ReadLine();
        }

        static List<int> GetEvenNumbers(List<int> numbers, int amountOfEvenNumbersRequired)
        {
            List<int> even = (from e in numbers where e % 2 == 0 select e).Take(amountOfEvenNumbersRequired).ToList();
            return even;   
        }
    }
}