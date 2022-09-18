using System;

namespace Övnnigar;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Mata in hur många tal som ska adderas");
        int antal = Convert.ToInt32(Console.ReadLine());
        int[] talArr = new int[antal];
        int summa = 0;

        while(antal > 0)
        {
            Console.WriteLine("Skriv in ett tal som ska adderas");
            talArr[antal-1] = Convert.ToInt32(Console.ReadLine());
            antal--;
        }
        foreach(int a in talArr)
        {
            summa += a;
        }
        Console.WriteLine($"Summan är {summa}");
    }
}
