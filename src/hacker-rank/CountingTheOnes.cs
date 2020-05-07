using System;
using System.Text;

namespace HackerRank
{
    public static class MyExtensions
    {
        public static StringBuilder ToBinary(this int n)
        {
            StringBuilder sb = new StringBuilder();
            while (n > 0)
            {
                var r = n % 2;
                sb.Append(r);
                n = n / 2;
            }
            return sb;
        }

        public static int CountSequenceOfOnes(this string s)
        {
            int eyes = 0;
            int biggerEyes = 0;
            foreach (char c in s)
            {
                if (c == '1')
                {
                    eyes++;
                    if (eyes > biggerEyes)
                        biggerEyes = eyes;
                }
                else
                {
                    if (eyes > biggerEyes)
                        biggerEyes = eyes;
                    eyes = 0;
                }
            }
            return biggerEyes;
        }
    }
    public static class CountingTheOnes
    {

        // static void Main(string[] args)
        // {
        //     int n = Convert.ToInt32(Console.ReadLine());
        //     Console.WriteLine(n.ToBinary().ToString().CountSequenceOfOnes());
        // }
    }
}