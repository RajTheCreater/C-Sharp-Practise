using System;

namespace CSharpConcepts.DesignPatterns.Strategy
{
    public class ContextSorting
    {
        private Sorting _sorting;
        public ContextSorting(Sorting sorting)
        {
            this._sorting = sorting;
        }
        public Array AlgoSorting(Array array)
        {
            _sorting.AlgoSorting(array);
            return array;
        }

    }
}
