using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            Week week = new Week();
            foreach(var day in week)
            {
                Console.WriteLine(day);
            }
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            VladNumerable<string> vladNumerable = new VladNumerable<string>(days);
            while (vladNumerable.MoveNext())
            {
                var current = vladNumerable.Current;
                Console.WriteLine(current);
            }
            vladNumerable.Reset();
            Console.ReadKey();
        }
    }
}
