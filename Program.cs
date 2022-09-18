using System;

namespace Övnnigar;
class Program
{
    public static void Main(string[] args)
    {
        string[] veckodagar = new[] { "Måndag", "Tisdag", "Onsdag", "Torsdag", "Fredag", "Lördag", "Söndag" };
        while (true)
        {
            Console.WriteLine("Mata in 1-7");
            int dag = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Dag {dag} på veckan är {veckodagar[dag-1]}");
        }
    }
}
