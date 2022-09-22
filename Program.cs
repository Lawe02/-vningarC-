using System;

namespace Övnnigar;
class Program
{
    public static void Main(string[] args)
    {
        string s = Plussa("Anka", "Quack");
        Console.WriteLine(s);
    }
    public static string Plussa(string i, string j)
    {
        return i + j;
    }
}
