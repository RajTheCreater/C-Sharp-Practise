using System;

namespace CSharpConcepts.DesignPatterns.Strategy
{
    public class DescendingSort : Sorting
    {
        public override Array AlgoSorting(Array arr)
        {
            Console.WriteLine("DescendingSort Unsorted Array  " + arr);
            Array.Sort(arr);
            foreach (var item in arr)
            {
                Console.WriteLine("DescendingSort Sorted Array item  " + item);
            }
            Console.WriteLine("DescendingSort Sorted Array  " + arr);
            Array.Reverse(arr);
            foreach (var item in arr)
            {
                Console.WriteLine("DescendingSort Sorted Reverse Array item  " + item);
            }
            Console.WriteLine("DescendingSort Sorted Reverse Array  " + arr);
            return arr;

        }
    }
}

