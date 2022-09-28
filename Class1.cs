using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övningar
{
    internal class Class1
    {
        public void Go()
        { 

            while(true)
            {
                Console.WriteLine("Skriv 1 för att logga in");
                Console.WriteLine("Skriv 2 för att regga konto");

                string s = Console.ReadLine();
                
                switch (s)
                {
                    case "1":

                        Console.WriteLine("Matan in användarnamn");
                        string anv = Console.ReadLine();
                        Console.WriteLine("Mata in lösenord");
                        string lös = Console.ReadLine();
                        bool login = Login(anv, lös);
                        if (login)
                            Console.WriteLine("Du är inloggad");
                        else
                            Console.WriteLine("Du är inte inloggad");
                        break;

                    case "2":

                        User newuser = AddUser();

                        if (newuser == null) 
                        {
                            Console.WriteLine("Användarnamnet finns redan");
                            break;
                        }
                        else
                        {
                            using var sw = File.AppendText("accounts.txt");
                            sw.WriteLine(newuser.username);
                            sw.WriteLine(newuser.password);
                            break;
                        }
                }
            }
        }
        public bool Login(string nmn, string pss)
        {
            bool inloggad = false;
            bool isUsername = true;
            int i = 0;
            int j = 0;
            var lines = File.ReadLines("accounts.txt");
            foreach(var line in lines)
            {
                i++;
                if (isUsername)
                {
                    if (line == nmn)
                        j = i;

                    isUsername = false;
                }
                else if (line == pss && i - j == 1)
                {
                    inloggad = true;
                    break;
                }
                
                else
                    isUsername = true;
            }
            return inloggad;
        }

        public User AddUser()
        { 
            var användare = new User();
            //bool finnsRedan = false;

            Console.WriteLine("Mata in nytt användarnamn");
            string username = Console.ReadLine();

            var lines = File.ReadLines("accounts.txt");            
            if(lines.Count() == 0)
            {
                Console.WriteLine("Mata in nytt lösenord");
                string password = Console.ReadLine();
                användare.username = username;
                användare.password = password;
            }
            else
            {
                foreach(var line in lines)
                {
                    if(username == line)
                        return null;
                    
                }
                Console.WriteLine("Mata in nytt lösenord");
                string password = Console.ReadLine();
                användare.username = username;
                användare.password = password;
                 
            }
            return användare;

        }
    }
    public class User
    {
        public string username { get; set; }    
        public string password { get; set; }    
    }
}
