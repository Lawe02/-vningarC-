using System;

namespace Övnnigar;
class Program
{
    public static void Main(string[] args)
    {
        using ( var file = File.CreateText("rader.txt"))
        {
            file.WriteLine("Fisk");
            file.WriteLine("Hår");
            file.WriteLine("kyckling");
            file.WriteLine("mat");
        }

        using ( var file = File.CreateText("radnummer.txt"))
        {
            int i = 1;
            foreach(var line in File.ReadLines("rader.txt"))
            {
                file.WriteLine($"{i} {line}");
                i++;
            }
        }
    }
}
