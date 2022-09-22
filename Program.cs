using System;

namespace Övnnigar;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hur gammal är du");
        int age = Convert.ToInt32(Console.ReadLine());
        string myndig = IsMyndig(age);
        Console.WriteLine(myndig);
    }
    static string IsMyndig(int ålder)
    {
        if (ålder >= 18)
            return "Du är myndig";
        else
            return "Du är inte myndig";
    }
}
