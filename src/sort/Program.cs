using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm
{
    public static partial class Sort
    {
        static void Main(string[] args)
        {
            int[] unsortedI  = { 800, 11, 50, 771, 649, 770, 240, 9 };
            int[] unsortedII = new int[10] {2, 0, 1, 5, 7, 4, 9, 3, 8, 6};
            int[] unsortedIII = {6, 42, 10, 86, 4, 12, 30, 23};

            List<int> sorted = Sort.MergeSort(unsortedIII.ToList<int>());
            
            foreach(var i in sorted){
                Console.WriteLine(i);
            }

            //int[] sorted = BubbleSort(seq);

            //int[] sorted = CocktailSort(seq);

            //int s = BinarySearch(sorted, 9);
            //int ss = NovoBinarySearch(sorted, 50);
            //int sss. = RecursiveBinarySearch(sorted, 50);

            //Console.WriteLine(BinarySearch(sorted, int x))

        }
    }
}
