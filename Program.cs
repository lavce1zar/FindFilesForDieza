using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindFilesForDieza
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("Для применения программы необходимо ввести разрешение искомых файлов. Пример: " + '.' + "exe");
                return;
            }

            if (args[0][0] != '.')
            {
                Console.WriteLine("Введено некорректное разрешение искомых файлов. Разрешение должно начинаться с .");
                return;
            }
            else
            {
                Console.WriteLine("Введеное разрешение искомых файлов: " + args[0]);
            }
            


        }
    }
}
