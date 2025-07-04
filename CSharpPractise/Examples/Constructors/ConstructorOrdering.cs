using System;

namespace CSharpPractise.Constructors
{
    public class A
    {
        static string testA1 = String.Empty;
        string testA2 = String.Empty;
        static A()
        {
            Console.WriteLine("static A Constructor  ");
        }
        public A()
        {
            Console.WriteLine("Normal A Constructor  ");
        }
    }

    public class B : A
    {
        static string testB1 = String.Empty;
        string testB2 = String.Empty;
        static B()
        {
            Console.WriteLine("static B Constructor  ");
        }
        public B()
        {
            Console.WriteLine("Normal B Constructor  ");
        }
    }

    public class C : B
    {
        static string testC1 = String.Empty;
        string testC2 = String.Empty;
        static C()
        {
            Console.WriteLine("static C Constructor  ");
        }
        public C()
        {
            Console.WriteLine("Normal C Constructor  ");
        }
    }

    public class ConstructorOrdering
    {
        static void Main()
        {
            C cb = new C();
            Console.Read();
        }
    }
}
