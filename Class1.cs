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
            Console.WriteLine("Mata in datum i detta format åååå-mm");
            string date = Console.ReadLine();
            string[] vs = date.Split('-');

            int days = DateTime.DaysInMonth(Convert.ToInt32(vs[0]), Convert.ToInt32(vs[1]));

            Console.WriteLine(days);
        }
         
    }
}
