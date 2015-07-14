using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpITExtraCredit1
{
    class Program
    {
        static void Main(string[] args)
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
            for (int i = 1; i <= n ; i++)
            {
                hSum += Math.Pow(i, -1) ;
            }
            Console.WriteLine("The harmonic sum 1 + 1/2 + 1/3 + 1/4 + .... + 1/n, \nfor n=" + n + " is " + hSum
                + " when calculated left to right.");

            hSum = 0;   //reset harmonic sum keeper variable
            //step through intergers from 50000 to 1 and add that number ^ -1 to the sum
            for (int i = n; i > 0; i--)
            {
                hSum += Math.Pow(i, -1) ;
            }
            Console.WriteLine("The harmonic sum 1 + 1/2 + 1/3 + 1/4 + .... + 1/n, \nfor n=" + n + " is " + hSum
                + " when calculated right to left.");
            Console.WriteLine();    //whitespace
            Console.WriteLine("Although there appears to be no difference for calculation\nleft-to-right vs right-to-left for n=50000,");
            Console.WriteLine("There does appear to be a difference for n=500000.");
            Console.WriteLine("Such differences are attirbutable to overflow errors in the");
            Console.WriteLine("\thamonic sum tracking variable, which manifest as rounding errors.");

            Console.WriteLine();    //whitespace
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();


            //Exercise 2: Fibbonacci Sequence

            //Exercise 3: Multiplication Tables

            Console.WriteLine();    //whitespace
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }
    }
}
