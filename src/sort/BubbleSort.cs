using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm
{
    public static partial class Sort
    {
        static int[] BubbleSort(int[] arr) {
            int temp = 0;
            
            for (int write = 0; write < arr.Length; write++) {
                for (int sort = 0; sort < arr.Length - 1; sort++) {
                    if (arr[sort] > arr[sort + 1]) {
                        temp = arr[sort + 1];
                        arr[sort + 1] = arr[sort];
                        arr[sort] = temp;
                    }
                }
            }

            return arr;
        }
    }
}
