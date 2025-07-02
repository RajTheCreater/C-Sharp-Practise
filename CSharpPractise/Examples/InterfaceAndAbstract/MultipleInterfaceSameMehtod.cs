using System;



namespace CSharpConcepts.InterfaceAndAbstract
{
    interface ICalculate1
    {
        int Add(int num1, int num2);
    }

    interface ICalculate2
    {
        int Add(int num1, int num2);
    }

    class InterfacesIm : ICalculate1, ICalculate2
    {
        public int Add(int num1, int num2)
        {
            var resr = num1 + num2;
            Console.WriteLine("Sum in Interfaces   " + resr);
            return resr;
        }
    }
    public class MultipleInterfaceSameMehtod3
    {
        static void Main()
        {
            InterfacesIm obj1 = new InterfacesIm();
            obj1.Add(54, 74);
            Console.Read();
        }
    }
}

//namespace CSharpConcepts.InterfaceAndAbstract
//{
//    interface ILoanCustomer
//    {
//        void GetCostomerInfo();
//    }

//    interface IBankCustomer
//    {
//        void GetCostomerInfo();
//    }


//    class Customer : ILoanCustomer, IBankCustomer
//    {
//        //Explicit implementation of ILoanCustomer interface
//        void ILoanCustomer.GetCostomerInfo()
//        {
//            Console.WriteLine("Loan Customer ...");

//        }
//        void IBankCustomer.GetCostomerInfo()
//        {
//            Console.WriteLine("Bank Customer ...");

//        }
//    }
//    class MultipleInterfaceSameMehtod
//    {
//        static void Main(string[] args)
//        {
//            IBankCustomer bc = new Customer();
//            bc.GetCostomerInfo();

//            ILoanCustomer lc = new Customer();
//            lc.GetCostomerInfo();
//            Console.Read();

//        }
//    }
//}
