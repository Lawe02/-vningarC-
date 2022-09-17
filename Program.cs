using System;

namespace Övnnigar;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Mata in ett ord eller mening");
        string kskDrom = Console.ReadLine();
        string drom = "";

        foreach(char c in kskDrom)
        {
            if (c != ' ')
            {
                drom += c;
            }
        }
        string revdrom = "";
        for(int i = drom.Length - 1; i >=  0 ; i--)
        {
            revdrom += drom[i];
        }
        if (drom == revdrom)
            Console.WriteLine("Detta är en palindrom: " + drom);
        else
            Console.WriteLine("Detta är inte en palindrom: " + revdrom);
    }
}
