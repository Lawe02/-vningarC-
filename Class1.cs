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
            var list = new List<Dish>();
            while(true)
            {
                Console.WriteLine("1 to add, 2 to read");
                string val = Console.ReadLine();
                switch(val)
                {
                    case "1":
                        Dish mat = Goo();
                        list.Add(mat);
                        break;
                    case "2":
                        Read(list);
                        break;
                }
            }
        }
        public void Read(List<Dish> list)
        {
            Console.WriteLine("Ange 0 för vegansk, 1 för vegetarisk eller 2 för kött");
            Type typ = (Type)int.Parse(Console.ReadLine());
            foreach(Dish rätt in list)
            {
                if (rätt.Type == typ)
                    Console.WriteLine(rätt);
            }
        }

        public Dish Goo()
        {
            Dish mat = new Dish(1, 1, Type.Vegetarian, "Hår");
          
                Console.WriteLine("Enter Lunchname");
                mat.Name = Console.ReadLine();
                Console.WriteLine("Enter amunt of cals");
                mat.Cals = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter price");
                mat.Price = int.Parse(Console.ReadLine());
                mat.Type = (Type)int.Parse(Console.ReadLine());
            return mat;
                
            
        }
    }
    public enum Type
    {
        Vegan,
        Vegetarian,
        Meat
    }
    public class Dish
    {
        private string name;
        private int price;
        private Type type;
        private int cals;
        public int Price { get { return price; } set { price = value; } }
        public string Name { get { return name; } set { name = value; } }
        public Type Type { get { return type; } set { type = value; } }
        public int Cals { get { return cals; } set { cals = value; } }

        public Dish(int price, int cals, Type type, string name)
        {
            this.price = price;
            this.cals = cals;
            this.type = type;
            this.name = name;
        }
        public override string ToString()
        {
            return "Price: " + Price + "  Cals: " + Cals + "  Type: " + Type + "  Name: " + Name;
        }

    }
}
