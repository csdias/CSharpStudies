using System;

namespace study
{
    public static partial class Study
    {

        //Make Change 
        static void Main(string[] args)
        {
            int[] coins = {1,2,5};
            int amount = 11;

            var result = Study.CoinChange(coins, amount);


        }
        //FindNemo
        static void Main_FindNemo(string[] args)
        {
            int[] arr = {1,2,3,4,5,6,7,8,9,11,12,13,14,15,16,21};
            //int[] arr = {100,200,1100,1200,2000,2100};
            int result = Study.find(arr, 31);
            //Console.Write($" Found Nemo! {result[0]}  {result[1]} ");
        }


        static void Main_Hollyday(string[] args){
                        int[] list = {1, 4, 6, 3 ,2};

            //Study.solution(2004, "March", "June", "Wednesday");

            //return;

            string message = "The number to be parsed is: 123";
            string msg = "hello";

            char[] charMsg = msg.ToCharArray(); 

            charMsg[0] = 'Z';

            //this does not create a new string
            ReadOnlySpan<char> msgSpan = message;
            ReadOnlySpan<char> numSpan = msgSpan.Slice(message.IndexOf(':')+2);
            int.TryParse(numSpan, out int b);
            Console.WriteLine(b);
        }


   }
}
