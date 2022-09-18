using System;

namespace Övnnigar;
class Program
{
    public static void Main(string[] args)
    {
        int[] talen = new int [4];
        int i = 0;
        while (i<=3)
        {
            Console.WriteLine("Mata in ett tal");
            talen[i] = Convert.ToInt32(Console.ReadLine());
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
        Console.WriteLine(störstTal);
    }
}
