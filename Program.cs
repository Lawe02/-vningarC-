using System;

namespace Övnnigar;
class Program
{
    public static void Main(string[] args)
    {
        
        Console.WriteLine("Ange en vokal");
        string bokstav = Console.ReadLine().ToUpper();
        bool kskVokal = IsVokal(bokstav);
        Console.WriteLine(kskVokal);
    }

    public static bool IsVokal(string bkstv)
    {
        var arr = new string[] { "A", "E", "I", "O", "U", "Y", "Å", "Ä", "Ö" };
        if (arr.Contains(bkstv))
        {
            return true;
        }
        else
            return false;
    }
}
