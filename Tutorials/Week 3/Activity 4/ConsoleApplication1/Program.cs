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
            int start = 10;
            int end = 110;

            Console.WriteLine("{0}\t{1}\n", "KPH","MPH");

            while (start <= end)
            {
                Console.WriteLine("{0:F2}\t{1}",start * conversion, start);
                start = start + 10;
            }
            
            Console.ReadLine();

        }
    }
}
