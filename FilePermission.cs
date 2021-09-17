using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FindFilesForDieza
{
    class FilePermission
    {
        string name;
        int count_files = 0;
        long count_size = 0;
        int count_lines = 0;

        public FilePermission(string s)
        {
            name = '*' + s;
        }

        public FileInfo[] FindFiles()
        {
            DirectoryInfo dir = new DirectoryInfo(Directory.GetCurrentDirectory());
            FileInfo[] filArr = dir.GetFiles(name, SearchOption.AllDirectories);
            return filArr;
        }

        public void ShowFiles()
        {
            Console.WriteLine("Перечень файлов с искомым разрешением {0}: ", name);
            foreach (FileInfo f in this.FindFiles())
                Console.WriteLine(f);
            Console.WriteLine();
        }

        public int CountFiles()
        {
            if (count_files != 0)
                count_files = 0;
            foreach (FileInfo f in this.FindFiles())
                count_files++;
            return count_files;
        }

        public long CountSize()
        {
            if (count_size != 0)
                count_size = 0;
            foreach (FileInfo f in this.FindFiles())
                count_size += f.Length;
            return count_size;
        }

        public int CountLines()
        {
            if (count_lines != 0)
                count_lines = 0;

            IEnumerable<string> allFilesInAllFolders = Directory.EnumerateFiles(Directory.GetCurrentDirectory(), name, SearchOption.AllDirectories);
            foreach (var f in allFilesInAllFolders)
                count_lines += File.ReadAllLines(f).Length;
            return count_lines;
        }
















        //IEnumerable<string> allFilesInAllFolders = Directory.EnumerateFiles(in_path, name, SearchOption.AllDirectories);


    }
}
