using System;

namespace CSharpPractise.Exceptions
{
    public class MultiCatch
    {
        private int num1;
        private int num2;

        public MultiCatch(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        public int Divide()
        {
            var res = 0;
            try
            {
                res = num1 / num2;
                return res;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception ex   " + ex.ToString());
                throw;
            }
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine("ArgumentException ex   " + ex.ToString());
            //    throw;
            //}
        }

    }
}
