using System;

namespace CSharpPractise.Polymorphism
{
    public class A
    {
        public virtual void Method()
        {
            Console.WriteLine(" A ");
        }
    }
    public class B : A
    {
        public override void Method()
        {
            Console.WriteLine(" B ");
        }
    }
    public class C : B
    {
        public new void Method()
        {
            Console.WriteLine(" C ");
        }
    }
    public class D
    {
        public static int MyProperty { get; set; }
        private D()
        {
            Console.WriteLine("private D ");
        }
        static D()
        {
            Console.WriteLine("private D ");
        }
    }
    public class Overriding
    {
        public static void Main()
        {
            //A objA = new A();
            //objA.Method();

            //A objB = new B();
            //objB.Method();

            //A objC = new C();
            //objC.Method();

            D.MyProperty = 10;
            Console.Read();
        }
    }
}
