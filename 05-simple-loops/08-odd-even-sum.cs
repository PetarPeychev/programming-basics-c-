using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Loops_Exercises
{
    class OddEvenSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int evenSum = 0;
            int oddSum = 0;

            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                    evenSum += int.Parse(Console.ReadLine());
                else if (i % 2 != 0)
                    oddSum += int.Parse(Console.ReadLine());
            }

            if (evenSum == oddSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + evenSum);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = ");
                Console.Write(Math.Abs(evenSum - oddSum));
            }
        }
    }
}
