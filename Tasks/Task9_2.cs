using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class Task9_2
    {
        public Task9_2() 
        {
            Random rand = new Random();
            Console.Write("Введите кол-во строк массива: ");
            int rows = Int32.Parse(Console.ReadLine());

            Console.Write("Введите кол-во столбцов массива: ");
            int columns = Int32.Parse(Console.ReadLine());
            int[,] array = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = rand.Next(0, 100);
                    Console.Write($"{array[i, j], -5}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            int temp;
            for (int i = 0; i < rows-1; i+=2)
            {
                for (int j = 0; j < columns; j++)
                {
                    temp = array[i, j];
                    array[i, j] = array[i+1, j];
                    array[i + 1, j] = temp;
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{array[i, j],-5}");
                }
                Console.WriteLine();
            }
        }
    }
}
