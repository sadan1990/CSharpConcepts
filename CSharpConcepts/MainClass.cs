using System;

namespace CSharpConcepts
{
    class MainClass
    {
        static void Main(string[] args)
        {
            int originalNumber = 10;
            OutVsRef outVsRef = new OutVsRef();

            outVsRef.AddNumbers(originalNumber);
            Console.WriteLine("originalNumber number is - {0}", originalNumber);


            outVsRef.AddNumbersUsingOut(out originalNumber);
            Console.WriteLine("originalNumber number using out is - {0}", originalNumber);

            outVsRef.AddNumbersUsingRef(ref originalNumber);
            Console.WriteLine("originalNumber number using ref is - {0}", originalNumber);

            Console.ReadLine();


        }
    }
}
