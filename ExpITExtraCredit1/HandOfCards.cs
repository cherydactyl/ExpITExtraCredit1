using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpITExtraCredit1
{
    class HandOfCards
    {
        int handSizeLimit { get; set; }       //hand limit  (interpret -1 as no limit), may be malleable
        List<Card> cardsInHand;               //list of cards currently in the hand

        //default constructor starts with an empty hand and assumes there is no hand limit
        public HandOfCards()
        {
            handSizeLimit = -1;
            cardsInHand = new List<Card>();
        }
        //This constructor takes a specified hamd limit, instead of assuming it is infinite/no limit
        public HandOfCards(int sl)
        {
            handSizeLimit = sl;
            cardsInHand = new List<Card>();
        }
        //this constructor takes (and adopts) a starting hand, and an optional size limit specification
        public HandOfCards(List<Card> startingHand, int sl = -1)
        {
            //note this does no checking that the intial hand actually meets the hand limit if it exists!
            handSizeLimit = sl;
            cardsInHand = startingHand;
        }
        //accept a card into the hand, unless the hand is already full
        public Card beDealt(Card c)
        {
            if (!isFull())
            {
                cardsInHand.Add(c);
                return null;    //no card to return; it was added to the hand
            }
            return c;       //return the card if it was NOT added to hand
        }
        //is the hand empty (contains no cards)?
        public bool isEmpty()
        {
            return (cardsInHand.Count == 0);
        }
        //is the hand already full (at limit)?
        public bool isFull()
        {
            //the hand is full if and only if the number of cards in hand is the same as the hand size limit
            //note that a had with hand size limit of -1/no limit is never full
            return (cardsInHand.Count == handSizeLimit);
        }
        public int currentHandSize()
        {
            return cardsInHand.Count;
        }
        public override string ToString()
        {
            if (isEmpty())
            {
                return "Empty hand";
            }
            string cardsString = "The hand contains: " + cardsInHand[0].ToString();
            for (int i = 1; i < cardsInHand.Count; i++)
            {
                cardsString = cardsString + ", " + cardsInHand[i].ToString();
            }
            return cardsString;
        }
        //currently does not handle removal of cards from hand (e.g. play or discard)
    }
}
