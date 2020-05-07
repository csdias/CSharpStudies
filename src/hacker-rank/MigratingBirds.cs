using System.Collections.Generic;
using System.Linq;

namespace HackerHank
{
    public partial class MigratingBirds
    {
        // public static void Main(string[] args)
        // {
        //     List<int> arr = new List<int>(){1, 4, 4, 4, 5, 3};
        //     int ret = migratoryBirds(arr);

        // }


        // Complete the migratoryBirds function below.
        public static int migratoryBirds(List<int> arr)
        {
            int[] ar = new int[5];
            foreach (int i in arr)
                ar[i - 1] = ar[i -1]+1;

            int highest = 0;
            int answer = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] > highest)
                {
                    highest = ar[i];
                    answer = i + 1;
                }
                else if(ar[i] == highest)
                {
                    answer = i;
                }
            }

            return answer;
        }

    }
}