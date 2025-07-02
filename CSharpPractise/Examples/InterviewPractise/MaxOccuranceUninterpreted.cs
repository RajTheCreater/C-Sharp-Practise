using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractise.Examples.InterviewPractise
{
    public class MaxOccuranceUninterpreted
    {
        public object GetMaxOccuranceUninterpreted(string input)
        {
            object result = null;
            string[] strArray = GetFilteredUniqueStrings(input);

            List<KeyValuePair<string, int>> lst = new List<KeyValuePair<string, int>>();
            foreach (string charector in strArray)
            {
                lst.Add(GetMaxOccuranceFromString(charector, input));
            }
            result =  lst.OrderByDescending(e=>e.Value).FirstOrDefault();
            Console.WriteLine(result);
            return result;
        }

        public string[] GetFilteredUniqueStrings(string input)
        {
            HashSet<char> seen = new HashSet<char>();
            List<string> filteredList = new List<string>();

            foreach (char c in input)
            {
                if (!seen.Contains(c))
                {
                    seen.Add(c);
                    filteredList.Add(c.ToString());
                }
            }
            filteredList.Sort();
            return filteredList.ToArray();
        }
        public KeyValuePair<string, int> GetMaxOccuranceFromString(string charector, string input)
        {
            int localCount = 0;
            int maxCount = 0;
            foreach (char c in input)
            {
                if (charector == c.ToString())
                {
                    localCount++;
                    maxCount = localCount > maxCount ? localCount : maxCount;
                }
                else
                {
                    maxCount = localCount > maxCount ? localCount : maxCount;
                    localCount = 0;
                }
            }

            return new KeyValuePair<string, int>(charector, maxCount);
        }
    }
}
