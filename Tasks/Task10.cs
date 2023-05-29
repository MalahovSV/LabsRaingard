using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class Task10
    {

        public Task10() 
        {
            Console.Write("Введите ФИО: ");
            string FIO = Console.ReadLine();
            Console.WriteLine();
            var listFio = FIO.Split(' ');

            string temp;
            string a;

            string? replay = "";
            foreach (var item in listFio)
            {
                temp = item.ToLower();

                a = temp[0].ToString();
                a = a.ToUpper();

                temp = a+temp.Substring(1);

                replay += $"{temp} ";
            }

            Console.WriteLine(replay);
        }
    }
}
