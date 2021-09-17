using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
            
            FilePermission[] allFiles = new FilePermission[args.Length];

            for (int i = 0; i < args.Length; i++)
            {
                if (args[i][0] != '.')
                {
                    Console.WriteLine("Введено некорректное разрешение искомых файлов. Разрешение должно начинаться с .");
                    return;
                }
                else
                {
                    Console.WriteLine("Введеное разрешение искомых файлов: " + args[i]);
                    allFiles[i] = new FilePermission(args[i]);
                }
            }
            Console.WriteLine();

            Console.WriteLine("Программа запущена из каталога: " + Directory.GetCurrentDirectory());
            Console.WriteLine();

            foreach (FilePermission f in allFiles)
            {
                f.FindFiles();
                f.ShowFiles();
                Console.WriteLine("Общее количество искомых файлов: {0}\n" +
                                   "Суммарный размер искомых файлов: {1} bytes \n" +
                                   "Суммарное количество строк в искомых файлах: {2}", f.CountFiles(), f.CountSize(), f.CountLines());
                Console.WriteLine();
            }
            
        }
    }
}
