using System;

namespace CSharpPractise.InterfaceAndAbstract
{
    interface ISimpleCalculator
    {
        int Add(int[] input);
    }
    interface IComplexCalculator
    {
        int Add(int[] input);
    }
    class Calculator : ISimpleCalculator, IComplexCalculator
    {
        int resultSimpleCalculator = 0;
        int resultComplexCalculator = 0;
        //This is explicit implementation
        int ISimpleCalculator.Add(int[] input)
        {
            foreach (var item in input)
            {
                resultSimpleCalculator += item;
            }
            return resultSimpleCalculator;
        }
        int IComplexCalculator.Add(int[] input)
        {
            foreach (var item in input)
            {
                resultComplexCalculator += item;
            }
            return resultComplexCalculator + 200;
        }
    }
    public class ExplicitImplementation
    {
        public static void Main()
        {
            int[] n = new int[3];
            Calculator obj = new Calculator();
            ISimpleCalculator i1 = new Calculator();
            int[] input = new int[3];
            for (int i = 0; i < n.Length; i++)
            {
                Console.Write("element - {0} : ", i);
                input[i] = Convert.ToInt32(Console.ReadLine());
            }
            i1.Add(input); //will call ISimpleCalculator.Add()  
        }
    }
}
