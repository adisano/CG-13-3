using System;
using System.Collections.Generic;
using System.Text;

namespace ClassEnum
{
    class Student
    {
        public enum FirstName
        {
            bob,
            bill,
            amy,
            omar,
            gregory,
            quenton,
            priscilla,
            frank,
            bianca,
            lulu,
            first
        }

        public void LastNames(FirstName firstname)
        {

            switch (firstname)
            {
                case FirstName.bob:
                    Console.WriteLine("Smith");
                    break;
                case FirstName.bill:
                    Console.WriteLine("Jones");
                    break;
                case FirstName.amy:
                    Console.WriteLine("Jones");
                    break;
                case FirstName.omar:
                    Console.WriteLine("Bird");
                    break;
                case FirstName.gregory:
                    Console.WriteLine("Reed");
                    break;
                case FirstName.quenton:
                    Console.WriteLine("Bartle");
                    break;
                case FirstName.priscilla:
                    Console.WriteLine("White");
                    break;
                case FirstName.bianca:
                    Console.WriteLine("Marie");
                    break;
                case FirstName.lulu:
                    Console.WriteLine("Park");
                    break;
                default:
                    Console.WriteLine("Name not recognized. Programmer's note: I am using a list of random names.");
                    break;
            }
        }

    }
}
