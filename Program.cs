using System;

namespace Övnnigar;
class Program
{
    public static void Main(string[] args)
    {
        
        using (var file = File.CreateText("nyarader.txt"))
        {
            file.WriteLine("Hund");
            file.WriteLine("Katt");
            file.WriteLine("Gam");
            file.WriteLine("Gris");
            file.WriteLine("ko");
            file.WriteLine("häst");
        }

        using (var file = File.CreateText("result.txt"))
        {
            var lines = File.ReadLines("rader.txt");
            foreach (var line in lines)
            {
                file.WriteLine(line);
            }

            var lines2 = File.ReadLines("nyarader.txt");
            foreach (var line in lines2)
            {
                file.WriteLine(line);
            }
        }         
    }
}
