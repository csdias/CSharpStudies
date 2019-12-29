using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm
{
    public static partial class Sorting
    {
        //In the quick sort, the mechanism is to choose a pivot
        //and put all the lowers items at the left and all the higher items at the right
        //Another trick is after comparing the elements and deciding to swap, the process of swaping is
        //To swap with a lower item: Put the element immediatelly before the pivot in a temporary space,
        //place the pivot in the house imediatelly before the pivot.
        //place the higher item in the place of the pivot
        //put the element in the temporary space in the old place of the higer element
        //break the array in two and keep doing it recursively until the array contains just one element
        private static List<int> QuickSort(List<int> list){

            if (list.Count <= 1)
                return list;

            int random = new Random().Next(list.Count);

            int i = 0; bool swapped = false;
            while(swapped){
                int elementIdx = i; int pivotIdx = random; int element = list[i]; int pivot = list[random];
                if (isElementBeforePivotAndElementHigherThanPivot(pivotIdx, elementIdx, pivot, element)){
                    list = swapElementBeforeThanPivotAndElementHigherThanPivot(pivotIdx, elementIdx, list);
                }
                else if (isElementAfterPivotAndElementLowerThanPivot(pivotIdx, elementIdx, pivot, element)){
                    list = swapElementAfterThanPivotAndElementLowerThanPivot(pivotIdx, elementIdx, list);
                }

                i++;
            }

            list = QuickSort(list);

            return list;
        }

        private static List<int> swapElementBeforeThanPivotAndElementHigherThanPivot(int pivotIdx, int elementIdx, List<int> list){
            //put the element before the pivot in a temp
            int tmp = list[pivotIdx - 1];
            //put the pivot in its place now
            list[pivotIdx-1] = list[pivotIdx];
            list[pivotIdx] = list[elementIdx];
            list[elementIdx] = tmp;
            
            return list;
        }

        private static List<int> swapElementAfterThanPivotAndElementLowerThanPivot(int pivotIdx, int elementIdx, List<int> list){
            //put the element before the pivot in a temp
            int tmp = list[pivotIdx + 1];
            //put the pivot in its place now
            list[pivotIdx+1] = list[pivotIdx];
            list[pivotIdx] = list[elementIdx];
            list[elementIdx] = tmp;
            
            return list;
        }

        private static bool isElementBeforePivotAndElementHigherThanPivot(int pivotIdx, int elementIdx, int pivot, int element){
            return (elementIdx < pivotIdx && element > pivot);
        }

        private static bool isElementAfterPivotAndElementLowerThanPivot(int pivotIdx, int elementIdx, int pivot, int element){
            return (elementIdx > pivotIdx && element < pivot);
        }

    }
}
