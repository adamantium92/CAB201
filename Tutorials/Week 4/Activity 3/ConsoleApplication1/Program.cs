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
            int[] numbersDuplicate = {1, 1, 2, 8, 6, 7, 8, 9, 10, 6, 11};
            int[] numbers = {1, 2, 3, 8, 6, 7, 10};
            DisplayArray(numbers);
            Console.WriteLine("Does the array contain duplicates? " + FindDuplicates(numbers));
            DisplayArray(numbersDuplicate);
            Console.WriteLine("Does the array contain duplicates? " + FindDuplicates(numbersDuplicate));
            Console.ReadLine();
        }

        static bool FindDuplicates(int[] numbers) {
            
            // Find the first element
            // Search each element in the array 
            // If no match repeat until everything has been searched
            // If match return true
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length - 1; j++)
                {
                    if (numbers[i] == numbers[j]) return true;
                }
            }

            return false;
           
        } //end FindDuplicates

        static void DisplayArray(int[] numbers)
        {

            foreach (int element in numbers)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();

        }//end DisplayArray
}
}