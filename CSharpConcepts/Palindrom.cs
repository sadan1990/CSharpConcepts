using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpConcepts
{
    class Palindrom
    {
        public bool CheckPalindrom(string word="abcab")
        {
            int len = word.Length-1;
            string reverseWord = "";
            for(int i= len; i >=0; i--)
            {
                reverseWord += word[i];
            }
            if(reverseWord== word)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
