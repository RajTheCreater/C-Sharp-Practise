using CSharpConcepts.DesignPatterns.Strategy;
using System;
namespace CSharpConcepts.DesignPatterns
{
    class StrategyDesignPatternProgram
    {


        static void Main(string[] args)
        {
            int[] array = new int[6];
            array[0] = 58;
            array[1] = 745;
            array[2] = 857;
            array[3] = 432;
            array[4] = 274;
            array[5] = 85;
            Console.WriteLine("  Array  " + array);
            ContextSorting context;
            context = new ContextSorting(new AscendingSorting());
            context.AlgoSorting(array);

            context = new ContextSorting(new DescendingSort());
            context.AlgoSorting(array);
            Console.Read();
        }
    }
}
