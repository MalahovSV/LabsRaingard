using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class Task8
    {
        public Task8()
        {
            Random rand = new Random();
            Console.Write("Введите кол-во элементов массива: ");
            int countElem = Int32.Parse(Console.ReadLine());
            int[] array = new int[countElem];

            Console.WriteLine("Сгенерированный массив: ");
            for (int i = 0; i < countElem; i++)
            {
                array[i] = rand.Next(0, 100);
                Console.Write($"{array[i]}  ");
            }
            Console.WriteLine();

            array = array.Reverse().ToArray();

            Console.WriteLine("Обратный массив: ");
            for (int i = 0; i < countElem; i++)
            {
                Console.Write($"{array[i]}  ");
            }
        }
    }
}
