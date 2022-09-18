using System;

namespace Övnnigar;
class Program
{
    public static void Main(string[] args)
    {
        var list = new List<string> { "Kalle", "aa", "ada", "Nisse" };
        int antalSträngar = 0;
        foreach(string str in list)
        {
            if(str.Length >= 2 && str[0] == str[str.Length-1])
            {
                antalSträngar++;
            }
        }
        Console.WriteLine($"Antalsträngar som upffyller kraven är {antalSträngar}");
    }
}
