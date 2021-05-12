using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpConcepts
{
    //Name of the class can be anything, here we are saying it sinleton
    //Sealed class for internal class inheritance prevention(nested class)
    sealed class SigletonClass
    {
        private static int counterForObjectCreation=0;
        private static readonly SigletonClass obj = new SigletonClass();

        //Private contructor prevents from object creation and external inheritance
        private SigletonClass()
        {
            counterForObjectCreation++;
            Console.WriteLine("object creation counter is - {0}", counterForObjectCreation);
        }
        public static SigletonClass ReturnSigletonObject
        {
            get
            {
                return obj;
            }
        }

        public void PrintMessage()
        {
            Console.WriteLine("Priint Method Invoked");
        }
    }
}
