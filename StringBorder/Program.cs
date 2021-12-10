using System;

namespace StringBorder
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = PalindromeBorders("aaaa");
            Console.WriteLine(s);
        }


        static int PalindromeBorders(string s)
        {
            var count = 0;
            for (var i = 0; i < s.Length - 1; i++)
            {
                for (int j = 2; j <= s.Length - i; j++)
                {
                    count +=  CountPalindromeBorders(s.Substring(i, j));
                }
            }

            return count;
        }

        static int CountPalindromeBorders(string s)
        {
            int count = 0;
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (s[i] == s[s.Length - 1 - i])
                {
                    count++;
                }
                else
                {
                    break;
                }
            }

            return count;
        }
    }
}