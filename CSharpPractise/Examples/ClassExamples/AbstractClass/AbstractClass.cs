using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractise.Examples.ClassExamples.AbstractClass
{ 
    public abstract class Calculator
    {
        public string ResultMessage = "Result is {0}";
        protected Calculator()
        {
            Console.WriteLine(String.Format(ResultMessage,2));
        }
        public abstract long Sum(long[] args);
        public abstract long Substract(long first, long second);
        public abstract long Multiply(long first, long second);
        public abstract long Divide(long first, long second);
        public virtual void Print(long result)
        {
            Console.WriteLine(String.Format(ResultMessage, result));
        }
    }
    public class SimpleCalculator : Calculator
    {
        public override long Divide(long first, long second)
        {
            return first / second;
        }

        public override long Multiply(long first, long second)
        {
            return first * second;
        }

        public sealed override void Print(long result)
        {
            Console.WriteLine(String.Format(ResultMessage, result));
        }

        public override long Substract(long first, long second)
        {
            return first - second;
        }

        public override long Sum(long[] args)
        {
            long result = 0;
            foreach (var val in args)
            {
                result += val;
            }
            return result;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            SimpleCalculator sc = new SimpleCalculator();
            long[] ar = new long[3] { 10, 20, 30 };
            long first = 400;
            long second = 25;
            var add = sc.Sum(ar);
            sc.Print(add);
            var substract = sc.Substract(first, second);
            sc.Print(substract);
            var multiply = sc.Multiply(first, second);
            sc.Print(multiply);
            var divide = sc.Divide(first, second);
            sc.Print(divide);

        }
    }
}