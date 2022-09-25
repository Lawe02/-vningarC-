using System;

namespace Övnnigar;
class Program
{
    public static void Main(string[] args)
    {
        
        using (var file = File.CreateText("rader.txt"))
        {
            file.WriteLine("Anka");
            file.WriteLine("Gås");
            file.WriteLine("Mås");
            file.WriteLine("Stressmås");
            file.WriteLine("fiskmås");
            file.WriteLine("Plastmås");
        }

        var lines = File.ReadLines("rader.txt");
        bool varannan = true;
        foreach(var file in lines)
        {
            if (varannan == true)
            {          
                Console.WriteLine(file);
                varannan = false;
            }
            else
                varannan = true;
        }
        
     
    }


    
}
