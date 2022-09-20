using System;

namespace Övnnigar;
class Program
{
    public static void Main(string[] args)
    {
        var tabell = new List<int>();
        int störst = 0, summa = 0, antal=0;

        while(true)
        {
            Console.WriteLine("Mata in tal - skriv N för att avsluta");
            string tal = Console.ReadLine().ToUpper();
            if (tal == "N")
                break;
            else
            {
                tabell.Add(Convert.ToInt32(tal));
                antal++;
            }
        }
        int minst = tabell[0];
        foreach(int i in tabell)
        {
            summa += i;
            if (i > störst)
                störst = i;
            if (i < minst)
                minst = i;
        }
            
        Console.WriteLine($"Du matade in {antal} tal");
        Console.WriteLine($"Summan är {summa}");
        Console.WriteLine($"Medelvärde är {summa/antal}");
        Console.WriteLine($"Min {minst} Störst {störst}");
    }
}
