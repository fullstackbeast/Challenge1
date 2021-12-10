using System;
using System.Collections.Generic;
using System.Linq;

namespace NumberState
{
    class Program
    {
        static void Main(string[] args)
        {
            SmallestSeries(12, new[] { 2, 3,4 });
        }

        static void SmallestSeries(int num, int[] factors)
        {
            //Sorting the factors to start from the biggest divisor (The biggest divisors give the smallest series)
            Array.Sort(factors);
            
            //A list of all the smallest series
            var result = new List<int>();

            //Looping through all the factors from the biggest to the smallest
            for (int i = factors.Length - 1; i >= 0; i--)
            {
                //A list to hold all possible series
                var nums = new List<int>();
                var factor = factors[i];
                if (num % factor != 0) continue;

                nums.Add(num);
                var factor1 = num / factor;
                nums.Add(factor1);

                //If the quotient is a present in the factors array, we can stop
                if (factors.Contains(factor1))
                {
                    result = nums;
                    break;
                }

                //a counter to keep track of the number of times we have to loop
                int limit = 0;
                while (!factors.Contains(factor1) && limit < factors.Length)
                {
                    for (int j = factors.Length - 1; j >= 0; j--)
                    {
                        if (factor1 % factors[j] == 0)
                        {
                            factor1 = factor1 / factors[j];
                            nums.Add(factor1);
                            limit = 0;
                            break;
                        }
                    }

                    limit++;
                }

                if (nums.Count > 0)
                {
                    result = nums;
                    break;
                }
            }

            if (result.Count == 0)
                Console.WriteLine(-1);
            else
            {
               result.Add(1);
               Console.WriteLine(string.Join(" ", result));
            }
                
        }
    }
}