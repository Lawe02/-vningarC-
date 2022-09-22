using System;

namespace Övnnigar;
class Program
{
    public static void Main(string[] args)
    {
        decimal anka = Proc(100);
        Console.WriteLine(anka);
    }
    static decimal Proc(int sum, decimal procent = 0.25m)
    {
        return sum * procent;
    }
}
