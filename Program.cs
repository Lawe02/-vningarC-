using System;

namespace Övnnigar;
class Program
{
    public static void Main(string[] args)
    {       
        Console.WriteLine("Ange lönen");
        int lön = Convert.ToInt32(Console.ReadLine());
        decimal netto = BruttoTillNetto(lön);
        Console.WriteLine("Efterskatt  " + netto);
    }

    public static decimal BruttoTillNetto(int lön)
    {
        decimal res = 0;
        if (lön >= 30000)
            res = lön * 0.67m;
        else if (lön < 15000)
            res = lön * 0.88m;
        else if(lön <15000 && lön < 30000)
            res = lön * 0.72m;
        return res;
    }
}
