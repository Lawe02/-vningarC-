using System;

namespace Övnnigar;
class Program
{
    public static void Main(string[] args)
    {
        
        Console.WriteLine("Ange en vokal");
        string sträng = Console.ReadLine().ToUpper();
        string kskVokal = Translate(sträng);
        Console.WriteLine(kskVokal);
    }

    public static string Translate(string bkstv)
    {
        var arr = new char[] { 'A', 'E', 'I', 'O', 'U', 'Y', 'Å', 'Ä', 'Ö' };
        string translatedString = "";
        foreach (char c in bkstv)
        {
            if (arr.Contains(c))
                translatedString += c;
            else if (c == ' ')
                translatedString += c;
            else
                translatedString += $"{c}o{c}";           
        }
        return translatedString.ToLower();
    }
}
