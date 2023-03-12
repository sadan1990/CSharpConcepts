using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpConcepts
{
    public class GenericsMethod
    {
        public bool Compare<T>(T val1, T val2)
        {
            return val1.Equals(val2);
        }
    }

    public class GenericsClass<T> 
    {
        public bool Compare(T val1, T val2)
        {
            return val1.Equals(val2);
        }
    }

    //
    public class Student
    {
       public int id;
    }
    //where T: Student
    public class GenericsClassWhere<T> where T: Student
    {
        public int GetId(T val1)
        {
            return val1.id;//Here we can automatically access Student class property
        }
    }
    //where T: IComparable
    //where T: struct
    //where T: new() // It should have a default constructor
    //where T: Student


}
