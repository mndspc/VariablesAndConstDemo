using System;


namespace BasicsOfCSharp
{
    //  This program demo how to use constants
    class ConstDemo
    {
        static void Main()
        {
            //  Const must be init.
            const double PI=3.14 ;
            //  It can not be assigned
            //PI = 3.15; //Error

            int r = 5;
            double aoc = (r*r*PI);
            Console.WriteLine($"Area of Circle={aoc}");
            Console.ReadLine();
        }
    }
}
