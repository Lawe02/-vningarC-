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
            Console.WriteLine("Mata ín datum i formatet åååå-mm-dd");
            var dt = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(dt.Day);
        }
         
    }
}
