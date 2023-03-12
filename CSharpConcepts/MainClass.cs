using System;
using System.Collections.Generic;

namespace CSharpConcepts
{
    class MainClass
    {
        static void Main(string[] args)
        {
            //////////////////////////////Out vs Ref ////////////////////////////////////
            //Console.WriteLine("--------------------------------Out vs Ref--------------------------");
            //int originalNumber = 10;
            //OutVsRef outVsRef = new OutVsRef();

            //outVsRef.AddNumbers(originalNumber);
            //Console.WriteLine("originalNumber number is - {0}", originalNumber);

            //int originalNumberOut;
            //outVsRef.AddNumbersUsingOut(out originalNumberOut);
            //Console.WriteLine("originalNumber number using out is - {0}", originalNumberOut);

            //int originalNumberRef=15;
            //outVsRef.AddNumbersUsingRef(ref originalNumberRef);
            //Console.WriteLine("originalNumber number using ref is - {0}", originalNumberRef);

            ///////////////////////////////Extension Method//////////////////////
            //Console.WriteLine("--------------------------------Extension Method--------------------------");
            //string name = "sadan";
            //string reverse = name.ReverseString();
            //Console.WriteLine("reverse string using extension method is - {0}", reverse);

            //List<string> allNames = new List<string> { "sadan", "sadanroy", "skumar", "sprag" };
            ////2 ways to get data
            //var result = allNames.NameContainsSadan(); //extension method .. behind the scenes it convert into next code line
            //var result1 = ExtensionMethod.NameContainsSadan(allNames);

            //////////////////////
            //Console.WriteLine("--------------------------------Read only vs constant--------------------------");
            //ConstantVsReadOnly.SomeMethod();



            ////////////////////////////////////Signleton Pattern////////////////////////////////

            //Console.WriteLine("--------------------------------Signleton Class--------------------------");
            //SigletonClass obj = SigletonClass.ReturnSigletonObject;
            //obj.PrintMessage();

            //SigletonClass obj1 = SigletonClass.ReturnSigletonObject;
            //obj1.PrintMessage();

            //LargestArrayNumber largestArrayNumber = new LargestArrayNumber();

            //int[] datas = { -6, -91, 1011, -100, 84, -22, 0, 1, 9, 473 };
            //var data = largestArrayNumber.GetLargestNumber(datas);


            //FizBuzzs.fizzBuzz(15);

            //BubbleSort bubbleSort = new BubbleSort();
            //bubbleSort.Sort();

            //Reverse reverse = new Reverse();
            //reverse.reverse();

            //Palindrom palindrom = new Palindrom();
            //palindrom.CheckPalindrom();
            //Console.ReadLine();


            ///////////////////////////Generics ////////////////////////
            GenericsMethod obj = new GenericsMethod();
             bool result= obj.Compare<int>(1, 2);

            GenericsClass<string> obj1 = new GenericsClass<string>();
            bool result1 =obj1.Compare("sadan", "sadan");


            Student obj2 = new Student
            {
                id = 4
            };
            GenericsClassWhere<Student> genericsClassWhere = new GenericsClassWhere<Student>();
            int id = genericsClassWhere.GetId(obj2);
            /////////////////////////////////////////////////////////////

        }
    }
}
