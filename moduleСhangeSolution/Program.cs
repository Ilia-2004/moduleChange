using System;

namespace func
{
    internal abstract class Program
    {
        private static void Main(string[] args)
        {
            int[] numbers = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };
            var n = numbers.Length; // длина массива
            var k = n / 2;          // середина массива

            for (var i = 0; i < k; i++)
                (numbers[i], numbers[n - i - 1]) = (numbers[n - i - 1], numbers[i]);

            foreach (var i in numbers)
                Console.Write($"{i} \t");
        }
    }
}
