using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpConcepts
{
    static class ExtensionMethod
    {
        public static string ReverseString(this string input)
        {
            List<char> reverseStringChar = new List<char>();
            int length = input.Length-1;

            for(int i= 0; length>-1; i++)
            {
                reverseStringChar.Add(input[length]);
                length--;
            }
            char [] reverseArray = reverseStringChar.ToArray();
            string reverseString = new string(reverseArray);
            return reverseString;
        }

        public static List<string> NameContainsSadan(this List<string> names)
        {
            return names.FindAll(i => i.Contains("sadan"));
        }
    }
}
