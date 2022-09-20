using System;

namespace Övnnigar;
class Program
{
    public static void Main(string[] args)
    {
        var tal = new List<int>() { 1, 2, 3, 4, 5, 6};
        int i = 0;

        foreach(int num in tal.ToList())
        {
            if((num % 2 !=0))
            {
                tal[i] = 0;
            }
            i++;
        }
        foreach(int num in tal)
        {
            Console.WriteLine(num);   
        }
    }
}
