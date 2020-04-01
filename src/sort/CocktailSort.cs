using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm
{
    public static partial class Sort
    {
        static int[] CocktailSort(int[] arr){

            int start = 0;
            int end = arr.Length - 1;
            bool swap = true;

            while(swap){
                for(var j = start; j < end; j++){

                    if (arr[j+1] < arr[j]){
                        var tmp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = tmp;

                        swap = true;
                    }
                }

                start++;
            
                if (!swap)
                    break;

                swap = false;

                for(var j = end; j > 0; j--){

                    if (arr[j-1] > arr[j]){
                        var tmp = arr[j];
                        arr[j] = arr[j-1];
                        arr[j-1] = tmp;

                        swap = true;
                    }
                }

                if (!swap)
                    break;

                end--;
           
            }

            return arr;
        }


    }
}
