using System;
using System.Collections.Generic;

namespace Algorithm
{
    public partial class Search
    {
        static int RecursiveBinarySearch(int[] arr, int min, int max, int item){

            if (min < max)
                return -1 ;

            int mid = (min + max)/2;

            if (item == arr[mid])
                return mid++;
            else if(item > arr[mid]){
                min = mid  + 1;
            }
            else if (item < arr[mid]){
                max = mid - 1;
            }

            return RecursiveBinarySearch(arr, min, max, item);
        }
    }
}
