using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpConcepts
{
    class OutVsRef
    {
        public void AddNumbers(int number)
        {
            number = number + 10;
        }
        public void AddNumbersUsingOut(out int number)
        {
            number = 0;// we cant pass value from caller function to callee , as we need to initialise it first
            number = number + 10;
        }
        public void AddNumbersUsingRef(ref int number)
        {
            number = number + 10;
        }
    }
}
