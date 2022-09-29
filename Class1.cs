using Newtonsoft.Json;
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
            var time = DateTime.Now;
            var shortTime = DateTime.Now.ToString("yyyy-MM-dd");
            Console.WriteLine($"Complete date: {time}");
            Console.WriteLine($"Short date: {shortTime}");
        }
    }
}
