using System;

namespace study
{
    public static partial class Study
    {
        public static int find(int[] arr, int val){
            int b = 0;
            int e = arr.Length;
            int m;

            while(b <= e){
                m = ((b + e)/2);
                Console.WriteLine($"b {b} e {e} m {m} val {arr[m]}");
                if (val > arr[m]){
                    m++; b = m;
                }
                else if(val < arr[m]){
                    m--; e = m;
                }
                else if(val == arr[m])
                    return ++m;
            }

            return -1;
        }

        public static bool findNemo(int[] arr, int v){
            bool foundNemo = false;
            int ini = 0;
            int end = arr.Length;
            int pos = ini + end / 2;
            Console.Write($" ini: {ini}  mid: {pos} value: {arr[pos]} end: {end} \n");

            while(ini <= end && foundNemo == false && pos >= 0 && pos < arr.Length - 1){
                foundNemo = (v == arr[pos]);
                
                if (foundNemo)
                    break;

                if(v > arr[pos]){
                    ini = pos + 1;
                    pos = (ini + end) / 2;
                } else if(v < arr[pos]){
                    end = pos -1; 
                    pos = (ini + end) / 2;
                }

                Console.Write($" ini: {ini}  mid: {pos} value {arr[pos]} end: {end} \n");

            }

            return foundNemo;
        }
    
    }
}
