using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        int N = Convert.ToInt32(Console.ReadLine());


        if (N % 2 > 0)
        {
            Console.WriteLine("Weird");

        }
        else
        {
            //If N is even and in the inclusive range of 2  to 5, print Not Weird
            if (N >= 2 && N <= 5)
            {
                Console.WriteLine("Not Weird");
            }
            //If N is even and in the inclusive range of 6 to 20, print Weird
            else if (N >= 6 && N <= 20)
            {
                Console.WriteLine("Weird");
            }
            //If N is even and greater than 20, print Not Weird
            else
            {
                Console.WriteLine("Not Weird");

            }

        }
    }
}
