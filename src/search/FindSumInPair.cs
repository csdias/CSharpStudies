using System;
using System.Collections.Generic;

namespace Algorithm
{
    public partial class Search
    {
        public static void Main(string[] args){

        }

        public static int[] FindSumInPair(int[] arr, int val){
            int b = 0;
            int e = arr.Length - 1;

            while(b <= e){
                Console.WriteLine($"b {b} e {e} - arr[b] {arr[b]} arr[e] {arr[e]}");
                int sum = arr[b] + arr[e];
                if (sum != val){
                    if (val > sum)
                        b++;
                    else 
                        e--;
                }
                else
                    return new int[2] {arr[b], arr[e]};
            }
            return new int[2] {-1,-1};        
        }
    }
}
