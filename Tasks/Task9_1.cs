using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class Task9_1
    {
        public Task9_1() 
        {
            Console.Write("Введите кол-во строк массива: ");
            int rows = Int32.Parse(Console.ReadLine());

            Console.Write("Введите кол-во столбцов массива: ");
            int columns = Int32.Parse(Console.ReadLine());
            int[,] array = new int[rows, columns];

            int[] countOdd = new int[columns];

            for(int i = 0; i<rows; i++)
            {
                for(int j = 0; j<columns; j++)
                {
                    Console.Write($" array [{i},{j}] = ");
                    array[i, j] = Int32.Parse(Console.ReadLine());
                    Console.WriteLine();
                }
                
            }


            Console.WriteLine();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{array[i, j],-5} ");
                }
                Console.WriteLine();
            }

            int counterOdd;
            Console.WriteLine();
            Console.WriteLine("Нечетных чисел в столбце:");
            for (int i = 0; i < columns; i++)
            {
                counterOdd = 0;
                for (int j = 0; j < rows; j++)
                {
                    
                    if (array[j, i] % 2 > 0)
                    {
                        counterOdd++;
                    }
                }

                countOdd[i] = counterOdd;
                Console.Write($"{countOdd[i], -5} ");
            }
            Console.WriteLine();
            int indexMin = columns-1;
            int valueMin = Int32.MaxValue;
            bool updateValue = false;
            for (int i = columns-1; i >= 0; i--)
            {
                if (countOdd[i]<valueMin && countOdd[i]!=0)
                {
                    updateValue = true;
                    valueMin = countOdd[i];
                    indexMin = i;
                }
            }
            if (updateValue)
            {
                Console.WriteLine($"Меньше всего нечетных чисел в столбце: {indexMin}");
            }
            else
            {
                Console.WriteLine("Массив не имеет нечетных чисел...");
            }
            
        }
    }
}
