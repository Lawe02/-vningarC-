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

    public static int BruttoTillNetto(int lön)
    {
        if (lön >= 30000)
            lön = Convert.ToInt32(lön * 0.33m);
        else if (lön < 15000)
            lön = Convert.ToInt32(lön * 0.12m);
        else if(lön <15000 && lön < 30000)
            lön = Convert.ToInt32(lön * 0.28m);
        return lön;
    }
}
