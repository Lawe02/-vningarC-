using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övningar
{
    internal class Class1
    {
        public void Go()
        {
            while(true)
            {
                Console.WriteLine("Ange mappnamn");
                string folderName = Console.ReadLine();
                Console.WriteLine("Ange filtyp ex.. '.txt' ");
                string extension = Console.ReadLine();
                var files = FindFiles(folderName, extension);

                foreach(string file in files)
                {
                    var size = new FileInfo(file).Length;
                    Console.WriteLine($"Namn: {file}, Sotrlek: {size} Bytes");
                }

            }
        }

        public List<string> FindFiles(string path, string exe)
        {
            var allFiles = new List<string>();
            IEnumerable<string> allFilesInDirectory = Directory.EnumerateFiles(path);

            foreach(var file in allFilesInDirectory)
            {
                if (file.EndsWith(exe))
                    allFiles.Add(file);
            }
            return allFiles;

        }
    }
}
