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
            string salesCode = "";
            double discount = 0.0;

            Console.Write("Enter Sales Code: ");
            salesCode = Console.ReadLine();

           // Can be done with == for a string and the &&
            if ((salesCode == "A") && (salesCode == "B"))
            {
                discount = 0.10;
            }

            Console.WriteLine("\n Discount applied is {0:F2}\n", discount);

            Console.WriteLine("Press any key to exit:");
            Console.ReadKey();

        }
    }
}
