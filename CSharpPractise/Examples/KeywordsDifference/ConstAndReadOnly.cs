using System;

namespace CSharpPractise.KeywordsDifference
{
    public class ConstAndReadOnly
    {
        const int ConstTest = 1;
        public readonly int ReadOnlyTest;

        public ConstAndReadOnly()
        {
            ReadOnlyTest = 54;
        }

        public int SumConstAndReadOnly()
        {
            var result = 0;
            result += ReadOnlyTest;
            Console.WriteLine("result  ReadOnlyTest     " + result);
            result += ConstTest;
            Console.WriteLine("result  ConstTest     " + result);
            return result;
        }
    }

    public class ConstAndReadOnlyProgram
    {
        public static void Main()
        {
            ConstAndReadOnly obj = new ConstAndReadOnly();
            obj.SumConstAndReadOnly();
            Console.ReadLine();
        }
    }
}
