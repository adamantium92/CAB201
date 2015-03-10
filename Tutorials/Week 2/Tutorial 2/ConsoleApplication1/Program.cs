using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WTH_Calculator
{
    /*
    * Calculates waist to height ratio.
    * From the same units of measurement used for the waist and height.
    * Then determines the users risk based on the gender and ratio. 
    * User will then be prompted if they wish to repeat the calculation.
    * 
    *  Author: Adam Gibbon, 8090190
    *  Date: March 2015
    *  
    */

    class Lifestyle
    {
        // Constant variables
        const int WAIST_MIN = 60;
        const int HEIGHT_MIN = 120;
        const double MALE_RISK = 0.536;
        const double FEMALE_RISK = 0.492;

        static void Main(string[] args)
        {
            // Display welcome message
            DisplayWelcomeMessage();
           
            // Begin calculation process, repeat if answer is y(yes)
            do
            {
                // Prompt for waist measurement
                int waist = GetMeasurement("waist", WAIST_MIN);
                // Prompt for height mesaurement
                int height = GetMeasurement("height", HEIGHT_MIN);
                // Prompt for gender
                int gender = GetGender();
                // Calculate wasit to height ratio
                double ratio = CalculateRatio(waist, height);
                // Calculate risk category
                DetermineRisk(ratio, gender, MALE_RISK, FEMALE_RISK);   
            } while (RepeatMessage());
            
            // Termination message
            DisplayTerminationMessage();
        }
       
        static void DisplayWelcomeMessage()
        {
            // promt user for a measurement 
            Console.Write("\t\t Welcome to Waist to Height Ratio Caclulator.\n");
        }

        static int GetMeasurement(string bodyMeasurement, int minValue)
        {
            // Variables
            int measurement = 0;

            // promt user for a measurement 
            Console.Write("\n\nEnter your " + bodyMeasurement + " measurement in cms: ");

            do
            {
                // get a valid (numeric) input
                measurement = GetValidIntInput();
                if (measurement < minValue)
                {
                    Console.WriteLine("Error: The minimum measurement for " + bodyMeasurement + " is: " + minValue + "\nPlease re-enter a vaild: " + bodyMeasurement + " in cms");
                }
            } while (measurement < minValue);

            return measurement;
        }

        static int GetValidIntInput()
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
                    Console.WriteLine("Error (Invalid Input): Please enter an integer.");
                }
            } while (!isValidValue);

            return validInteger;
        }

        static int GetGender()
        {
            int gender = 0;
            bool isValidValue = true;
            
            // promt user for a gender
            Console.Write("\n\nAre you: \n\t 1) Male \n\t 2) Female \n\n\t enter your option<1 or 2>: ");
            
            do
            {
                string inputString = Console.ReadLine();

                // Convert the input into an int
                int.TryParse(inputString, out gender);
               
                // Check if input is a 1 or 2
                isValidValue = (gender.Equals(1) | gender.Equals(2));

                // If false - output an error message
                if (!isValidValue)
                {
                    Console.WriteLine("Error (Invalid input): Please indicate yor gender \n be entering either 1 (male) or 2 (female).");
                }
            } while (!isValidValue);

            return gender;
        }

        static double CalculateRatio(int waist, int height)
        {
            double ratio = 0.0;

            // Convert int inputs to a double
            double convertedWaist = Convert.ToDouble(waist);
            double convertedHeight = Convert.ToDouble(height);


            // Calculate the ratio - waist/ height
            ratio = convertedWaist / convertedHeight;

            // Display the ratio
            Console.WriteLine("\n\nYour waist to height ratio is: " + ratio.ToString("N3"));

            return ratio;
        }

        static void DetermineRisk(double ratio, int gender, double maleRisk, double femaleRisk)
        {
            double riskLevel = 0.0;

            // Determine the risk level from the gender
            if (gender.Equals(1))
            {
                riskLevel = maleRisk;
            }
            else
            {
                riskLevel = femaleRisk;
            }

            // Determine the level of risk
            if (ratio >= riskLevel)
            {
                // Display  high risk
                Console.WriteLine("\n\n Which indicates that you are at high risk \n of developing obesity related cardiovascular diseases.");
            }
            else
            {
                // Display low  risk
                Console.WriteLine("\n\n Which indicates that you are at low risk \n of developing obesity related cardiovascular diseases.");
            }
        }

        static bool RepeatMessage()
        {
            bool answer = true;
            bool isValidValue = true;

            // Ask user if they wish to repeat the calculation
            Console.Write("\n\nWould you like to repeat the calculation? <Enter Y or N>: ");
          
            do
            {
                string inputString = Console.ReadLine();

                // Conver input to lowercase
                inputString = inputString.ToLower();

                // Check if input is a y or n
                isValidValue = (inputString.Equals("y") | inputString.Equals("n"));

                // If false - output an error message
                if (!isValidValue)
                {
                    Console.WriteLine("Error (Invalid input): Please enter either Y or N.");
                }

                // Determine whether the user wishes to repeat or not
                if (inputString.Equals("y"))
                {
                    answer = true;
                }
                else
                {
                    answer = false;
                }

            } while (!isValidValue);

            return answer;
        }

        static void DisplayTerminationMessage()
        {
            // promt user for a measurement 
            Console.Write("\n\n Press any key to terminat program...");
            Console.ReadKey();
        }
    }
}
