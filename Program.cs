// See https://aka.ms/new-console-template for more information
namespace Övnnigar;
class Program
{
    public static void Main(string[] args)
    {
        string s = "Detta är en sträng som du ska ändra";
        string hårSträng = "";
        int ankSlag = 0;

        foreach(char c in s)
        {            if(c == ' ')
            {
                ankSlag++;
                hårSträng += '*';
            }
            else
            {
                hårSträng += c;
            }
        }
        Console.WriteLine($"Antal mellanslag: {ankSlag}, Ny text: {hårSträng}");

    }
}
