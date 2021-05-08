using System;

namespace CSharpConcepts
{
    class MainClass
    {
        static void Main(string[] args)
        {
            ////////////////////////////Out vs Ref ////////////////////////////////////
            int originalNumber = 10;
            OutVsRef outVsRef = new OutVsRef();

            outVsRef.AddNumbers(originalNumber);
            Console.WriteLine("originalNumber number is - {0}", originalNumber);


            outVsRef.AddNumbersUsingOut(out originalNumber);
            Console.WriteLine("originalNumber number using out is - {0}", originalNumber);

            outVsRef.AddNumbersUsingRef(ref originalNumber);
            Console.WriteLine("originalNumber number using ref is - {0}", originalNumber);

            /////////////////////////////Extension Method//////////////////////
            string name = "sadan";
            string reverse = name.ReverseString();
            Console.WriteLine("reverse string using extension method is - {0}", reverse);

            Console.ReadLine();


        }
    }
}
