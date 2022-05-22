using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpConcepts
{
    class LargestArrayNumber
    {
        public int GetLargestNumber(int[] A)
        {
            var positiveInts = A.Where(i => i >= 0).ToList();
            int wordCount = positiveInts[0].ToString().Length;
            foreach(var item in positiveInts)
            {
                if(wordCount> item.ToString().Length)
                {
                    wordCount = item.ToString().Length;
                }
            }
            var onedigitsNumbers = positiveInts.Where(i => i.ToString().Length == 1).ToList();
            int maxOneDigitNumber= onedigitsNumbers.Max();
            return 1;
        }

    }
}
