using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpConcepts
{
    class ConstantVsReadOnly
    {
        public const int id = 100;
        public readonly int id1;
        public ConstantVsReadOnly()
        {
            id1 = 1;
        }
        public static void SomeMethod()
        {
            //try with + 
            var a = 0;
            dynamic b = 1;
            b = b + "sadan";
            object c = 1;
             c = c+ "sadan";

            //////////////////////////////
            //try with -
            //var a1 = 0;
            //dynamic b1 = 1;
            //b1 = b1 - "sadan";
            //object c1 = 1;
            // c1 = c1- "sadan";
        }

    }
}
