using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_operations_on_numbers_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fahrenheit = 94;
            decimal cel = (fahrenheit - 32m) * (5m / 9m);

            Console.WriteLine("The temp is " + cel + " in celsius");

            Console.ReadLine();
        }
    }
}
