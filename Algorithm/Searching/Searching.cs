using System;
using System.Collections.Generic;

namespace Algorithm
{
    public class Searching
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

        //static int RecursiveBinarySearch(this int[] arr, int item){

            //return RecursiveBinarySearch(arr, 0, arr.Length, item);

        //}

        static int NovoBinarySearch(int[] toBeSearched, int item)
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

        static int BinarySearch(int[] arr, int x){
            //int[] seq  = { 800, 11, 50, 771, 649, 770, 240, 9 };
            //int[] seq  = { 9, 11, 50, 240, 649, 770, 771, 800};

            int min = 0;
            int max = arr.Length - 1;
            while(min <= max){
                int mid = (min + max)/2;

                if (x == arr[mid]){
                    return ++mid;

                }
                else if(x > arr[mid]){
                    min = mid + 1;
                }
                else if(x < arr[mid]){
                    max = mid - 1;
                }

            }

            return -1;

            // int min = 0;
            // int max = arr.Length - 1;

            // while (min <= max) {
            //     int mid = (min + max) / 2;
                
            //     if (x == arr[mid]) {
            //         return ++mid;
            //     } else if (x < arr[mid]) {
            //         max = mid - 1;
            //     }else {
            //         min = mid + 1;
            //     }
            // }

            // return -1;
        }

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

        static int[] MySort(int[] seq){

            for(var i=0; i< seq.Length -1; i++){

                var temp1 = seq[i];
                var temp2 = seq[i+1];

                if (temp1 > temp2){
                    seq[i] = temp2;
                    seq[i+1] = temp1;

                    i = 0;
                }

            };

            return seq;
        }

        static int[] CocktailSort(int[] arr){

            int end = arr.Length - 1;

            bool swap = true;

            int start = 0;
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

        static List<int> Fibonacci(int x){
            return FibWithSequence(x);
        }

        static List<int> FibWithSequence(int x){
            if (x == 0)
                return new List<int>(){0,1};

            List<int> seq = FibWithSequence(x-1); 

            seq.Add(seq[(x-1)]+seq[(x)]);

            return (seq);
        }

        static (int current, int previous) Fib(int x){

            if (x == 0)
                return (0, 1);

            (int c, int p) = Fib(x-1); 

            return (p, c + p);

        }

    }
}
