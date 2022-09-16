using System;

namespace Övnnigar;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Skriv en text.");
        string txt = Console.ReadLine();
        txt = txt.Trim();
        int antalMellanslag = 1;
        bool mellanrum = true;

        foreach(char c in txt)
        {
            if(c == ' ' && mellanrum == true)
            {
                antalMellanslag++;
                mellanrum = false;
            }
            else if(c != ' ')
                mellanrum = true;
            
        }
        Console.WriteLine($"Antal ord: {antalMellanslag}");

    }
}
