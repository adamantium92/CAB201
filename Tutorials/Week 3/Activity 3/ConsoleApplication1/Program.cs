using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // mph to kph conversion
            double conversion = 0.62137;

            Console.WriteLine("KPH\t\tMPH\n");

            for (int i = 10; i <= 110; i += 10)
            {
                Console.WriteLine(i * conversion + "\t\t" + i);
            }

            Console.ReadLine();

        }
    }
}
