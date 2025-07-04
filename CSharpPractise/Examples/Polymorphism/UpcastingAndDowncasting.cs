using System;

namespace CSharpPractise.Polymorphism
{
    public class ParentClass
    {
        public ParentClass()
        {
            Console.WriteLine(" A ");
        }
    }
    public class ChildClass : ParentClass
    {
        public ChildClass()
        {
            Console.WriteLine(" B ");
        }
    }

    public abstract class ParentClass1
    {
        static ParentClass1()
        {
            Console.WriteLine("static  abstract A ");
        }
        public ParentClass1()
        {
            Console.WriteLine("abstract A ");
        }
    }
    public class ChildClass1 : ParentClass1
    {
        static ChildClass1()
        {
            Console.WriteLine("static abstract B ");
        }
        public ChildClass1()
        {
            Console.WriteLine("abstract B ");
        }
    }

    public class UpcastingAndDowncasting
    {
        public static void Main()
        {
            ParentClass objA = new ChildClass();
            //ChildClass objB = new ParentClass(); 


            //ParentClass obj  = new ParentClass();
            //ChildClass objB= (ParentClass)obj;


            ParentClass1 objA1 = new ChildClass1();
            //ParentClass1 objB1 = new ParentClass1();

            Console.Read();
        }
    }
}
