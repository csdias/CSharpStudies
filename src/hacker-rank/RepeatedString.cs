using System;

namespace hackerRank
{
    public static class RepeatedString
    {

        static void Main(string[] args)
        {
            var result = repeatedString("aba", 10);

            Console.WriteLine(result);
        }

        // Complete the repeatedString function below.
        static long repeatedString(string s, long n)
        {
            long size = s.Length;
            long ass = 0;
            for (var x = 0; x <= size - 1; x++)
            {
                if (s[x] == 'a')
                    ass++;
            }

            long remaining = n % size;

            ass = (n / size) * ass;

            for (var y = 0; y <= remaining; y++)
            {
                if (s[y] == 'a')
                    ass++;

            }
            return ass;
        }
    }


}
