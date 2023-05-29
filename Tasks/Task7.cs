using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class Task7
    {
        public Task7 () 
        { 
            Random rand = new Random ();
            Console.Write("Введите кол-во элементов массива: ");
            int countElem = Int32.Parse(Console.ReadLine());
            int[] array = new int[countElem];

            int[] temp = new int[countElem/2];

            Console.WriteLine("Сгенерированный массив: ");
            for (int i = 0; i < countElem; i++)
            {
                array[i] = rand.Next(0, 100);
                Console.Write($"{array[i]}  ");
            }
            Console.WriteLine();
            int counterTemp =0;
            Console.WriteLine("Ямы: ");
            int minValue = Int32.MaxValue;
            for(int i=0; i < countElem; i++) 
            { 
                if(i>0 && i<countElem-1)
                {
                    if (array[i] < array[i-1] && array[i + 1] > array[i])
                    {
                        temp[counterTemp] = array[i];
                        
                        Console.Write($"{temp[counterTemp]} ");
                        if (minValue > temp[counterTemp])
                        {
                            minValue= temp[counterTemp];
                        }
                        counterTemp++;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Самая глубокая яма в массиве {minValue}");
        }
    }
}
