using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpITExtraCredit1
{
    enum cardRank { Ace = 1, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King}   //card values
    enum cardSuit { Clubs, Diamonds, Hearts, Spades }    //suits from lowest to highest, Bridge order

    class Card
    {
        int rank { get; set; }   //1 = Ace, ... 11 = Jack, 12 = Queen, 13 = King, as per enum above
        int suit { get; set; }   //as per enum above

        public Card(int serial)    //constructor by serial number (1...52); serial number = (suit * 13) + rank
        {
            //note that % is NOT MODULO in C#, it's remainder!! Therefore handling negative numbers is interesting
            while (serial < 0)      // corrects for serial numbers less than 0
            {
                serial += 52;
            }
            serial = serial % 52;    //force serial into range (actually 0 to 51, but a 0 is treated as if it is 52)
            //remainder 13 to find rank, correcting 0's to 13's
            rank = (serial % 13);
            if (rank == 0)
            {
                rank = 13;
                if (serial == 0)
                {
                    //special case for King of Spades
                    serial = 52;
                }
            }
            //subtract one and then apply integer division by 13 to find suit, eg (52 - 1)/13 -> 3: Spades
            suit = (serial - 1) / 13;
        }
        public Card(int r, int s)  //constructor by rank (1 to 13) and suit (0 to 3), as per enums above
        {
            //note that % is NOT MODULO in C#, it's remainder!! Therefore handling negative numbers is interesting

            //correct and set rank r
            while (r < 0)   // corrects for negative r
            {
                r += 13;
            }
            r = rank % 13;  //corrects for r higher than 13
            if (r == 0)
            {
                rank = 13;
            }
            rank = r;

            //correct and set suit s
            while (s < 0)      // corrects for suit numbers s less than 1
            {
                s += 4;
            }
            s = s % 4;   //corrects for suit numbers higher than 3
            suit = s;
        }
        
        public string getRankName()
        {
            switch (rank)
            {
                case 1:
                    return "Ace";
                case 2:
                    return "Two";
                case 3:
                    return "Three";
                case 4:
                    return "Four";
                case 5:
                    return "Five";
                case 6:
                    return "Six";
                case 7:
                    return "Seven";
                case 8:
                    return "Eight";
                case 9:
                    return "Nine";
                case 10:
                    return "Ten";
                case 11:
                    return "Jack";
                case 12:
                    return "Queen";
                case 13:
                    return "King";
                default:
                    return "Something went wrong.";
            }
        }
        public string getSuitName()
        {
            switch (suit)
            {
                case 0:
                    return "Clubs";
                case 1:
                    return "Diamonds";
                case 2:
                    return "Hearts";
                case 3:
                    return "Spades";
                default:
                    return "Something isn't right.";
            }
        }
        public int getSerial()
        {
            return (suit * 4) + rank;
        }
        public override string ToString()
        {
            return this.getRankName() + " of " + this.getSuitName();
        }
        public void Print()
        {
            Console.Write(this.ToString());
        }
    //possible extensions:
    //-> get point amounts for cards, e.g., penalty points for left-in-hand as in some games, e.g. rummies, 
        //crazy-8s/Uno-like, etc.
    //-> various kinds of comparison, e.g. create comparison method for War or simple case (single cards)
        //for Poker, or trick taking games like Bridge (possibly requires trump suit as argument?)
    }
}
