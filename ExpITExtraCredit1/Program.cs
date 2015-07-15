﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpITExtraCredit1
{
    class Program
    {
        static void waitForUser()
        {
            //generic helper function to wait for the user to be ready to continue;
            Console.WriteLine();    //whitespace
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.WriteLine();    //whitespace
        }
        static void harmonicSum()
        {
            //Exercise 1: Harmonic Sum
            //Write a program to compute the sum of a harmonic series, as shown below, where n=50000.
            //Calculate the sum from left-to-right, and then from right-to-left.
            //Harmonic(n) = 1 + 1/2 + 1/3 + 1/4 + .... + 1/n
            Console.WriteLine("Harmonic sum calculation");
            Console.WriteLine();    //whitespace
            double hSum = 0;    //initialize harmonic sum keeper variable
            int n = 50000;      //hardcoded n value, for ease of editing/debuging

            //step through intergers from 1 to 50000 and add that number ^ -1 to the sum
            for (int i = 1; i <= n; i++)
            {
                hSum += Math.Pow(i, -1);
            }
            Console.WriteLine("The harmonic sum 1 + 1/2 + 1/3 + 1/4 + .... + 1/n,");
            Console.WriteLine("for n=" + n + " is " + hSum + " when calculated left to right.");

            hSum = 0;   //reset harmonic sum keeper variable
            //step through intergers from 50000 to 1 and add that number ^ -1 to the sum
            for (int i = n; i > 0; i--)
            {
                hSum += Math.Pow(i, -1);
            }
            Console.WriteLine("The harmonic sum 1 + 1/2 + 1/3 + 1/4 + .... + 1/n,");
            Console.WriteLine("for n=" + n + " is " + hSum + " when calculated right to left.");
            Console.WriteLine();    //whitespace
            Console.WriteLine("Although there appears to be no difference for calculation\nleft-to-right vs right-to-left for n=50000,");
            Console.WriteLine("there does appear to be a difference for n=500000.");
            Console.WriteLine("Such differences are attirbutable to overflow errors in the");
            Console.WriteLine("hamonic sum tracking variable, which manifest as rounding errors.");
        }
        static void sumEvenFib ()
        {
            //Exercise 2: Fibbonacci Sequence
            //Each new term in the Fibonacci sequence is generated by adding the previous two terms.
            //By starting with 1 and 2, the first 10 terms will be:
            //1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
            //By considering the terms in the Fibonacci sequence whose values do not exceed four million,
            //find the sum of the even-valued terms.

            int fib1 = 1;           //seeding the Fibbonacci sequence
            int fib2 = 1;
            int fib3 = fib1 + fib2;

            //I wondered if an int was big enough/a long would be needed, but on testing it appeared int was sufficient!
            //Console.WriteLine("Reminder, int max value is " + Int32.MaxValue);
            int partialSum = 0;

            while (fib2 < 4000000)  //while the active (middle) Fibbonacci number is under 4 million
            {
                if (fib2 % 2 == 0)  //if the active (middle) Fibbonacci number is even
                {
                    //add it to sum
                    partialSum += fib2;
                }

                //roll the sequence forward a notch so we can do it again!
                fib1 = fib2;
                fib2 = fib3;
                fib3 = fib1 + fib2;
            }
            Console.WriteLine("The sum of even Fibbonacci numbers valued under 4 million is " + partialSum);

            //I noticed this was a projecteuler.net archive problem (#2), and submitted the answer there
            //It was correct!
            //Additionally, I earned the "babysteps" award when I entered the solution.  Much appreciated!
        }

        static void multipicationTable()
        {
            //iterate through one operand
            for (int i = 1; i < 10; i++)
            {
                //iterate through the other operand
                for (int j = 1; j < 10; j++)
                {
                    //write the product, followed by a space
                    //last trailing space won't matter
                    Console.Write((i * j) + " ");
                }
                //end of the table row
                Console.WriteLine();
            }
        }
        static void shuffleAndDeal()
        {
            //Exercise 1: Shuffle Cards
            //Write a program to create a standard 52 card deck and then deal a random hand to a player.
            //Once a card is dealt then it can't be used again.

            //create a new deck (instance of class Deck)

            //shuffle it

            //create a player hand, dealing off the deck

        }


        static void Main(string[] args)
        {
            //Running in Circles (Loops)
            //Exercise 1: Harmonic Sum
            harmonicSum();      //solution in separate function, above
            waitForUser();
            
            //Exercise 2: Fibbonacci Sequence
            sumEvenFib();       //solution in separate function, above
            waitForUser();

            //Exercise 3: Multiplication Tables
            multipicationTable();
            waitForUser();


            //Arrays, Lists, and Dictionaries, Oh My!
            //Exercise 1: Shuffle Cards
            shuffleAndDeal();
        }        
    }
}
