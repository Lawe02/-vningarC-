// See https://aka.ms/new-console-template for more information
namespace Övnnigar;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Skriv in din mailadress.");
        string mail = Console.ReadLine();
        if(mail.Contains('@'))
        {
            if(mail.Contains('.'))
                {
                string h = mail.Substring(mail.LastIndexOf('.'));
                if (h.Length == 3 || h.Length == 4)
                    Console.WriteLine("Giltig");
                else
                    Console.WriteLine("Ogiltig");
            }
            else
                Console.WriteLine("Ogiltig");
        }
        else
            Console.WriteLine("Ogiltig");
    }
}
