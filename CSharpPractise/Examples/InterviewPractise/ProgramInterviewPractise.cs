using System;

namespace CSharpPractise.Examples.InterviewPractise
{
    public class ProgramInterviewPractise
    {
        static void Main(string[] args)
        {
            MaxOccuranceUninterpreted maxOccuranceUninterpreted = new MaxOccuranceUninterpreted();
            string input = "aavvvddddbbbbbbbbccccccccddddddddddddddddaaeesssssaaaaaaa";
            maxOccuranceUninterpreted.GetMaxOccuranceUninterpreted(input);
            Console.ReadLine();
        }
    }
}
