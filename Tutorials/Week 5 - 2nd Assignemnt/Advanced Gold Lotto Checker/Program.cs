using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Advanced_Gold_Lotto_Checker {
    class Program {
       
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

                       

            ExitProgram();
        }//end Main

       

        static void ExitProgram() {
            Console.Write("\n\nPress any key to exit program: ");
            Console.ReadKey();
        }//end ExitProgram

    } //end class Program
}
