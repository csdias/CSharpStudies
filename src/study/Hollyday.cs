using System;
using System.Collections.Generic;
using System.Linq;

namespace study
{
    public static partial class Study
    {
        public static void solution(int Y, string A, string B, string W) {
            // write your code in C# 6.0 with .NET 4.5 (Mono)

            //var isLap = isLapYear(Y);
            
            //var monthA = getMonth(A);
            //var monthB = getMonth(B);

            object foundDay = getDay(W);
                    
            return; //intDay;
        }
    
        // private static bool isLapYear(int year){
        //     return (year%4 == 0);
        // }

        // private static void getMonth(string month){
            
        //     var months = getMonths();
        //     //object[] foundMonth = new Object[2]();
            
        //     //foreach(var m in months){
        //     //  return  m;
        //     //}
            
        //     return; //months[0];
        // }
    
        private static object getDay(string day){
            
            var days = getDays();
            object foundDay = 0;
            

            for(var i = 0; i < days.GetLength(0); i++){
                foundDay = days[i,1];
            }
            
            return foundDay;
        }

    
        // private static object[,] getMonths(){
        //     object[,] months = new object[,]{
        //         {"January"},{31},
        //         {"February"},{28},
        //         {"March"},{31},
        //         {"April"},{30},
        //         {"May"},{31},
        //         {"June"},{30},
        //         {"July"},{31},
        //         {"August"},{31},
        //         {"September"},{30},
        //         {"October"},{31},
        //         {"November"},{30},
        //         {"December"},{31}
        //     };

        //     return months; 
        // }
    
        private static object[,] getDays(){
            object[,] days = new object[,]{
                {"Monday" , 1},
                {"Tuesday" , 2},
                {"Wednesday" , 3},
                {"Thursday" , 4},
                {"Friday" , 5},
                {"Saturday" , 6},
                {"Sunday" , 7}
            };

            return days; 
        }

    }
}
