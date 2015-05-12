using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Define the basic Game Objects which will be used in the actual Game logic Class
 * 
 * Create
 * - Card Class: represents a playing card that has a face value(Ace, King, Queen etc) and a suit value (Clubs, idamond, hearts and spades)
 

*/

namespace Shared_Game_Class_Library
{
    public enum Suit { Clubs, Diamonds, Hearts, Spades }
    public enum FaceValue
    {
        Two, Three, Four, Five, Six, Seven, Eight, Nine,
        Ten, Jack, Queen, King, Ace
    }

    public class Card : IEquatable<Card>, IComparable<Card> {

        /*
        public Card{
         }

         public Card(Suit, FaceValue)
         {
         }
        */
         public String GetFaceValue{
             // Take a card number and find the corresponding face value
             // Return (FaceValue)  
            
            get {
                // Assume I have to get the number of the card
                return FaceValue.Ace.ToString();
            }
            set {
                if (value == "") {
                    
                } else {
                    throw new ArgumentOutOfRangeException("Number of sales: ", value, "sales must be greater than 0");
                }
            }
         }  
    

    public GetFaceSuit{
             return Suit; 
         } 

    public equals(card){
             return boolean; 
         } 

    public CompareTo(Card){
         } 
  
    }

   
}
