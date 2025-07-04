using System;

namespace CSharpPractise.KeywordsDifference
{
    public class ReffTest
    {
        public int num1 = 19;
        public int ReturnRefValue(ref int num2)
        {
            num2 += num1;
            return num2;
        }
    }
    public class OutTest
    {
        public int num1;
        public int ReturnOutValue(out int num1, int num2)
        {
            num1 = num2;
            return num1;
        }
    }
    public class RefAndOut
    {

        static void Main()
        {
            ReffTest rt = new ReffTest();

            int num = 0;
            Console.WriteLine("Ref Implementation num  ");
            var res1 = 77;
            rt.ReturnRefValue(ref num);
            Console.WriteLine("Ref Implementation   " + res1.ToString());
            OutTest ot = new OutTest();
            int num1;
            var res2 = ot.ReturnOutValue(out num1, 37);
            Console.WriteLine("Out Implementation   " + res2);
            Console.ReadLine();
        }

    }

}
