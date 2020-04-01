using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm
{
    public static partial class Sort
    {
        static int[] SimpleSort(int[] seq){

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

    }
}
