using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gold_Lotto_Checker
{
    /*
     * Displays both games and draw numbers
     * Then displays how many winning and supplementary numbers for each game 
     * 
     *  Author: Adam Gibbon, 8090190
     *  Date: March 2015
     *  
     */

    class Program
    {
        // Constant variables
        const int LOTTO_MIN = 1;
        const int LOTTO_MAX = 45;
        const int WIN_NUM = 6;
        const int SUPP_NUM = 2;

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
            DisplayMessage("Welcome to Lotto Checker");

            // Display each lotto games' numbers
            DisplayLottoNumbers(lottoNumbers);

            // Display draw numbers
            DisplayDrawNumbers(drawNumbers);

            // Find winning numbers in drawNumbers
            int[] winningNumbers = FindWinOrSuppNumbers(drawNumbers, WIN_NUM, true);

            // Find supplementary numbers in drawNumbers
            int[] suppNumbers = FindWinOrSuppNumbers(drawNumbers, SUPP_NUM, false);

            // Find each winning and supplementary number in each lottoNumbers game
            DisplayMatchNumbers(lottoNumbers, winningNumbers, suppNumbers);

            // Display goodbye message
            DisplayMessage("Thanks for using Lotto Checker");

            ExitProgram();
        }//end Main

        static void DisplayMessage(string message) {
            // Display the message passed in
            Console.Write("\n\n{0, 40}\n\n\n\n\n", message);
        }//end DisplayMessage

        static void DisplayLottoNumbers(int[][] lottoNumbers) {        
            Console.Write("Your lotto numbers are:\n\n");

            // Display each game in lottoNumbers
            for (int i = 0; i < lottoNumbers.Length; i++) {
                // Sort the array from smallest to largest
                Array.Sort(lottoNumbers[i]);

                // Pass in each game array to return a string containing the numbers
                Console.Write("{0, 2}{1,4}{2,12}\n\n", "Game", (i + 1) + ":", DisplayNumbers(lottoNumbers[i]));
            }
        }//end DisplayLottoNumbers

        static void DisplayDrawNumbers(int[] numbers) {
            Console.Write("\n\n\n{0}\n\n", " Lotto draw numbers are:");

            // Pass in the draw number array to return a string containing the numbers
            Console.Write("{0}\n", DisplayNumbers(numbers));
        }//end DisplayDrawArray

        static string DisplayNumbers(int[] numbers) {
            string number = "";

            for (int i = 0; i < numbers.Length; i++) {
                // Loop through the array and add each value to the number varaiable
                number += String.Format("{0, 4}", numbers[i]);
            }

            return number;
        }//end DipslayNumbers

        static int[] FindWinOrSuppNumbers(int[] numbers, int position, bool type) {
            // Create an array to store the winning numbers
            int[] winOrSuppumbers = new int[position];
            int j = 0;

            // Check if searching for winning or supp numbers and assign the starting position
            if (type == true) {
                j = 0;
            } else {
                j = numbers.Length - position;
            }

            // Itterate through the numbers array adding either the first WIN_NUM (6) or last SUPP_NUM (2) 
            for (int i = 0; i < position; i++) {
                // Add the number to the array
                winOrSuppumbers[i] = numbers[j + i];
            }

            return winOrSuppumbers;
        }//end FindWinOrSuppNumbers

        static void DisplayMatchNumbers(int[][] lottoNumbers, int[] winningNumbers, int[] suppNumbers) {

            // Itterate through each game in lottoNumbers
            for (int i = 0; i < lottoNumbers.Length; i++) {
                // search for winning numbers in game i
                int countWinNumbers = MatchNumbers(lottoNumbers[i], winningNumbers);

                // search for supp numbers in game i
                int countSuppNumbers = MatchNumbers(lottoNumbers[i], suppNumbers);

                // Output the results
                Console.Write("\n\n{0, 13}{1, 1}{2, 1}{3, 1}{4, 1}{5, 1}\n\n", "found ", countWinNumbers, " winning numbers and ", countSuppNumbers, " supplementary numbers in Game: ", (i + 1));
            }
        }//end DipslayMatchNumbers

        static int MatchNumbers(int[] game, int[] winOrSuppNumbers) {
            int countMatchedNumbers = 0;

            // Itterate through each number in game
            for (int i = 0; i < winOrSuppNumbers.Length; i++) {
                // Itterate through each number in winOrSuppNumbers
                for (int j = 0; j < game.Length; j++) {
                    // Check if there is a match
                    if (winOrSuppNumbers[i] == game[j]) {
                        // Increase the count by 1 for each match
                        countMatchedNumbers += 1;
                    }
                }
            }

            return countMatchedNumbers;
        }//end MatchedNumbers

        static void ExitProgram()
        {
            Console.Write("\n\nPress any key to exit program: ");
            Console.ReadKey();
        }//end ExitProgram


    } //end class Program
}
