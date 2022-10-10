using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övningar
{
    internal class Class1
    {
        public void Go()
        {
            var list = new List<Person>();
            while(true)
            {
                Console.WriteLine("1 to add, 2 to read, 3 to move into, 4 to gat age in full years");
                string val = Console.ReadLine();
                switch(val)
                {
                    case "1":
                        Person mat = Goo();
                        list.Add(mat);
                        break;
                    case "2":
                        Read(list);
                        break;
                    case "3":
                        Read(list);
                        Console.WriteLine("Chose by name who to move");
                        string name = Console.ReadLine();
                        Person p1 = FindPerson(name, list);
                        
                        Console.WriteLine("Chose by name who to move into");
                        string name2 = Console.ReadLine();
                        Person p2 = FindPerson(name2, list);
                        p1.MoveInto(p1, p2);
                        list.Add(p1);
                        break;
                    case "4":
                        Console.WriteLine("Enter the name of who you want years from");
                        Person p = FindPerson(Console.ReadLine(), list);
                        int years = p.FullYears(p);
                        Console.WriteLine($"{p.Name} is {years} years old");

                        break;
                }
            }
        }
        public void Read(List<Person> list)
        {
            foreach(Person p in list)
            {
                Console.WriteLine(p);
            }
        }
        public Person FindPerson(string name, List<Person> list)
        {
            Person person = new Person(DateTime.Now);
            foreach(Person p in list)
            {
                if (name == p.Name)
                    person = p;
            }
            return person;
        }

        public Person Goo()
        {
            Person person = new Person(DateTime.Now);
          
            Console.WriteLine("Enter birthdate in yyyy-mm-dd");
            person.Time = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter where your street-address");
            person.GatuAddress = Console.ReadLine();
            Console.WriteLine("Enter postal code");
            person.PostNummer = int.Parse(Console.ReadLine());
            Console.WriteLine("Where you live");
            person.Postort = Console.ReadLine();
            Console.WriteLine("Enter your namne");
            person.Name = Console.ReadLine();
                
            return person;
                         
        }
    }
    public class Person
    {
        private string name;
        private DateTime time;
        private string postOrt;
        private string gatuAddress;
        private int postNummer;
        public DateTime Time { get { return time; } set { time = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Postort { get { return postOrt; } set {  postOrt = value; } }
        public string GatuAddress  { get { return gatuAddress; } set { gatuAddress = value; } }
        public int PostNummer { get { return postNummer; } set { postNummer = value; } }
        public Person(DateTime time)
        {
            this.time = time;
        }
        public override string ToString()
        {
            return "Name: " + Name + "  County: " + Postort + "  Address: " + GatuAddress +"  FödelseDatum: "+ Time.ToString("yyyy-mm-dd");
        }
        public void ChangeAddress(string postort, string gatuAddress, int postalCode)
        {
            this.postOrt = postort;
            this.gatuAddress = gatuAddress;
            this.postNummer = postalCode;
        }
        public void MoveInto(Person person,Person person2)
        {
            person.ChangeAddress(person2.Postort, person2.GatuAddress, person2.PostNummer);
        }
        public int FullYears(Person person)
        {
            TimeSpan TS = DateTime.Now - person.Time;
            double years = TS.TotalDays / 365.25;
            return Convert.ToInt32(years);
        }

    }
}
