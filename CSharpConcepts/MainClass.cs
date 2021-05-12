using System;
using System.Collections.Generic;

namespace CSharpConcepts
{
    class MainClass
    {
        static void Main(string[] args)
        {
            ////////////////////////////Out vs Ref ////////////////////////////////////
            Console.WriteLine("--------------------------------Out vs Ref--------------------------");
            int originalNumber = 10;
            OutVsRef outVsRef = new OutVsRef();

            outVsRef.AddNumbers(originalNumber);
            Console.WriteLine("originalNumber number is - {0}", originalNumber);


            outVsRef.AddNumbersUsingOut(out originalNumber);
            Console.WriteLine("originalNumber number using out is - {0}", originalNumber);

            outVsRef.AddNumbersUsingRef(ref originalNumber);
            Console.WriteLine("originalNumber number using ref is - {0}", originalNumber);

            /////////////////////////////Extension Method//////////////////////
            Console.WriteLine("--------------------------------Extension Method--------------------------");
            string name = "sadan";
            string reverse = name.ReverseString();
            Console.WriteLine("reverse string using extension method is - {0}", reverse);

            List<string> allNames = new List<string> { "sadan", "sadanroy", "skumar", "sprag" };
            //2 ways to get data
            var result = allNames.NameContainsSadan(); //extension method .. behind the scenes it convert into next code line
            var result1 = ExtensionMethod.NameContainsSadan(allNames);

            ////////////////////
            Console.WriteLine("--------------------------------Read only vs constant--------------------------");
            ConstantVsReadOnly.SomeMethod();



            //////////////////////////////////Signleton Pattern////////////////////////////////

            Console.WriteLine("--------------------------------Signleton Class--------------------------");
            SigletonClass obj = SigletonClass.ReturnSigletonObject;
            obj.PrintMessage();

            SigletonClass obj1 = SigletonClass.ReturnSigletonObject;
            obj1.PrintMessage();

            Console.ReadLine();


        }
    }
}
