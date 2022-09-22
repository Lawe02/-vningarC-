using System;

namespace Övnnigar;
class Program
{
    public static void Main(string[] args)
    {
        var strings = new string[] { "anka", "hår", "Korv", "stressmås", "Attackhelikopter"};
        string ord = LängstaOrdet(strings);
        Console.WriteLine(ord);
    }
    static string LängstaOrdet(string[] arr, string lngst = "")
    {
        foreach(string s in arr)
        {
            if (s.Length > lngst.Length)
                lngst = s;
        }
        return lngst;
    }
}
