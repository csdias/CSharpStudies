using System;
using System.Collections.Generic;

namespace Algorithm
{
    public partial class Search
    {
        public static void Main(string[] args){

        }

        static int BinarySearch(int[] toBeSearched, int item)
        {
            int min = 0;
            int max = toBeSearched.Length -1;
            while(min <= max){
                int mid = (max + min)/2;

                if (item > toBeSearched[mid]){
                    min = mid +1;
                }
                else if (item < toBeSearched[mid]){
                    max = mid -1;
                }
                else if(item == toBeSearched[mid])
                {
                    return ++mid;
                }
            }

            return -1;
        }
    }
}
