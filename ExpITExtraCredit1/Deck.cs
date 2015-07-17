using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpITExtraCredit1
{
    class Deck
    {
        List<Card> cardsInDeck;

        static Random rnd = new Random();

        public Deck()
        {
            cardsInDeck = new List<Card>();
            //creates a new deck with one each of the usual 52 cards in it
            for (int i = 1 ; i <= 52; i++)
            {
                cardsInDeck.Add(new Card(i));
            }
        }
        public bool isEmpty()
        {
            return (cardsInDeck.Count == 0);
        }
        public void shuffle()
        {
            if (isEmpty())     // if deck is empty, our work here is finished
            {
                return;
            }
            //It is traditional to shuffle a deck 7 times, but we will move a random card (7^2)*(current deck size) times
            for (int i = 49*cardsInDeck.Count ; i > 0 ; i--)   //counting down because it's fun
            {
                cardsInDeck.Add(dealOneRandom());
            }
        }
        private Card dealOneRandom()
        {
            if (cardsInDeck.Count < 1)  //if the deck is empty return null
            {
                return null;
            }
            int randomIndex = rnd.Next(0, cardsInDeck.Count);
            Card cardToDeal = cardsInDeck[randomIndex];
            cardsInDeck.RemoveAt(randomIndex);
            return cardToDeal;

        }
        public Card dealOne()
        {
            //removes the top (first) card from the deck and returns it
            if (cardsInDeck.Count < 1)  //if the deck is empty return null
            {
                return null;
            }
            Card cardToDeal = cardsInDeck[0];
            cardsInDeck.RemoveAt(0);
            return cardToDeal;

            //possible extension/improvement: if the class also manages a discard pile,
            //and it's not also empty, might instead reshuffle then deal
        }
        public List<Card> dealHand(int handSize)
        {
            //deals cards into a list of cards, and returns the list
            List<Card> cardsInHand = new List<Card>();
            for (int i = 0; i < handSize; i++ )
            {
                cardsInHand.Add(this.dealOne());
            }
            return cardsInHand;
        }
        public override string ToString()
        {
            if (isEmpty())
            {
                return "The deck is exhausted.";
            }
            string cardsString = "The deck contains: " + cardsInDeck[0].ToString();
            for (int i = 1; i < cardsInDeck.Count; i++)
            {
                cardsString = cardsString + ", " + cardsInDeck[i].ToString();
            }
            return cardsString;
        }

        //Oh, so many improvements and extensions to consider!!
    }
    
}
