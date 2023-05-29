using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class Task5
    {
        public Task5()
        {
            Console.Write("x ==> ");
            int x = Int32.Parse(Console.ReadLine());
            Console.Write("i ==> ");
            int i = Int32.Parse(Console.ReadLine());

            double temp = 0;
            for (int j = 1; j < i; j++)
            {
                if (j % 2 == 0)
                {
                    temp -= (1 / factorial(j)) + (1 / factorial((2 * j) - 1)) * Math.Pow(x, j * 2);
                }
                else
                {
                    temp += (1 / factorial(j)) + (1 / factorial((2 * j) - 1)) * Math.Pow(x, j * 2);
                }
            }

            Console.WriteLine($"y = {temp}");
        }
        private static long factorial(long number)
        {
            if (number == 1 || number == 0)
                return 1;
            return number * factorial(number - 1);
        }

    }
}
