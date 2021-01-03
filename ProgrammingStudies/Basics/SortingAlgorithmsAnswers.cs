using System;
using System.Collections.Generic;

namespace ProgrammingStudies.Basics
{
    public class SortingAlgorithmsAnswers
    {

        /// <summary>
        /// Bubble Sort runs in O(n^2).  The method compares arr[i] to arr[i+1] starting at
        /// i = 0 and swaps them if arr[i] is greater than arr[i+1].  The inner loop runs all the way
        /// to end of the array minus 1 + i since each iteration places the highest unsorted int at
        /// the end of the array.  The counter will increment whenever a swap occurs and
        /// the method will terminate if a full loop of the array results in no swaps.  This will
        /// prevent the method from running the entire course if the array is already sorted.
        /// 
        /// </summary>
        /// <param name="arr"></param>
        public static void BubbleSort(int[] arr)
        {

            for (int i = 0; i < arr.Length - 2; i++)
            {
                int count = 0;

                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                        count++;
                    }
                }

                if (count == 0)
                {
                    return;
                }
            }
        }

        /// <summary>
        /// Selection Sort searches for the lowest number in the array and places it at the beginning
        /// of the array.  This algorithm runs in O(n^2).
        /// </summary>
        /// <param name="arr"></param>
        public static void SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int lowest = i;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[lowest])
                    {
                        lowest = j;
                    }
                }

                if (lowest != i)
                {
                    int temp = arr[i];
                    arr[i] = arr[lowest];
                    arr[lowest] = temp;
                }
            }
        }
         
    }
}