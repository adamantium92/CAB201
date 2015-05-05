using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Convertor_GUI {
    /*
    * Converts one currency to another using a GUI.
    * User can select current currency, the currency they want and the amount they want converted.
    * The converted amount will then be displayed, with the option to repeat or close.
    * All exchange rates used equal one Australian dollar.
    * 
    *  Author: Adam Gibbon, 8090190
    *  Date: April 2015
    *  
    */

    enum Currencies {AUD, CYN, DKK, EUR, INR, NZD, AED, UKP, USD, VND};

    static class Currency_Exchange{
        private static double[] xRates = {1, 4.2681, 5.0844, 0.6849, 43.5921, 0.9705, 2.7094, 0.4963, 0.7382, 19115.5547};

        /* Converts currencies based on which country codes are used
       * 
       * Precondition: User selected their current currency, their desired currency and entered the amount the was converted
       * postcondition: Returns the converted amount as a double
       */
        public static double currencyConversion(double currentAmount, string currentCurrency, string desiredCurrency){

            // Used for conversions outside Australia
            string codeAUD = Currencies.AUD.ToString();
            
            // Check for the same currency
           if (currentCurrency == desiredCurrency)
           {
               // Return the amount the user entered
               return currentAmount;
           }
            // Check if either currency is AUD
           else if (currentCurrency == codeAUD | desiredCurrency == codeAUD)
           {
               return calcXRate(currentAmount, currentCurrency, desiredCurrency);
           }
           else
           {
               // First convert to AUD
               double convertToAUD = calcXRate(currentAmount, currentCurrency, codeAUD);

               // Convert to desired currency
               return calcXRate(convertToAUD, codeAUD, desiredCurrency);
           }
        }

        /* Calculates the converted currency using the corresponding exchange rates
       * 
       * Precondition: currentCode and desiredCode are not equal
       * postcondition: Returns the calcuated currency/ desiredAmount
       */
        private static double calcXRate(double currentAmount, string currentCode, string desiredCode)
        {
            // Find the exchange rates for both currencies
            double currentXRate = xRates[findCurrencyPosition(currentCode)];
            double desiredXRate = xRates[findCurrencyPosition(desiredCode)];

            // Insert the values into the equation
            double desiredAmount = (currentAmount / currentXRate) * desiredXRate;

            return desiredAmount;
        }

        /* Find the exchange rate corresponding to the country code
       * 
       * Precondition: None
       * postcondition: Returns the index value in xRates for a currency code
       */
        private static int findCurrencyPosition(string currencyCode){
           
            // Stores the position of the xrate of the currency
            int position = 0;
            
            // Store all values (currency codes) in Enum in a string array
            string[] currencyCodes = Enum.GetNames(typeof(Currencies));

            // Loop through each currency code in the string array
            foreach (string code in currencyCodes)
            {
                // Search for a match
                if (code == currencyCode)
                {
                   // Once a match is found return the position
                    return position;
                }
                else
                {
                    // Increase the index value (position)
                    position++;
                }
            } // End foreach loop
           
            return 0;
        }
    }//end class
}//end namespace
