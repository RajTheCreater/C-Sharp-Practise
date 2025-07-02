using System;

namespace CSharpConcepts.Constructors
{
    public class AB
    {
        static string _testA1 = "";
        string _testA2 = String.Empty;
        static AB()
        {
            _testA1 = "Static Default value";
            Console.WriteLine("static AB Constructor  " + _testA1);
        }
        public AB(string st)
        {
            this._testA2 = st;
            Console.WriteLine("Normal AB Constructor  ");
        }
    }
    class StaticConstructors
    {
    }
}
