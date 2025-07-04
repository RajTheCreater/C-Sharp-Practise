using System;

namespace CSharpPractise.InterfaceAndAbstract
{
    interface ICalculate
    {
        int Add(int num1, int num2);
    }
    class ABC : ICalculate
    {
        public int Add(int num1, int num2)
        {
            var resr = num1 + num2;
            Console.WriteLine("Sum in Interfaces   " + resr);
            return resr;
        }
    }
    class DEF : ICalculate
    {
        public int Add(int num1, int num2)
        {
            var resr = num1 + num2;
            Console.WriteLine("Sum in Interfaces   " + resr);
            return resr;
        }
    }

    public class OneClassToAnotherClassObject
    {
        static void Main()
        {
            ICalculate obj1 = new ABC();
            ICalculate obj2 = new DEF();
            //ABC obj3 = new DEF();
            Console.Read();
        }
    }
}

