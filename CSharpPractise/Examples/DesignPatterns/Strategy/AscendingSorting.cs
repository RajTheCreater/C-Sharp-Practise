using System;

namespace CSharpConcepts.DesignPatterns.Strategy
{
    public class AscendingSorting : Sorting
    {
        public override Array AlgoSorting(Array arr)
        {
            Console.WriteLine("AscendingSorting Unsorted Array  " + arr);
            foreach (var item in arr)
            {
                Console.WriteLine("AscendingSorting Unsorted Array item  " + item);
            }
            Array.Sort(arr);
            foreach (var item in arr)
            {
                Console.WriteLine("AscendingSorting Sorted Array item  " + item);
            }
            Console.WriteLine("AscendingSorting Sorted Array  " + arr);
            return arr;

        }
    }
}
