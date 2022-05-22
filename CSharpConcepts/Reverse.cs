using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpConcepts
{
    class Reverse
    {
        public void reverse()
        {
            string statement = "My name is Vijay";
            string newStatement = string.Empty;
            var words = statement.Split(' ');
            foreach(var word in words)
            {
                string newWord = string.Empty;
                int length = word.Length-1;
                for(int i= length; i>=0;i--)
                {
                    newWord += word[i];
                }

                newStatement += " " + newWord;
            }
        }
    }
}
