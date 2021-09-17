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
        int count = 0;

        public FilePermission(string s)
        {
            name = '*' + s;
        }

        public void FindFiles(string in_path)
        {
            IEnumerable<string> allFilesInAllFolders = Directory.EnumerateFiles(in_path, name, SearchOption.AllDirectories);

            foreach (var file in allFilesInAllFolders)
            {
                Console.WriteLine(file);
                count++;
            }
        }
    }
}
