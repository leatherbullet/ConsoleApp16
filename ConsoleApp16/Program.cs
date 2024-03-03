using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int minValue = 0;
            int maxValue = 101;
            int number = 2;
            int numberDegree = 2;
            int degree = 0;
            int randomNumber = random.Next(minValue, maxValue);
            Console.WriteLine("случайное число " + randomNumber);

            while (randomNumber > numberDegree)
            {
                degree++;
                numberDegree *= number;
            }

            Console.WriteLine($"минимальная степень:{degree} числа:{number}");
        }
    }
}
