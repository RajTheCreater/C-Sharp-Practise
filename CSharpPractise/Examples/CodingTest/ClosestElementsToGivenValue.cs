// C# program to find k closest elements to
// a given value
using System;

namespace CSharpPractise.CodingTest
{
   public class ClosestElementsToGivenValue
    {

        /* Function to find the cross over point
        (the point before which elements are
        smaller than or equal to x and after which
        greater than x)*/
        static int findCrossOver(int[] arr, int low,
                                    int high, int x)
        {

            // Base cases
            // x is greater than all
            if (arr[high] <= x)
                return high;

            // x is smaller than all
            if (arr[low] > x)
                return low;

            // Find the middle point
            /* low + (high - low)/2 */
            int mid = (low + high) / 2;

            /* If x is same as middle element, then
            return mid */
            if (arr[mid] <= x && arr[mid + 1] > x)
                return mid;

            /* If x is greater than arr[mid], then
            either arr[mid + 1] is ceiling of x or
            ceiling lies in arr[mid+1...high] */
            if (arr[mid] < x)
                return findCrossOver(arr, mid + 1,
                                        high, x);

            return findCrossOver(arr, low, mid - 1, x);
        }

        // This function prints k closest elements
        // to x in arr[]. n is the number of
        // elements in arr[]
        static void printKclosest(int[] arr, int x,
                                    int k, int n)
        {

            // Find the crossover point
            int l = findCrossOver(arr, 0, n - 1, x);

            // Right index to search
            int r = l + 1;

            // To keep track of count of elements
            int count = 0;

            // If x is present in arr[], then reduce
            // left index Assumption: all elements in
            // arr[] are distinct
            if (arr[l] == x) l--;

            // Compare elements on left and right of
            // crossover point to find the k closest
            // elements
            while (l >= 0 && r < n && count < k)
            {
                if (x - arr[l] < arr[r] - x)
                    Console.Write(arr[l--] + " ");
                else
                    Console.Write(arr[r++] + " ");
                count++;
            }

            // If there are no more elements on right
            // side, then print left elements
            while (count < k && l >= 0)
            {
                Console.Write(arr[l--] + " ");
                count++;
            }

            // If there are no more elements on left
            // side, then print right elements
            while (count < k && r < n)
            {
                Console.Write(arr[r++] + " ");
                count++;
            }
        }

        /* Driver program to check above functions */
        public static void Main()
        {
            int[] arr = {12, 16, 22, 30, 35, 39, 42,
                        45, 48, 50, 53, 55, 56};
            int n = arr.Length;
            int x = 35;
            printKclosest(arr, x, 4, n);
        }
    }
}

// This code is contributed by nitin mittal.
