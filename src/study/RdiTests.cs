using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace Study
{
    public class RdiTests
    {
        public static bool doesOccur(string[] words, string word){
            
            char[] oc = new char[word.Length];
            bool found = false;
            int a = 0;
            int i = 0;

            while(true){
                while(true){
                    if (words[i].IndexOf(word[a]) > 0){
                        oc[a] = '1';
                        found = true;
                        break;                        
                    }
                    i++;
                    if(i == words.Length)
                        break;
                }
                i++;
                if (found){ 
                    a++; found = false; 
                }
                else{
                    oc[a] = '0';
                    a++;; 
                }

                if(i == words.Length)
                    break;
            }

            return oc.Count(c => c == '0') == 0;
        }

        public static int getTheOddly(int[] ar){
            int theOddly = 0;
            int[] tp = new int[ar.Length/2 + 1];
            Dictionary<int,int> dic = new Dictionary<int, int>();

            for(int i = 0; i < ar.Length; i++){
                dic[ar[i]] = dic.ContainsKey(ar[i]) ? dic[ar[i]] + 1 : 1;
            }

            foreach(KeyValuePair<int, int> kvp in dic){
                if (kvp.Value == 1){
                    theOddly = kvp.Key;
                    break;
                }
            }
            return theOddly;
        }


        public static StringBuilder ToSetBits(int n)
        {
            StringBuilder sb = new StringBuilder();
            while (n > 0)
            {
                var r = n % 2;
                sb.Append(r);
                n = n / 2;
            }
            return sb;
        }

        public static StringBuilder ToBinary(int n)
        {
            StringBuilder sb = new StringBuilder();

            int j;
            for(int i = 1; i <= n; i++){
                j = i;
                while (j > 0)
                {
                    var r = j % 2;
                    
                    if (r == 1)
                        sb.Append(r);

                    j = j / 2;
                }
            }
            return sb;
        }


        public static bool isPalindrome(string word)
        {
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i< word.Length; i++)
                if(char.IsLetterOrDigit(word[i]))
                    sb.Append(char.ToLower(word[i]));

            word = sb.ToString();
            int min = 0;
            int max = word.Length;
            int isEven = max % 2;             
            int mid = ((max + min) / 2) - 1;
            int countEquals = 0;
            int opposite = 1 + isEven;

            for (var x = mid; x >= 0; x--)
            {
                if (word[x]== word[x + opposite])
                    countEquals++;
                
                opposite += 2;
            }

            return countEquals * 2 == max - isEven;
        }

        public bool isEven(int n)
        {
            if (n == 0)
                return true;
            if (n == 1 || n == -1)
                return false;

            if (n > 0)
                while (n == 0 || n == 1)
                    n = n - 2;
            else
                while (n == 0 || n == -1)
                    n = n - 2;

            if (n == 1 || n == -1)
                return false;
            else
                return true;
        }

        //private static Node countNode(Node node)
        //{
//
            //if (node.left == null && node.right == null)
        //     {
        //         node.value = 1;
        //         return node;
        //     }

        //     Node left = null;
        //     if (node.left != null)
        //     {
        //         left = countNode(node.left);
        //         left.value++;
        //     }

        //     Node right = null;
        //     if (node.right != null)
        //     {
        //         right = countNode(node.right);
        //         right.value++;
        //     }

        //     int countLeft = left?.value == null ? 0 : left.value;
        //     int countRight = right?.value == null ? 0 : right.value;

        //     node.value = countLeft >= countRight ? countLeft : countRight;

        //     return node;
        // }


        // public static Node insert(Node node, int val)
        // {
        //     Node root = node;
        //     Node newNode = null;

        //     if (node == null)
        //     {
        //         return new Node(val);
        //     }

        //     if (val >= node.value)
        //     {
        //         newNode = insert(node.right, val);
        //         node.right = newNode;
        //     }
        //     else
        //     {
        //         newNode = insert(node.left, val);
        //         node.left = newNode;
        //     }

        //     return root;
        // }

    }

}