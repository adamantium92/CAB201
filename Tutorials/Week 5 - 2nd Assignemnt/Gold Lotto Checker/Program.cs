﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gold_Lotto_Checker
{

    class Program
    {

        static void Main()
        {
            const int NUMBER_OF_ROWS = 9;

            int[][] lottoNumbers ={ 
                             new int [] { 4, 7, 19, 23, 28, 36},
                             new int [] { 14, 18, 26, 34, 38, 45},
                             new int [] { 8, 10,11, 19, 28, 30},
                             new int [] {15, 17, 19, 24, 43, 44},
                             new int [] { 10, 27, 29, 30, 32, 41},
                             new int [] {9, 13, 26, 32, 37,  43},
                             new int [] {1, 3, 25, 27, 35, 41},
                             new int [] {7, 9, 17, 26, 28, 44},
                             new int [] {17, 18, 20, 28, 33, 38}
                              };

            int[] drawNumbers = new int[] { 44, 9, 17, 43, 26, 7, 28, 19 };

            // Display welcome message
            DisplayWelcomeMessage();

            // Display lotto numbers
            DisplayLottoNumbers(lottoNumbers);

            // Display lotto draw numbers
            DisplayDrawNumbers(drawNumbers);

            // Find and display winning and supplementary numbers



            ExitProgram();
        }//end Main

        static void DisplayWelcomeMessage()
        {
            Console.Write("{0,6}\n\n", "Welcome to Lotto Checker!");

        } //end DisplayWelcomeMessage

        static void DisplayLottoNumbers(int[][] numbers)
        {
            Console.Write("Your lotto numbers are:\n\n");
            for (int i = 0; i < numbers.Length; i++)
            {
                //DisplayNumbers(numbers[i]);
                Console.Write("{0}{1,-2}\n\n", "Game " + (i + 1) + ": ", DisplayNumbers(numbers[i]));
                //Console.Write("{0,1}\n", "Game " + (i + 1) + ":", numbers[i][j]);
            }
        }//end DisplayLottoNumbers

        static void DisplayDrawNumbers(int[] numbers)
        {
            Console.Write("\n\n\nLotto draw numbers are:\n\n");
            Console.Write("{0,-4}", " " + DisplayNumbers(numbers));
        }//end DisplayDrawArray

        static string DisplayNumbers(int[] numbers)
        {
            string number = "";

            for (int i = 0; i < numbers.Length; i++)
            {
                number += numbers[i] + " ";
                //Console.Write("{0,4}", numbers[i]);
            }//end DipslayNumbers

            return number;
        }

        static void ExitProgram()
        {
            Console.Write("\n\nPress any key to exit program: ");
            Console.ReadKey();
        }//end ExitProgram


    } //end class Program
}