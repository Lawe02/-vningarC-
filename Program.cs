using System;

namespace Övnnigar;
class Program
{
    public static void Main(string[] args)
    {
        List<int> talen = new List<int>();
        int i = 0;
        while (i<=3)
        {
            Console.WriteLine("Mata in ett tal");
            int inmatatTal = Convert.ToInt32(Console.ReadLine());
            talen.Add(inmatatTal);
            i++;
        }
        int störstTal =0;
        foreach(int tal in talen)
        {
            if(tal > störstTal)
            {
                störstTal = tal;
            }
        }
        Console.WriteLine("Största talet är "+ störstTal);
    }
}
