using System;

namespace Övnnigar;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ange hur många mätningar som ska matas in");
        int ant = Convert.ToInt32(Console.ReadLine());
        decimal[] arr = new decimal[ant];
       
        while (ant > 0)
        {
            Console.WriteLine("Lägg in en temperatur i celsius med decimal");
            decimal temperatur = Convert.ToDecimal(Console.ReadLine());
            arr[arr.Length - ant] = temperatur;
            ant--;
        }

        decimal störst = 0, minst = arr[0];

        foreach (decimal temp in arr)
        {
            if (temp < minst)
                minst = temp;
            if (temp > störst)
                störst = temp;  
            Console.WriteLine(temp);
        }
        Console.WriteLine($"Minst: {minst}");
        Console.WriteLine($"Störst: {störst}");
    }
}
