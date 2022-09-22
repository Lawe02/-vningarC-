using System;

namespace Övnnigar;
class Program
{
    public static void Main(string[] args)
    {
        string s = GetMessage();
        Console.WriteLine(s);
    }
    public static string GetMessage()
    {
        return "Hello world";
    }
}
