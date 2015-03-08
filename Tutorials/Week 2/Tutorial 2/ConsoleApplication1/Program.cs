using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Lifestyle
    {
        const int WAIST_MIN = 60;
        const int HEIGHT_MIN = 120;
        static void Main(string[] args)
        {
            // display welcome message
            //do{
            // prompt for waist measurement
            int waist = GetMeasurement("waist", WAIST_MIN);
            // prompt for height mesaurement
            int height = GetMeasurement("height", HEIGHT_MIN);
            // promt for gender
            int gender = GetGender();
            // calculate ratio from waist & height
            double ratio = calculateRatio(waist, height);
            // calculate risk category
            string risk = determineRisk(ratio, gender);
            // display output
            // retry?
            // } while (retry is true);
            // termination message
        }

        // promtp user for waist measurement
        static int GetMeasurement(string bodyMeasurement, int minValue)
        {
            // promt user for a measurement 
            Console.Write("Enter your " + bodyMeasurement + " measurement in cms: ");

            // Variables
            int measurement;
            do
            {
                // get a valid (numeric) input
                measurement = GetValidInput();
                if (measurement < minValue)
                {
                    Console.WriteLine("Error: The minimum measurement for " + bodyMeasurement + " is: " + minValue + "\nPlease re-enter a vaild: " + bodyMeasurement);
                }
            } while (measurement < minValue);

            return measurement;
        }

        static int GetValidInput()
        {
            int validInteger = 0;
            bool isValidValue = true;
            do
            {
                // read input
                string inputString = Console.ReadLine();

                // parse into to an int
                isValidValue = int.TryParse(inputString, out validInteger);

                // if invalid input - output an error message
                if (!isValidValue)
                {
                    Console.WriteLine("Error: Please enter an integer.");
                }
            } while (!isValidValue);

            return validInteger;
        }

        static int GetGender()
        {
            // promt user for a gender
            Console.Write("Are you: \n\t 1) Male \n\t 2) Female \n\n\t enter your option<1 or 2>: ");
            int gender = 0;
            bool isValidValue = true;
            bool isValidInput = true;
            do
            {
                string inputString = Console.ReadLine();

                // parse into to an int
                isValidValue = int.TryParse(inputString, out gender);

                // if invalid input - output an error message
                if (!isValidValue)
                {
                    Console.WriteLine("Error: Please enter an integer.");

                }

                isValidInput = (gender.Equals(1) | gender.Equals(2));

                if (!isValidInput)
                {
                    Console.WriteLine("Error: Please enter either 1 or 2.");
                    isValidValue = false;
                }
            } while (!isValidValue);

            return gender;
        }

        static double calculateRatio(int waist, int height)
        {
            double ratio = 0;
            // Convert to a double
            // Calculate the ratio - equation
            return ratio;
        }

        static string determineRisk(double ratio, int gender)
        {
            string risk = "";
            // determine risk level from ratio and gender
            return risk;
        }
    }
}
