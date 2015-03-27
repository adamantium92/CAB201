using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Advanced_Gold_Lotto_Checker {
    class Program {

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

            // Generate 6 unique random numbers between 1 and 45 for each lottoNumbers            
            int[][] GeneratedLottoNumbers = GenerateLottoGames(lottoNumbers);

            // Generate 8 unique random numbers between 1 and 45 for drawNumbers
            int[] GeneratedDrawNumbers = GenerateGameNumbers(drawNumbers.Length);


            // Display welcome message
            DisplayWelcomeMessage();

            // Display lotto numbers
            DisplayLottoNumbers(GeneratedLottoNumbers);

            // Display draw numbers
            DisplayDrawNumbers(GeneratedDrawNumbers);

            // Find and display winning and supplementary numbers
            FindWinningNumbers(GeneratedDrawNumbers, GeneratedLottoNumbers);

            // Execute existing code

            ExitProgram();
        }//end Main

        static int[][] GenerateLottoGames(int[][] lottoGames)
        {
            int[][] generatedLottoGames = new int[lottoGames.Length][];

            for (int i = 0; i < lottoGames.Length; i++)
            {
                generatedLottoGames[i] = GenerateGameNumbers(lottoGames[i].Length);
            }//end DipslayNumbers

            return generatedLottoGames;
        }

      

        static int[] GenerateGameNumbers(int numberSize)
        {
            int[] generatedLottoNumbers = new int[numberSize];
           
            for (int i = 0; i < numberSize; i++)
            {
                int uniqueNumber = randomGen.Next(1, 46);
                generatedLottoNumbers[i] = uniqueNumber;
            }//end DipslayNumbers

            generatedLottoNumbers = ReplaceDuplicates(generatedLottoNumbers);

            return generatedLottoNumbers;
        }

       static int[] ReplaceDuplicates(int[] gameNumbers)
        {            
            // Find the first element
            // Search each element in the array 
            // If no match repeat until everything has been searched
            // If match return true
            for (int i = 0; i < gameNumbers.Length; i++)
            {
                for (int j = i + 1; j < gameNumbers.Length; j++)
                {
                    if (gameNumbers[j] == gameNumbers[i])
                    {
                        int uniqueNumber = randomGen.Next(1, 46);
                        gameNumbers[i] = uniqueNumber;
                        ReplaceDuplicates(gameNumbers);
                    }
                }
            }

            return gameNumbers;

        } //end FindDuplicates

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

        static void FindWinningNumbers(int[] drawNumbers, int[][] lottoNumbers)
        {
            // Find winning numbers in drawNumbers
            int[] winningNumbers = FindWinNumbers(drawNumbers, 6);
            // Find supplementary numbers in drawNumbers
            int[] suppNumbers = FindSuppNumbers(drawNumbers, 2);
            // Find winning and supplementary for each lottoNumbers
            DisplayMatchNumbers(lottoNumbers, winningNumbers, suppNumbers);

        }//end DisplayDrawArray

        static int[] FindWinNumbers(int[] numbers, int position)
        {
            // int winningPosition = 5;
            // int winningSupp = 0;
            int[] suppNumbers = new int[position];

            for (int i = 0; i < position; i++)
            {
                suppNumbers[i] = numbers[i];
                //Console.Write("{0,4}", numbers[i]);

            }

            return suppNumbers;
        }

        static int[] FindSuppNumbers(int[] numbers, int position)
        {
            // int winningPosition = 5;
            // int winningSupp = 0;
            int[] suppNumbers = new int[position];

            for (int i = 0; i < position; i++)
            {
                suppNumbers[i] = numbers[numbers.Length - position + i];
                //Console.Write("{0,4}", numbers[i]);

            }

            return suppNumbers;
        }

        static void DisplayMatchNumbers(int[][] lottoNumbers, int[] winningNumbers, int[] suppNumbers)
        {
            // for each array(game) in lottoNumbers, search for winning numbers, search for supp numbers

            // For each game
            for (int i = 0; i < lottoNumbers.Length; i++)
            {
                // search for winning numbers
                int countWinNumbers = MatchNumbers(lottoNumbers[i], winningNumbers);
                // search for supp numbers
                int countSuppNumbers = MatchNumbers(lottoNumbers[i], suppNumbers);
                // Output the results
                Console.Write("\n\nfound " + countWinNumbers + " winning numbers and " + countSuppNumbers + " supplementary numbers in Game: " + (i + 1));
            }//end DipslayNumbers

        }

        static int MatchNumbers(int[] game, int[] numbers)
        {
            int countMatchedNumbers = 0;
            // int winningPosition = 5;
            // int winningSupp = 0;


            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < game.Length; j++)
                {
                    if (numbers[i] == game[j])
                    {
                        countMatchedNumbers += 1;
                    }
                }
            }

            return countMatchedNumbers;
        }

        static void ExitProgram() {
            Console.Write("\n\nPress any key to exit program: ");
            Console.ReadKey();
        }//end ExitProgram

    } //end class Program
}
