// See https://aka.ms/new-console-template for more information
namespace Övnnigar;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Skriv in för och efternamn med små bokstäver");
        string nmn = Console.ReadLine();
        string S = nmn.Substring(0, 1);
        string nmnS = nmn.Substring(0, 1).ToUpper();
        nmn = nmn.Replace(S, nmnS);
        bool anka = false;
        string nstrg = "";
        foreach (char c in nmn)
        {
            if (c == ' ')
            {
                anka = true;
                nstrg += c;
            }
            else if (anka == true && c != ' ')
            {
                nstrg += char.ToUpper(c);
                anka = false;
            }
            else
            {
                nstrg += c;
            }
        }
        Console.WriteLine(nstrg);
    }
}
