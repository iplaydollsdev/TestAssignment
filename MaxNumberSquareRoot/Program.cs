using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAssignment
{
    internal class Program
    {
        static void Main()
        {
            int[] numbers = { 4, 9, 16, 25, 50, 64, 81, 100, 110, 115 };
            int maxNumber = GetMaxNumberSquare(numbers);
            Console.WriteLine($"Наибольшее число, являющееся полным квадратом: {maxNumber}");
            Console.ReadLine();

            int minPowerOfTwo = GetMinPowerOfTwo(numbers);
            Console.WriteLine($"Наименьшая степень 2, равная или больше суммы чисел: {minPowerOfTwo}");
            Console.ReadLine();
        }

        private static int GetMaxNumberSquare(int[] numbers)
        {
            int maxNumber = -1;

            foreach (int number in numbers)
            {
                double squareRoot = Math.Sqrt(number);
                int integerPart = (int)squareRoot;

                if (squareRoot == integerPart)
                {
                    if (number > maxNumber)
                    {
                        maxNumber = number;
                    }
                }
            }

            return maxNumber;
        }

        private static int GetMinPowerOfTwo(int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }

            int powerOfTwo = 1;
            while (powerOfTwo < sum)
            {
                powerOfTwo *= 2;
            }

            return powerOfTwo;
        }
    }
}
