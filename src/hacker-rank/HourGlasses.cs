using System;

namespace hackerRank
{
    public static class HourGlasses
    {

        static void Main(string[] args)
        {
            int[][] arr = new int[6][];

            //arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            arr[0] = new int[6] { -1, -1, 0, -9, -2, -2 };
            arr[1] = new int[6] { -2, -1, -6, -8, -2, -5 };
            arr[2] = new int[6] { -1, -1, -1, -2, -3, -4 };
            arr[3] = new int[6] { -1, -9, -2, -4, -4, -5 };
            arr[4] = new int[6] { -7, -3, -3, -2, -9, -9 };
            arr[5] = new int[6] { -1, -3, -1, -2, -4, -5 };

            int ret = process(arr);

            Console.WriteLine($"{ret}");
        }

        public static int process(int[][] arr)
        {
            int[][] sumOne = new int[6][];
            int[][] node = new int[4][];
            int[] sums = new int[16];

            for (int i = 0; i < arr.Length; i++)
            {
                int a = 0;
                int arrSize = arr[0].Length - 2;
                sumOne[i] = new int[arrSize];
                for (int j = 0; j < arrSize; j++)
                {
                    sumOne[i][j] = arr[i][j + a++] + arr[i][j + a++] + arr[i][j + a++];
                    a = 0;
                }
            }

            int arrSize2 = 4;
            for (int i = 0; i < arrSize2; i++)
            {
                node[i] = new int[arrSize2];
                for (int j = 0; j < arrSize2; j++)
                {
                    node[i][j] = arr[i + 1][j + 1];
                }
            }

            int k = 0;
            for (int i = 0; i <= node.Length - 1; i++)
            {
                for (int j = 0; j <= node.Length - 1; j++)
                {
                    sums[k] = sumOne[i][j] + node[i][j] + sumOne[i + 2][j];
                    k++;
                }
            }

            int highestSum = -63;
            for (int m = 0; m <= sums.Length - 1; m++)
            {
                if (sums[m] > highestSum)
                {
                    highestSum = sums[m];
                }
            }

            return highestSum;
        }
    }
}