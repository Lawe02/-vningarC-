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
            var today = DateTime.Now.ToString("yyyyMMdd");
            string date = "";
            Console.Write("År : ");
            date += Console.ReadLine();
            Console.Write("Månad i formatet mm: ");
            date += Console.ReadLine();
            Console.Write("Dag i formatet dd: ");
            date += Console.ReadLine();

            if (date == today)
                Console.WriteLine("Detta är idag");
            else
                Console.WriteLine("Detta är inte idag");
        }
    }
}
