using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            //var p = GetNthFibonacci_Ite(7);

            //var p = GetNthFibonacci_Rec(7);

            //var p = CalculateFibonacci(5);

            //var p = Fibonacci_Tuples(7);

            var arr = mySort(new int[]{3,1,2,4,9,6});

            //Console.WriteLine(p);

            Console.Read();
        }

        public static int[] mySearch(int[] arr) {
            int ini = 0;
            int end = arr.Length;
            int med = (end + ini) / 2;


            return arr;
        }


        public static int CalculateFibonacci(int p) 
        {
            if (p < 1) { 
                return 1;
            }

            //int a = 0;
            //int b = 1;
            //int c = 0;

            //Console.WriteLine(a);
            //Console.WriteLine(b);

            // for(var i = 0; i < p; i++){

            //     c = b + a;
            //     a = b;
            //     b = c;

            //     Console.WriteLine(c);
            // }

            int c = Fib(0, 1, p);

            return c - 2;
        }

        public static int Fib(int a, int b, int p){

            if (p == 1)
                return 1;
                

            var c = Fib(b, a+b, p-1);

            Console.WriteLine(c);

            return b;

        }


        public static int GetNthFibonacci_Ite(int n)  
        {  
            int number = n - 1; //Need to decrement by 1 since we are starting from 0  
            int[] Fib = new int[number + 1];  
            Fib[0]= 0;  
            Fib[1]= 1;  
            for (int i = 2; i <= number;i++)  
            {  
            Fib[i] = Fib[i - 2] + Fib[i - 1];  
            }  
            return Fib[number];  
        }  

        public static int GetNthFibonacci_Rec(int n)  
        {  
            if ((n == 0) || (n == 1))  
            {  
                return n;  
            }  
            else  
                return GetNthFibonacci_Rec(n - 1) + GetNthFibonacci_Rec(n - 2);  
        }

        public static int Fibonacci_Tuples(int x) {

             if (x < 0) throw new ArgumentNullException(
                 "Must be at leat 0", nameof(x));

             return Fib(x).current;

            (int current, int previous) Fib(int i) {
                    if (i == 0) return (0, 1);      

                    var (current, previous) = Fib(i - 1);

                    return (current + previous, current);
             }

        }
        
    }
}
