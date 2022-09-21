using System;

namespace Övnnigar;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ange hur många mätningar som ska matas in");
        int ant = Convert.ToInt32(Console.ReadLine());
        var cels = new List<decimal>();
        var platser = new List<string>();

        decimal sum = 0;

        while (ant > 0)
        {
            Console.Write("Lägg in en temperatur i celsius:  ");
            decimal temperatur = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Ange platsen mätningen kommer ifrån:  ");
            string plats = Console.ReadLine();
            Console.WriteLine();
            
            platser.Add(plats);
            cels.Add(temperatur);

            sum += temperatur;
            ant--;
        }

        decimal störst = 0, minst = cels[0];

        foreach (decimal temp in cels)
        {
            if (temp < minst)
                minst = temp;
            if (temp > störst)
                störst = temp;  
        }

        for(int i = 0; i < cels.Count; i++)
        {
            Console.WriteLine($"Plats: {platser[i]}, Temperatur: {cels[i]}");
        }

        Console.WriteLine($"Medel: {sum/cels.Count}");
        Console.WriteLine($"Störst: {störst}");
    }
}
