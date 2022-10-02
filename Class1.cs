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
            Console.WriteLine("Mata in två datum i formatet åååå-mm-dd");
            string dag1 = Console.ReadLine();
            Console.WriteLine("Mata in till datum i formatet åååå-mm-dd");
            string dag2 = Console.ReadLine();
            var time = DateTime.Parse(dag1);
            var time2 = DateTime.Parse(dag2);
            var days = (time - time2);
            Console.WriteLine(days.TotalDays);


        }
    }
}
