using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Переписать в другой файл все строки из файла
 * file1.txt, вставив в начало каждой строки
 * ее порядковый номер.
 */
namespace Tasks
{
    class Task11_1
    {
        public Task11_1() 
        {
            string defaultPath = "file1.txt";

            string text = "Адище города окна разбили\r\nна крохотные, сосущие светами адки.\r\nРыжие дьяволы, вздымались автомобили,\r\nнад самым ухом взрывая гудки.\r\n\r\nА там, под вывеской, где сельди из Керчи —\r\nсбитый старикашка шарил очки\r\nи заплакал, когда в вечереющем смерче\r\nтрамвай с разбега взметнул зрачки.";

            Console.Write("Нумеровать пустую строку? (y/n)");
            bool checkNullLine = Console.ReadLine().ToLower() == "y"?true:false;
            Console.WriteLine();

            createFiles(text, defaultPath);
            Console.WriteLine(readerFile(defaultPath, checkNullLine));
            
        }



        private void createFiles(string text, string path)
        {
            using(FileStream file = new FileStream(path, FileMode.OpenOrCreate))
            {
                
                byte[] buffer = Encoding.Default.GetBytes(text);
                file.Write(buffer);
            }
        }

        private string readerFile (string path, bool nullLine)
        {
            string? fullText = null;
            using (StreamReader reader = new StreamReader(path))
            {
                
                string? line;
                int counter = 1;
                while ((line = reader.ReadLine())!= null)
                {
                    if (line.Length > 0 || nullLine == true)
                    {
                        fullText += $"{counter}. {line} \n";
                        counter++;
                    }
                    else
                    {
                        fullText += $"\n";
                    }

                }
            }

            return fullText;
        }
    }
}
