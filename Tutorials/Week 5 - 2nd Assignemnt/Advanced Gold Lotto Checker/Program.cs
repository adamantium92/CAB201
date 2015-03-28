using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Advanced_Gold_Lotto_Checker {
   /*
    * Simulates a round of gold lotto by creating both games and draw numbers
    * Generates X games (Length of lottoNumbers - 12) each game containing  6 random numbers between 1 and 45
    * Displays both games and draw numbers
    * Then displays how many winning and supplementary numbers for each game 
    *
    * 
    *  Author: Adam Gibbon, 8090190
    *  Date: March 2015
    *  
    */

    class Program {
        // Constant variables
        const int LOTTO_MIN = 1;
        const int LOTTO_MAX = 45;
        const int WIN_NUM = 6;
        const int SUPP_NUM = 2;
        static Random randomGen = new Random();
       
        static void Main() {
        
            const int NUMBER_OF_ROWS = 12;

            int[][] lottoNumbers ={ 
                             new int [6],
                             new int [6],
                             new int [6],
                             new int [6],
                             new int [6],
                             new int [6],
                             new int [6],
                             new int [6],
                             new int [6],
                             new int [6],
                             new int [6],
                             new int [6] 
                              };

            int[] drawNumbers = new int[8];

            // Populate each game in lottoNumbers with an array containing 6 random unique numbers            
            lottoNumbers = GenerateLottoGames(lottoNumbers);

            // Generate 8 unique random numbers
            drawNumbers = GenerateUniqueNumber(drawNumbers, drawNumbers[0]);

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

        static int[][] GenerateLottoGames(int[][] lottoGames) {
            for (int i = 0; i < lottoGames.Length; i++) {
                
                // For each game in lottoGames generate 6 random unique numbers
                lottoGames[i] = GenerateUniqueNumber(lottoGames[i], lottoGames[i][0]);
            } //end generation of numbers for each lotto game
         
            return lottoGames;
        } //end GenerateLottoGames

       static int[] GenerateUniqueNumber(int[] gameNumbers, int position) {            
           
           // Start at the specified position in the array
           for (int i = position; i < gameNumbers.Length; i++) {
               
               // Generate a random number for the position
                gameNumbers[i] = randomGen.Next(LOTTO_MIN, LOTTO_MAX + 1);

                for (int j = 0; j < gameNumbers.Length; j++) {
                    
                    // Check if the generated number already exists in teh array
                    if ((gameNumbers[i] == gameNumbers[j]) && j != i) {
                        
                        // If a duplicate is found, restart the processes from the current position
                        GenerateUniqueNumber(gameNumbers, i);
                    }             
                }
            }
            
           return gameNumbers;
        } //end GenerateUniqueNumber

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

        static string DisplayNumbers(int[] numbers){
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
            }
            else {
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

        static void ExitProgram() {
            
            Console.Write("\n\nPress any key to exit program: ");
            Console.ReadKey();
        }//end ExitProgram

    } //end class Program
}
