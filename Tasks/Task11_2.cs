using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Создать файл, содержащий сведения о деталях
 * (код детали, наименование (15 символов), количество).
 * Вывести деталь по её порядковому номеру в файле.
 */

namespace Tasks
{
    class Detail
    {
        public string Id;
        public string Name;
        public string Count;

        public Detail(string id, string name, string count) 
        { 
            Id = id;
            Name = name;
            Count = count;
        }
    }

    class Task11_2
    {
        public Task11_2()
        {
            string defaultPath = "table_details.txt";

            createFiles(defaultPath);

            List<Detail> details = readerFile(defaultPath);

            while (menu(details))
            {
                Console.WriteLine("Нажмите любую клавишу...");
                Console.ReadLine();
                Console.Clear();
            }
           
        }

        private bool menu(List<Detail> details)
        {
            Console.WriteLine("Выберите операцию\n1 - Вывести всю таблицу\n2 - Найти значение\n0 - Выход");
            string temp = Console.ReadLine();

            switch (temp)
            {
                case "1":
                    printTable(details);

                    return true;
                case "2":

                    Console.WriteLine("Введите искомый ID: ");
                    string search = Console.ReadLine();
                    int? index = null;
                    index = searchItem(search, details);
                    Console.WriteLine($"ИД: {details[index.Value].Id}\nНаименование: {details[index.Value].Name}\nКоличество: {details[index.Value].Count}");

                    return true;
                case "0":
                    return false;
                default:
                    Console.WriteLine("Операция не распознана");
                    return true;
            }
        }

        private int? searchItem(string id, List<Detail> details)
        {
            foreach (Detail detail in details)
            {
                if(detail.Id == id)
                {
                    return details.IndexOf(detail);
                }
            }
            return null;
        }

        private void printTable(List<Detail> details)
        {
          

            Console.WriteLine($"╔══════╦═══════════════╦══════╗");
            Console.WriteLine($"║  Ид. ║Наименование   ║ Кол. ║");

            foreach (Detail detail in details)
            {
                Console.WriteLine($"╠══════╬═══════════════╬══════╣");
                Console.WriteLine($"║{detail.Id,-6}║{detail.Name,-15}║{detail.Count,-6}║");

            }
            Console.WriteLine($"╚══════╩═══════════════╩══════╝");
            
        }

        private void createFiles(string path)
        {
            string defaultText = "1|Железячка|2\n2|Пластмасска|10\n3|Ступица на 2107|10\n4|Винтик|43\n5|Колено поршня|123\n";


            using (FileStream file = new FileStream(path, FileMode.OpenOrCreate))
            {

                byte[] buffer = Encoding.Default.GetBytes(defaultText);
                file.Write(buffer);
            }
        }

        private List<Detail> readerFile(string path)
        {
            List<Detail> details = new List<Detail>();

            string? fullText = null;
            using (StreamReader reader = new StreamReader(path))
            {
                
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    details.Add(new Detail(id: line.Split('|').GetValue(0).ToString(),
                                           name: line.Split('|').GetValue(1).ToString(), 
                                           count: line.Split('|').GetValue(2).ToString()));
                }
            }
            return details;
        }
    }
}
