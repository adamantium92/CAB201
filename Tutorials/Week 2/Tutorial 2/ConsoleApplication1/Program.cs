﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WTH_Calculator
{
    /*
    * Calculates waist to height ratio 
    * as the same units of measurement is used for the waist and height.
    * Then determines the users risk based on the gender and ratio. 
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
           
            // Begin calculation process, repeat if they answer y(yes)
            do
            {
                // Prompt for waist measurement
                int waist = GetMeasurement("waist", WAIST_MIN);
                // Prompt for height mesaurement
                int height = GetMeasurement("height", HEIGHT_MIN);
                // Promt for gender
                int gender = GetGender();
                // Calculate ratio from waist & height
                double ratio = CalculateRatio(waist, height);
                // Calculate risk category
                DetermineRisk(ratio, gender, MALE_RISK, FEMALE_RISK);   
            } while (RepeatMessage());
            
            // termination message
            DisplayTerminationMessage();
        }

       
        static void DisplayWelcomeMessage()
        {
            // promt user for a measurement 
            Console.Write("\t\t Welcome to Waist to Height Ratio Caclulator.\n");
        }

        // promtp user for waist measurement
        static int GetMeasurement(string bodyMeasurement, int minValue)
        {
            // promt user for a measurement 
            Console.Write("\n\nEnter your " + bodyMeasurement + " measurement in cms: ");

            // Variables
            int measurement;
            do
            {
                // get a valid (numeric) input
                measurement = GetValidInput();
                if (measurement < minValue)
                {
                    Console.WriteLine("Error: The minimum measurement for " + bodyMeasurement + " is: " + minValue + "\nPlease re-enter a vaild: " + bodyMeasurement + " in cms");
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
            Console.Write("\n\nAre you: \n\t 1) Male \n\t 2) Female \n\n\t enter your option<1 or 2>: ");
            int gender = 0;
            bool isValidValue = true;
            do
            {
                string inputString = Console.ReadLine();

                // parse into to an int
                isValidValue = int.TryParse(inputString, out gender);

                // if input is not an int - output an error message
                if (!isValidValue)
                {
                    Console.WriteLine("Error: Please enter an integer.");
                }

                // Check if input is a 1 or 2
                isValidValue = (gender.Equals(1) | gender.Equals(2));

                // If false - output an error message
                if (!isValidValue)
                {
                    Console.WriteLine("Error: Please enter either 1 or 2.");
                }
            } while (!isValidValue);

            return gender;
        }

        static double CalculateRatio(int waist, int height)
        {
            double ratio = 0;

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
            double risk = 0.0;

            // Determine the risk number from the gender
            if (gender.Equals(1))
            {
                risk = maleRisk;
            }
            else
            {
                risk = femaleRisk;
            }

            // Determine the level of risk
            if (ratio >= risk)
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
            // Ask user if they wish to repeat the calculation
            Console.Write("\n\nWould you like to repeat the calculation? <Enter Y or N>: ");
            //string userInput = "";
            bool answer = true;
            bool isValidValue = true;
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
