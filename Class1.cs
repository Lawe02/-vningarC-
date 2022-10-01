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
            var sv = new CultureInfo("sv-SV");
            var dt = DateTime.Now;
            
            Console.WriteLine($"Idag är det {dt.ToString("dddd dd MMMM yyyy", sv)}");

            Console.WriteLine($"Hur många dagar vill du lägga till");
            int days = int.Parse(Console.ReadLine());
            dt = dt.AddDays(days);
            Console.WriteLine($"Om {days} dagar är det {dt.ToString("dddd dd MMMM yyyy")}");
        }
         
    }
}
