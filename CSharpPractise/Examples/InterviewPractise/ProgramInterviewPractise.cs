using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractise.Examples.InterviewPractise
{
    public class ProgramInterviewPractise
    {
        static void Main(string[] args)
        {
            MaxOccuranceUninterpreted maxOccuranceUninterpreted = new MaxOccuranceUninterpreted();
            string input =  "aavvvddddbbbbbbbbccccccccddddddddddddddddaaeesssssaaaaaaa";
            maxOccuranceUninterpreted.GetMaxOccuranceUninterpreted(input);
            Console.ReadLine();
        }
    }
}
