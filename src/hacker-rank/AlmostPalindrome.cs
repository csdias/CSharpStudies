
namespace HackerRank
{
    public partial class AlmostPalindrome
    {      
        //public static void Main(string[] args){
            
            //var res = IsItAlmostPalindrome("abccba");
            // var res = AlmostPalindrome("abccfa");
            // var res = AlmostPalindrome("abccfg");
            // var res = AlmostPalindrome("abba");
            // var res = AlmostPalindrome("abfa");
            // var res = AlmostPalindrome("abcd");
        //}


        static bool IsItAlmostPalindrome(string candidate)
        {
            int min = 0;
            int max = candidate.Length;
            
            int mid = (max + min)/2;
            int countEquals = 0;
            int opposite = 1;

            for(var x = mid-1; x >= 0; x--){

                if (candidate[x] == candidate[x+opposite]){
                    countEquals++;
                }
                opposite += 2;
            }

            return ((countEquals * 2) >= (candidate.Length - 2));

        }

    }
}
