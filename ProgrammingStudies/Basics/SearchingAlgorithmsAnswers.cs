using System;

namespace ProgrammingStudies.Basics
{
    public class SearchingAlgorithmsAnswers
    {
        /// <summary>
        /// Binary Search is a log(n) searching algorithm.  The algorithm checks the center
        /// index of the array for the desired value.  If the value is not found, the array
        /// is essentially cut in half and the next search will check the center index of the
        /// remaining array.  See Recursion class for a recursive version.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int BinarySearch(int[] arr, int num)
        {
            bool searching = true;
            int output = -1;
            int high = arr.Length;
            int low = 0;

            while (searching && low <= high)
            {
                int half = (high + low) / 2;
                
                if (arr[half] == num)
                {
                    searching = false;
                    output = half;
                        
                } else if (arr[half] < num)
                {
                    low = half + 1;
                } else
                {
                    high = half - 1;
                }

            }

            return output;
        }
    }
}