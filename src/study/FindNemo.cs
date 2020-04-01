using System;

namespace study
{
    public class Study
    {
        // static void Main(string[] args)
        // {
        //     int[] arr = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,21};
        //     //int[] arr = {100,200,1100,1200,2000,2100};

        //     Console.Write($" Found Nemo! {findNemo(arr, -2)}");

        // }

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
